using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3IIS
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = userinfoClient.Add(20, 10);
            //Console.WriteLine(result);
            //Console.ReadKey();

            ServiceReference1.UserInfoServiceClient client = new ServiceReference1.UserInfoServiceClient();
            int result = client.Add(1, 2);

            Console.WriteLine(result);

            result = client.Sub(3, 2);

            Console.WriteLine(result);


            ServiceReferenceOrderInfo.OrderInfoServiceClient orderclient = new ServiceReferenceOrderInfo.OrderInfoServiceClient();
            result=orderclient.Add();
            Console.WriteLine(result);
          
            Console.ReadKey();
        }
    }
}
