using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //客户端调用服务器端服务方式1 ：通过微软的svcutil 工具生成配置+代理类client
            UserInfoServiceClient userinfoClient = new UserInfoServiceClient();
            int result=userinfoClient.Add(1,2);
            UserInfo userinfo = userinfoClient.GetUserInfo();
            Console.WriteLine(userinfo.userName);



            OrderInfoServiceClient orderInfoClient = new OrderInfoServiceClient();
            int orderResult=orderInfoClient.Add();
            Console.WriteLine("orderinfo:"+orderResult);
            Console.ReadKey();
        }
    }
}
