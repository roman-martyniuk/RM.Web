using Microsoft.AspNetCore.Mvc;

namespace RM.Web.Controllers
{
    public class RMController : Controller
    {
        [Route("")]
        public IActionResult Home()
        {
            return View("~/Views/Home.cshtml");
        }

        [Route("projects.html")]
        public IActionResult Projects()
        {
            return View("~/Views/Projects.cshtml");
        }

        [Route("profile.html")]
        public IActionResult Profile()
        {
            return View("~/Views/Profile.cshtml");
        }
    }
}