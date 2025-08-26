using System.Net.NetworkInformation;
using System.Text;

Ping pingSender = new Ping();

PingOptions options = new PingOptions();
options.DontFragment = true;

string data = " Data to send ";
byte[] buffer = Encoding.UTF8.GetBytes(data);

int timeOut = 120;
string addressToPing = "8.8.8.8";

PingReply reply = pingSender.Send(addressToPing,timeOut,buffer,options);


if(reply.Status == IPStatus.Success)
{
    Console.WriteLine($"Response: {reply.Status}");
    Console.WriteLine($"RounfTrip: {reply.RoundtripTime}");
    Console.WriteLine($"Time To Live: {reply.Options.Ttl}");
    Console.WriteLine($"Buffer size: {buffer.Length}");
}





