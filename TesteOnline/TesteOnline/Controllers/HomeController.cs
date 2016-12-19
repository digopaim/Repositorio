using System.Web.Mvc;

namespace Ecommerce.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


    }
}