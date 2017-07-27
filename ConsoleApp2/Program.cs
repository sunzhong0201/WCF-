
using ConsoleApp2.ServiceReference1;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //客户端调用服务器端服务方式2 直接添加服务引用方式  生成配置+代理类client
            ServiceReference1.UserInfoServiceClient userinfoClient = new ServiceReference1.UserInfoServiceClient();
            int result = userinfoClient.Add(20, 10);
            Console.WriteLine(result);
            UserInfo userinfo=userinfoClient.GetUserInfo();
            Console.WriteLine(userinfo.userName);


            ServiceReferenceOrderInfo.OrderInfoServiceClient orderClient = new ServiceReferenceOrderInfo.OrderInfoServiceClient();
            result=orderClient.Add();
            Console.WriteLine(result);
          
            Console.ReadKey();
        }
    }
}
