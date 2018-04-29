using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using UserApplicationSystem.Contracts;

namespace UserApplicationSystem.Proxies
{
    public class UserApplicationSystemClient : ClientBase<IUserApplicationSystemService>, IUserApplicationSystemService
    {
        public ProgramData DisplayUser(string userName)
        {
            return Channel.DisplayUser(userName);
        }
    }
}
