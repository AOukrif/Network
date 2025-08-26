using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    internal class PingService
    {
        public string Data { get; set; }
        public string Address { get; set; }
        public int TimeOut { get; set; }
        public byte []  Buffer { get; set; }
        public Ping pingSender  { get; set; }
        public PingReply pingReply { get; set; }
        public PingOptions pingOptions { get; set; }

        public PingService(string data , string address , int timeOut)
        {
            this.Data = data;
            this.Address = address;
            this.TimeOut = timeOut;
            this.Buffer = Encoding.UTF8.GetBytes(data);
            this.pingSender = new Ping();
            this.pingOptions = new PingOptions(); 
        }

        public void setOption()
        {
            pingOptions.DontFragment = true;
        }

        public void Reply()
        {
            pingReply=pingSender.Send(Address, TimeOut,Buffer,pingOptions);
        }

        public void CheckResult()
        {
            if (pingReply.Status == IPStatus.Success)
            {
                Console.WriteLine($"Response: {pingReply.Status}");
                Console.WriteLine($"RounfTrip: {pingReply.RoundtripTime}");
                Console.WriteLine($"Time To Live: {pingReply.Options.Ttl}");
                Console.WriteLine($"Buffer size: {Buffer.Length}");
            }
        }
    }
}
