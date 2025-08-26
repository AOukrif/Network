using Network;
using System.Net.NetworkInformation;
using System.Text;

string data = " Data to send ";
int timeOut = 120;
string addressToPing = "8.8.8.8";

PingService service = new PingService(data, addressToPing, timeOut);
service.setOption();
service.Reply();
service.CheckResult();








