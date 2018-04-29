using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UserApplicationSystem.Contracts
{
    // This solutions contains data and service contracts
    [DataContract]
    public class ProgramData
    {
        [DataMember]
        public String Message { get; set; }
        [DataMember]
        public String UserName { get; set; }
    }
}
