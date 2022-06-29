using Microsoft.AspNetCore.Mvc;

namespace AMBER.Controllers
{
    public class HOMECONTROL : Controller
    {
        public IActionResult Index()
        {
            return View("HOMESSS");
        }
    }
}
