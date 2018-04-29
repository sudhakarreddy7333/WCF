using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserApplicationSystem.WCF.Repository_Interfaces;

namespace UserApplicationSystem.WCF.Repositories
{
    public class GetMessage : IGetMessage
    {
        public string GetUserMessage(string userName)
        {
            String Message = null;
            if (userName == "Sudhakar")
            {
                Message = "Sudhakar is a good boy";
            }
            else
                Message = "User is a boy";
            return Message;
        }
    }
}