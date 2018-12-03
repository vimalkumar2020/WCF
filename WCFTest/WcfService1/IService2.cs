using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        string SayHello(string name);

        [OperationContract]
        string TodayProgram();
    }
}
