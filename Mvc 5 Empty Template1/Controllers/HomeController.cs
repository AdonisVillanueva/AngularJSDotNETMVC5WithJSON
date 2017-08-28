using System.Web.Mvc;
using Angular_MVC5_App.Models;

namespace Angular_MVC5_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee e = new Employee() { FirstName = "John", LastName = "Doe" };
            return View(e);

        }

        public ActionResult UpdateData(string p1)
        {
            var updatedData = p1 + "--Update Successful--";
            var response = new Employee() { FirstName = "Jane", LastName = "Doe", Extra=updatedData};
            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}