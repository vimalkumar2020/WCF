using System;

namespace WcfService1
{
    public class Service1 : IService1
    {
        public string SayHello(string name)
        {
            if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour < 12)
            {
                return "Good Morning " + name; 
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 16)
            {
                return "Good Afternoon " + name;
            }
            else if (DateTime.Now.Hour >= 16 && DateTime.Now.Hour <= 23)
            {
                return "Good Evening " + name;
            }
            return string.Empty;
        }

        public string TodayProgram()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                return "Happy Weekend";
            }
            return "Enjoy working day";
        }
    }
}
