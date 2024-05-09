using Microsoft.AspNetCore.Mvc;
using SimpleDN8MVCWebNoAuth.Models;
using System.Diagnostics;

namespace SimpleDN8MVCWebNoAuth.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {

            _configuration = configuration;
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            ViewData["deploymentRegion"] = _configuration["region"] ?? "Region Not Set";
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
