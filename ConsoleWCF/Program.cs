using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            //宿主服务集合 
            ServiceHost[] servciceHosts = new ServiceHost[]{
                new ServiceHost(typeof(UserInfoService)),
                new ServiceHost(typeof(OrderInfoService))
            };
            //开启所有的宿主服务
            foreach (var servciehost in servciceHosts)
            {
                servciehost.Open();
              
            }
            Console.WriteLine("WCF宿主机已经启动!");
            Console.ReadKey();



            //using(ServiceHost hostUserInfo = new ServiceHost(typeof(UserInfoService)))
            //{
            //    hostUserInfo.Open();
            //    Console.WriteLine("WCF宿主机已经启动!");
            //    Console.ReadKey();
            //}

            
        }
    }
}
