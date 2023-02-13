using DemoLocation2000.Data;
using DemoLocation2000.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoLocation2000.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
            var voitures = _context.Voitures.ToList();

            context.Voitures.Add(new Voiture()
            {
                Nom = "Mustang",
                Annee = 2000
            });
            context.SaveChanges();
        }

        public IActionResult Index()
        {
            Console.WriteLine("");
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