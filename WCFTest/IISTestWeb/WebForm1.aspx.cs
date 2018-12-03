using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IISTestWeb.ServiceReference1;

namespace IISTestWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void btnGetJobs_OnClick(object sender, EventArgs e)
        {
            ServiceReference1.JobOpeningServiceClient client = new JobOpeningServiceClient();
            grd.DataSource = client.GetJobOpening();
            grd.DataBind();
        }

        protected void btnGetJobsManager_OnClick(object sender, EventArgs e)
        {
            ServiceReference1.JobOpeningServiceClient client = new JobOpeningServiceClient();
            client.GetJobOpeningByRole("Manager");
            grd.DataSource = client.GetJobOpeningByRole("Manager");
            grd.DataBind();
        }

        protected void btnGetJobsDeveloper_OnClick(object sender, EventArgs e)
        {
            ServiceReference1.JobOpeningServiceClient client = new JobOpeningServiceClient();
            client.GetJobOpeningByRole("Developer");
            grd.DataSource = client.GetJobOpeningByRole("Developer");
            grd.DataBind();
        }

        protected void btnGetJobsArchitect_OnClick(object sender, EventArgs e)
        {
            ServiceReference1.JobOpeningServiceClient client = new JobOpeningServiceClient();
            client.GetJobOpeningByRole("Architect");
            grd.DataSource = client.GetJobOpeningByRole("Architect");
            grd.DataBind();
        }
    }
}