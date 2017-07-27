using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    [ServiceContract]
    public interface IUserInfoService
    {
        [OperationContract]
        int Add(int a, int b);
        [OperationContract]
        int Sub(int a, int b);

        [OperationContract]
        UserInfo GetUserInfo();
    }
}
