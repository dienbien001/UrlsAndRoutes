using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class LegacyController : Controller
    {
        // GET: Legacy
        public ActionResult GetLegacyURL(string legacyURL)
        {
            return View(legacyURL);
        }
    }
}