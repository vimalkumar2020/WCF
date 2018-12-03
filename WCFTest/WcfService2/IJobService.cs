using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService2
{
    [ServiceContract]
    public interface IJobService
    {
        [OperationContract]
        List<JobOpeningModel> GetJobOpening();

        [OperationContract]
        List<JobOpeningModel> GetJobOpeningByRole(string role);
    }
}
