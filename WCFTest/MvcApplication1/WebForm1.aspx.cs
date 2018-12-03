using MvcApplication1.ServiceReference3;
using System;

namespace MvcApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_OnClick(object sender, EventArgs e)
        {
            ServiceReference3.ICalculator s = new CalculatorClient();
            AddResult.Text = s.Add(int.Parse(Num1.Text), int.Parse(Num2.Text)).ToString();
        }

        protected void btnSubtract_OnClick(object sender, EventArgs e)
        {
            ServiceReference3.ICalculator s = new CalculatorClient();
            SubResult.Text = s.Subtract(int.Parse(Num3.Text), int.Parse(Num4.Text)).ToString();
        }
    }
}