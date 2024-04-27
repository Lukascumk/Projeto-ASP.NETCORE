using Microsoft.AspNetCore.Mvc;
using Projeto_Web.Models;
using System.Diagnostics;

namespace Projeto_Web.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Nome = "Lukas Mota";
            home.Email = "lukas.mota@outlook.com";


            return View(home);
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
