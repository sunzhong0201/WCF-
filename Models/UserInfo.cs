using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]  //数据契约
    public class UserInfo
    {
        [DataMember] 
        public int id { get; set; }

        [DataMember]
        public string userName { get; set; }

        [DataMember]
        public int Gender { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
