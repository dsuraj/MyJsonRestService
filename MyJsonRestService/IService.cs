using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using MyJsonRestService.FaultException;

namespace MyJsonRestService
{
    [ServiceContract]
    interface IService
    {
        [OperationContract]
        [FaultContract(typeof(InvalidJson))]
        string FilterData(string input);
    }
}
