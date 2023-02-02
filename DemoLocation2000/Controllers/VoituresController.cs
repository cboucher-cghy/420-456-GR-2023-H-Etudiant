using Microsoft.AspNetCore.Mvc;

namespace DemoLocation2000.Controllers
{
    public class VoituresController : Controller
    {
        //[Route("abc")]
        //[Route("{controller}/{action}/{annee:length(4)}")]
        public IActionResult DateVendu(int annee)
        {
            return View("Index");
        }
    }
}
