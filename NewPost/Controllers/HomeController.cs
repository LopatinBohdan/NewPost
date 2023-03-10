using Microsoft.AspNetCore.Mvc;
using NewPost.Models;
using System.Diagnostics;

namespace NewPost.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        NewPostContext db;
        public HomeController(ILogger<HomeController> logger, NewPostContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
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