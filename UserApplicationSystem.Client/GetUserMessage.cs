using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApplicationSystem.Contracts;
using UserApplicationSystem.Proxies;

namespace UserApplicationSystem.Client
{
    class GetUserMessage
    {
        public static void Main(String[] args)
        {
            UserApplicationSystemClient client = new UserApplicationSystemClient();
            ProgramData message = client.DisplayUser("sudhakar");
            Console.WriteLine(message);
            Console.ReadKey();
            client.Close();
        }
    }
}
