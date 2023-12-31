using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using I8Beef.ACInfinity.Protocol;

namespace I8Beef.ACInfinity.TestClient
{
    public class Program
    {
        public static async Task Main()
        {
            var username = "";
            var password = "";

            var client = new Client(username, password);

            var result = await client.GetAllDeviceInfo();

            var portResults = new List<PortSettings>();
            foreach (var port in result[0].DeviceInfo.Ports)
            {
                portResults.Add(await client.GetDevicePortSettings(result[0].DevId, port.Port));
            }

            Console.WriteLine($"Current temp: {result[0].DeviceInfo.TemperatureF! / 100m}");
            Console.WriteLine($"Current humidity: {result[0].DeviceInfo.Humidity! / 100m}");
            Console.WriteLine($"Current vpd: {result[0].DeviceInfo.Vpdnums! / 100m}");

            foreach (var port in portResults)
            {
                Console.WriteLine($"Port {port.DevSetting.ExternalPort} {result[0].DeviceInfo.Ports[port.DevSetting.ExternalPort!.Value - 1].PortName}: {port.Speak}");
            }

            Console.ReadKey();
        }
    }
}
