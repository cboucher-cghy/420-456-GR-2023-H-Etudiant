using DemoLocation2000.Models;
using DemoLocation2000.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoLocation2000.Controllers
{
    public class VoituresController : Controller
    {
        private static int _counter = 1;
        private static List<Voiture> _voitures = new()
        {
            new()
            {
                Id=_counter++,
                Nom="Dodge RAM",
                Annee=1999
            },
            new()
            {
                Id=_counter++,
                Nom="Dodge RAM",
                Annee=2009
            },
            new()
            {
                Id=_counter++,
                Nom="BMW i325",
                Annee=2022
            },
            new()
            {
                Id=_counter++,
                Nom="Toyota RAV4",
                Annee=2022
            },
            new()
            {
                Id=_counter++,
                Nom="Toyota Corolla",
                Annee=2023
            },
        };

        //[Route("abc")]
        //[Route("{controller}/{action}/{annee:length(4)}")]
        public IActionResult DateVendu(int annee)
        {

            return View("Index");
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Index(int? annee)
        //{
        //    return View(_voitures.Where(x => x.Annee == annee).ToList());
        //}

        public IActionResult Index(int? annee)
        {
            IQueryable<Voiture> list = _voitures.AsQueryable();
            if (annee.HasValue)
            {
                list = list.Where(x => x.Annee == annee);
            }
            return View(list.ToList());
        }

        [HttpPost]
        public IActionResult Creation(VoitureCreationVM obj)
        {
            return View();
        }

        public IActionResult Liste()
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
