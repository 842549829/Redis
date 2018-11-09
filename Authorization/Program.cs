using System;
using ServiceStack.Redis;

namespace Authorization
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisClient client = new RedisClient("127.0.0.1", 6379);
            client.Set<string>("DB1", "CGDFDFDFDF");

            for (int i = 0; i < 10000; i++)
            {
                try
                {
                    var d = client.Get<string>("DB1");
                }
                catch (Exception exxx)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(exxx.Message);
                }

            }
            Console.WriteLine("Hello World!");
        }
    }
}
