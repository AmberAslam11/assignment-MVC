
using amber.Data;
using AMBER.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace amber.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult check(login l)
        {
            foreach (var i in _context.login.ToList())
                if (i.username == l.username && i.password == l.password)
                {
                    ViewBag.message = "SUCCESSFULL";
                    return View("form");
                }
                else
                {
                    ViewBag.message = "FAILED";
                    return View("form");
                }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult form()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}