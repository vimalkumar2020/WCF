using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService2
{
    public class WcfService2 : IJobService
    {
        public List<JobOpeningModel> jobList = new List<JobOpeningModel>()
        {
            new JobOpeningModel() { Company ="CTS",Experience =1, Role = "Manager"},
            new JobOpeningModel() { Company ="Google",Experience =8, Role = "Manager"},
            new JobOpeningModel() { Company ="HP",Experience =2, Role = "Developer"},
            new JobOpeningModel() { Company ="Dell",Experience =5, Role = "Developer"},
            new JobOpeningModel() { Company ="HP",Experience =2, Role = "Architect"},
            new JobOpeningModel() { Company ="Dell",Experience =5, Role = "Architect"},
        };
        public List<JobOpeningModel> GetJobOpening()
        {
            return jobList;
        }

        public List<JobOpeningModel> GetJobOpeningByRole(string role)
        {
            return jobList.Where(a => a.Role == role).ToList();
        }
    }

    public class JobOpeningModel
    {
        public string Company { get; set; }
        public string Role { get; set; }
        public int Experience { get; set; }
    }
}