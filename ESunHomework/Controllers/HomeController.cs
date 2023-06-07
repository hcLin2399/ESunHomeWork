using ESunHomework.Service;
using System.Web.Mvc;

namespace ESunHomework.Controllers
{
    public class HomeController : Controller
    {
        public service service1 = new service();

        public ActionResult Index()
        {
            service1.GetApiData();
            var data = service1.getTableData();

            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}