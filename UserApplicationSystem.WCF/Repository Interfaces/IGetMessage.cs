using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApplicationSystem.WCF.Repository_Interfaces
{
    public interface IGetMessage
    {
        String GetUserMessage(String userName);
    }
}
