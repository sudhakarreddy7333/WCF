using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApplicationSystem.Contracts;
using UserApplicationSystem.WCF.Repositories;
using UserApplicationSystem.WCF.Repository_Interfaces;

namespace UserApplicationSystem.Services
{
    public class UASManager : IUserApplicationSystemService
    {
        public ProgramData DisplayUser(string userName)
        {
            ProgramData message = null;
            IGetMessage getMessageRepo = new GetMessage();
            String messageEntity = getMessageRepo.GetUserMessage(userName);
            if(messageEntity != null)
            {
                message = new ProgramData()
                {
                    UserName = userName,
                    Message = messageEntity
                };
            }
            return message;
        }
    }
}
