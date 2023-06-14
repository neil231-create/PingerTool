using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace PingerTool
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Pinging Google DNS Server 4.2.2.2

            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            options.DontFragment = true;

            string data = "Learn to code";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            string address = "4.2.2.2";
            PingReply reply = pingSender.Send(address, timeout, buffer, options);

            if(reply.Status == IPStatus.Success)
            {
                Console.WriteLine($"Response: {reply.Status}");
                Console.WriteLine($"Roundtrip: {reply.RoundtripTime}");
            }



        }
    }
}
