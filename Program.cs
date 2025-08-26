using Network;
using System.Net.NetworkInformation;
using System.Text;

class Program
{
    public static void Main()
    {
        //string data = " Data to send ";
        //int timeOut = 120;
        //string addressToPing = "8.8.8.8";

        var input = PingHelper.setData();

        PingService service = new PingService(input.Data, input.address, input.timeOut);
        service.setOption();
        service.SendPing();
        service.CheckResult();


    }
}








