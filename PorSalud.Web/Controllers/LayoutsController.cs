using System.Web.Mvc;

namespace PorSalud.Web.Controllers
{
    public class LayoutsController : Controller
    {
        public ActionResult LeftMenu()
        {
            return PartialView();
        }
    }
}