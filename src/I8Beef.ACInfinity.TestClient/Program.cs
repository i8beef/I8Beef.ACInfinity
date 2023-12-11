using I8Beef.ACInfinity.Protocol;

namespace I8Beef.ACInfinity.TestClient
{
    public class Program
    {
        public static async Task Main(string[] args)
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

            Console.ReadKey();
        }
    }
}
