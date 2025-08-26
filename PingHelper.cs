using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    public class PingHelper
    {
        public static (string Data , int timeOut , string address ) setData()
        {
            Console.WriteLine("Enter the data to send  ");
            string Data = Console.ReadLine();
            Console.WriteLine("Enter the time out  ");
            int timeOut = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the address to ping");
            string addressToPing= Console.ReadLine();

            return (Data , timeOut , addressToPing );
        }
    }
}
