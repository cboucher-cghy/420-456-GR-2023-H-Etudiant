using DemoLocation2000.Data;
using DemoLocation2000.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoLocation2000.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            _logger.LogCritical("C'est critique!!");
            _logger.LogDebug("C'est pour déboguer!");
        }

        public IActionResult AjouterVoiture()
        {
            //var voitures = _context.Voitures.ToList();

            _context.Voitures.Add(new Voiture()
            {
                Nom = "Mustang",
                Annee = 2000
            });
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
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