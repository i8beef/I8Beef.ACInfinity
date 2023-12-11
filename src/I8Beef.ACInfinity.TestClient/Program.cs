namespace I8Beef.ACInfinity.TestClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var username = "";
            var password = "";

            var client = new Client(username, password);

            var result = client.GetAllDeviceInfo();

            Console.ReadKey();
        }
    }
}
