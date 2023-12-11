using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using I8Beef.ACInfinity.Protocol;
using System.Linq;

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
        public async Task<ResponseBase> GetAllDeviceInfo(CancellationToken cancellationToken = default)
        {
            if (_token is null)
            {
                await Login(cancellationToken);
            }

            return await Get<ResponseBase>($"{_baseUrl}/api/user/devInfoListAll", cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<ResponseBase> GetDevicePortSettings(string deviceId, int port, CancellationToken cancellationToken = default)
        {
            if (_token is null)
            {
                await Login(cancellationToken);
            }

            var model = new Dictionary<string, string>
            {
                { "devId", deviceId },
                { "port", port.ToString() }
            };

            return await Post<ResponseBase>($"{_baseUrl}/api/dev/getdevModeSettingList", model, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<ResponseBase> SetDevicePortSettings(string deviceId, int port, IDictionary<string, int> settings, CancellationToken cancellationToken = default)
        {
            if (_token is null)
            {
                await Login(cancellationToken);
            }

            var activeSettings = await GetDevicePortSettings(deviceId, port, cancellationToken);

            var model = activeSettings.Data.ToDictionary(x => x.Key, x => x.Value.ToString());
            ;
            foreach (var setting in settings)
            {
                model[setting.Key] = setting.Value.ToString();
            }

            return await Post<ResponseBase>($"{_baseUrl}/api/dev/addDevMode", model, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task Login(CancellationToken cancellationToken = default)
        {
            var model = new Dictionary<string, string>
            {
                { "appEmail", _username },
                { "appPasswordl", _password }
            };

            var response = await Post<ResponseBase>($"{_baseUrl}/api/user/appUserLogin", model, cancellationToken)
                    .ConfigureAwait(false);

            _token = response.Data["appId"].ToString();
        }

        private async Task<TType> Get<TType>(string url, CancellationToken cancellationToken = default)
            where TType : class
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);

            requestMessage.Headers.Add("User-Agent", "ACController/1.8.2 (com.acinfinity.humiture; build:489; iOS 16.5.1) Alamofire/5.4.4");
            requestMessage.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");

            if (_token != null)
            {
                requestMessage.Headers.Add("token", _token);
            }

            var response = await SendAsyncWithTimeout(requestMessage, cancellationToken)
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);

            return JsonSerializer<TType>.Deserialize(responseString);
        }

        private async Task<TType> Post<TType>(string url, IDictionary<string, string> payload, CancellationToken cancellationToken = default)
            where TType : class
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new FormUrlEncodedContent(payload)
            };

            requestMessage.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            requestMessage.Headers.Add("User-Agent", "ACController/1.8.2 (com.acinfinity.humiture; build:489; iOS 16.5.1) Alamofire/5.4.4");
            requestMessage.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");

            if (_token != null)
            {
                requestMessage.Headers.Add("token", _token);
            }

            // Set basic auth header
            var byteArray = Encoding.ASCII.GetBytes(_username + ":" + _password);
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            var response = await SendAsyncWithTimeout(requestMessage, cancellationToken)
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);

            return JsonSerializer<TType>.Deserialize(responseString);
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
