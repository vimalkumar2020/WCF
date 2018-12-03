using MvcApplication1.Models;
using MvcApplication1.ServiceReference1;
using MvcApplication1.ServiceReference2;
using System.Web.Mvc;
using MvcApplication1.ServiceReference3;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? i)
        {
            return View(new TcpHttpModel());
        }

        public ActionResult GetHttp()
        {
            ServiceReference1.IService1 s1 = new Service1Client();

            return View("Index", new TcpHttpModel()
            {
                HelloMessage = s1.SayHello("Ram")
            });
        }

        public ActionResult GetTcp()
        {
            ServiceReference2.IService2 s = new Service2Client();
            s.SayHello("Ram");
            return View("Index", new TcpHttpModel()
            {
                HelloMessage = s.SayHello("Ram")
            });
        }

        public ActionResult GetWeekHttp()
        {
            ServiceReference1.IService1 s = new Service1Client();
            return View("Index", new TcpHttpModel()
            {
                WeekMessage = s.TodayProgram()
            });
        }

        public ActionResult GetWeekTcp()
        {
            ServiceReference2.IService2 s = new Service2Client();
            s.SayHello("Ram");
            return View("Index", new TcpHttpModel()
            {
                WeekMessage = s.TodayProgram()
            });
        }

        
    }
}