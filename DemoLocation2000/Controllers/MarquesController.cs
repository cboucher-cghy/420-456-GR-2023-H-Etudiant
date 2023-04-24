using AutoMapper;
using DemoLocation2000.Data;
using DemoLocation2000.Models;
using DemoLocation2000.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoLocation2000.Controllers
{
    public class MarquesController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public MarquesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Marques
        public async Task<IActionResult> Index()
        {

            var marques = await _context.Marques
                .Select(x => new MarqueIndexVM()
                {
                    Id = x.Id,
                    Nom = x.Nom,
                })
                .ToListAsync();

            // Autre façon de faire
            //var vm = new List<MarqueIndexVM>();
            //foreach (var marque in marques)
            //{
            //    vm.Add(new MarqueIndexVM()
            //    {
            //        Id = marque.Id,
            //        Nom = marque.Nom,
            //    });
            //}
            return View(marques);
        }

        // GET: Marques/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Marques == null)
            {
                return NotFound();
            }

            var marque = await _context.Marques
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marque == null)
            {
                return NotFound();
            }

            return View(marque);
        }

        // GET: Marques/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Marques/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MarqueCreateVM vm)
        {
            if (ModelState.IsValid)
            {
                //var marque = new Marque()
                //{
                //    Nom = vm.Nom,
                //};
                var marque = _mapper.Map<Marque>(vm);


                _context.Add(marque);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null || _context.Marques == null)
            {
                return NotFound();
            }

            var marque = _context.Marques
                .Select(x => new MarqueEditVM()
                {
                    Nom = x.Nom,
                    Id = x.Id
                })
                .FirstOrDefault(x => x.Id == id);
            if (marque == null)
            {
                return NotFound();
            }
            return View(marque);
        }

        // POST: Marques/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom")] MarqueEditVM vm)
        {
            if (id != vm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // On doit le récupérer de la BD pour obtenir la liste des modèles associés.
                    Marque? marque = _context.Marques.Find(vm.Id);
                    if (marque == null)
                    {
                        return NotFound();
                    }

                    marque.Id = vm.Id;
                    marque.Nom = vm.Nom;

                    _context.Update(marque);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarqueExists(vm.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }

        // GET: Marques/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Marques == null)
            {
                return NotFound();
            }

            var marque = await _context.Marques
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marque == null)
            {
                return NotFound();
            }

            return View(marque);
        }

        // POST: Marques/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Marques == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Marques'  is null.");
            }
            var marque = await _context.Marques.FindAsync(id);
            if (marque != null)
            {
                _context.Marques.Remove(marque);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarqueExists(int id)
        {
            return _context.Marques.Any(e => e.Id == id);
        }
    }
}
