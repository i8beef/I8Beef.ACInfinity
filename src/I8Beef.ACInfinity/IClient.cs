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
        Task<List<Device>> GetAllDeviceInfo(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get device port settings.
        /// </summary>
        /// <param name="deviceId">Device id.</param>
        /// <param name="port">Port number.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response.</returns>
        Task<PortSettings> GetDevicePortSettings(string deviceId, int port, CancellationToken cancellationToken = default);

        /// <summary>
        /// Login.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response.</returns>
        Task Login(CancellationToken cancellationToken = default);

        /// <summary>
        /// Sets a device ports settings.
        /// </summary>
        /// <param name="deviceId">Device id.</param>
        /// <param name="port">Port number.</param>
        /// <param name="settings">Settings.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response.</returns>
        Task<PortSettings> SetDevicePortSettings(string deviceId, int port, PortInfo settings, CancellationToken cancellationToken = default);
    }
}
