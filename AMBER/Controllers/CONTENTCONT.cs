using Microsoft.AspNetCore.Mvc;

namespace AMBER.Controllers
{
    public class CONTENTCONT : Controller
    {
        public IActionResult Index()
        {
            return View("CONTT");
        }
    }
}
