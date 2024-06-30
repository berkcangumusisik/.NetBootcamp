using Microsoft.AspNetCore.Mvc;
using MVC.Web.Models;
using System.Diagnostics;
using MVC.Web.Helpers;

namespace MVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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


        public IActionResult RedirectToArticle()
        {
            var Title = "Asp.Net Core ile Gelen Yenilikler.C#_�";
            var id = 30;

            return RedirectToAction("Index", "Article", new { title = Title.MakeSeoFriendly(), id = id });

            //RedirectToAction ile y�nlendirme yaparken, y�nlendirilecek controller ve action isimlerini belirtirken,
        }
    }
}
