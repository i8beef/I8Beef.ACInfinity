using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using I8Beef.ACInfinity.Protocol;

namespace I8Beef.ACInfinity
{
    /// <inheritdoc />
    public class Client : IClient
    {
        private const string _baseUrl = "http://www.acinfinityserver.com";
        private static readonly HttpClient _httpClient = new HttpClient { Timeout = Timeout.InfiniteTimeSpan };
        private readonly string _username;
        private readonly string _password;
        private readonly TimeSpan _timeout;

        private string? _token;

        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="username">Apex username.</param>
        /// <param name="password">Apex password.</param>
        public Client(string username, string password)
            : this(username, password, TimeSpan.FromSeconds(100))
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="username">Apex username.</param>
        /// <param name="password">Apex password.</param>
        /// <param name="timeout">Timeout to use for all HTTP calls.</param>
        public Client(string username, string password, TimeSpan timeout)
        {
            _username = username;
            _password = password;
            _timeout = timeout;
        }

        /// <inheritdoc />
        public async Task<List<Device>> GetAllDeviceInfo(CancellationToken cancellationToken = default)
        {
            if (_token is null)
            {
                await Login(cancellationToken);
            }

            var model = new GetAllDeviceRequest
            {
                UserId = _token!
            };

            return await Post<List<Device>, GetAllDeviceRequest>($"{_baseUrl}/api/user/devInfoListAll", model, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<PortSettings> GetDevicePortSettings(string deviceId, int port, CancellationToken cancellationToken = default)
        {
            if (_token is null)
            {
                await Login(cancellationToken);
            }

            var model = new GetDevicePortSettingsRequest
            {
                DeviceId = deviceId,
                Port = port
            };

            return await Post<PortSettings, GetDevicePortSettingsRequest>($"{_baseUrl}/api/dev/getdevModeSettingList", model, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<PortSettings> SetDevicePortSettings(string deviceId, int port, PortInfo settings, CancellationToken cancellationToken = default)
        {
            if (_token is null)
            {
                await Login(cancellationToken);
            }

            return await Post<PortSettings, PortInfo>($"{_baseUrl}/api/dev/addDevMode", settings, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task Login(CancellationToken cancellationToken = default)
        {
            var model = new LoginRequest
            {
                AppEmail = _username,
                AppPasswordL = _password
            };

            var response = await Post<AppData, LoginRequest>($"{_baseUrl}/api/user/appUserLogin", model, cancellationToken)
                    .ConfigureAwait(false);

            _token = response.AppId;
        }

        private async Task<TResponse> Post<TResponse, TRequest>(string url, TRequest payload, CancellationToken cancellationToken = default)
            where TRequest : class
            where TResponse : class
        {
            var json = JsonSerializer.Serialize(payload);
            var dictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(json);

            var correctedDictionary = new Dictionary<string, string>();
            foreach (var key in dictionary!.Keys)
            {
                correctedDictionary.Add(key, dictionary[key].ToString());
            }

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new FormUrlEncodedContent(correctedDictionary)
            };

            requestMessage.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            requestMessage.Headers.Add("User-Agent", "ACController/1.8.2 (com.acinfinity.humiture; build:489; iOS 16.5.1) Alamofire/5.4.4");

            if (_token != null)
            {
                requestMessage.Headers.Add("token", _token);
            }

            var response = await SendAsyncWithTimeout(requestMessage, cancellationToken)
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            // TODO: Enact reponse code check 

            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);

            return JsonSerializer.Deserialize<ResponseBase<TResponse>>(responseString, _jsonOptions)!.Data;
        }

        /// <summary>
        /// Executes HttpClient.SendAsync() with a timeout extension.
        /// </summary>
        /// <param name="requestMessage">Same as parameters in HttpClient.SendAsync()</param>
        /// <param name="cancellationToken">Same as parameters in HttpClient.SendAsync()</param>
        /// <returns>The <see cref="HttpResponseMessage"/>.</returns>
        /// <remarks>
        /// The HttpClient has a Timout feature that has been poorly implemented in that it raises an ambiguous exception on timeout.
        /// This wraps the HttpClient.SendAsync() and adds a proper timeout option.
        /// </remarks>
        private async Task<HttpResponseMessage> SendAsyncWithTimeout(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        {
            var timoutCts = new CancellationTokenSource(_timeout);
            var aggregateCts = CancellationTokenSource.CreateLinkedTokenSource(timoutCts.Token, cancellationToken);

            try
            {
                return await _httpClient.SendAsync(requestMessage, aggregateCts.Token)
                    .ConfigureAwait(false);
            }
            catch (TaskCanceledException) when (timoutCts.IsCancellationRequested)
            {
                throw new TimeoutException("HTTP request timed out.");
            }
        }
    }
}
