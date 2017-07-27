using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    [ServiceContract]
    public interface IOrderInfoService
    {
        [OperationContract]
        int Add();

    }
}
