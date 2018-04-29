using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using UserApplicationSystem.Contracts;
using UserApplicationSystem.Proxies;

namespace UserApplicationSystem.clie
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostMgr = new ServiceHost(typeof(UserApplicationSystem.Services.UASManager));
            hostMgr.Open();
            UserApplicationSystemClient client = new UserApplicationSystemClient();
            ProgramData message = client.DisplayUser("sudhakar");
            Console.WriteLine(message);
            Console.ReadKey();
            client.Close();
            hostMgr.Close();
        }
    }
}
