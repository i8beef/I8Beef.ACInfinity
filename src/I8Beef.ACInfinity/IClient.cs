using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using I8Beef.ACInfinity.Protocol;

namespace I8Beef.ACInfinity
{
    /// <summary>
    /// AC Infinity Client.
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// Gets all device info.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response.</returns>
        Task<ResponseBase> GetAllDeviceInfo(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get device port settings.
        /// </summary>
        /// <param name="deviceId">Device id.</param>
        /// <param name="port">Port number.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response.</returns>
        Task<ResponseBase> GetDevicePortSettings(string deviceId, int port, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response.</returns>
        Task Login(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceId">Device id.</param>
        /// <param name="port">Port number.</param>
        /// <param name="settings">Settings.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response.</returns>
        Task<ResponseBase> SetDevicePortSettings(string deviceId, int port, IDictionary<string, int> settings, CancellationToken cancellationToken = default);
    }
}
