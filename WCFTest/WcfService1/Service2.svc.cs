using System;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService2
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
