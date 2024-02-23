using BLL_Epreuve.Entities;
using Epreuve_Asp.Handlers;
using Epreuve_Asp.Models.Categorie;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Repositories;

namespace Epreuve_Asp.Controllers 
{
    public class CategorieController : Controller
    {
        private readonly ICategorieRepository<Categorie> _categorieRepository;
        public CategorieController(ICategorieRepository<Categorie> categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }

        // GET: CategorieController
        public ActionResult Index()
        {
            IEnumerable<CategorieListItemViewModel> model = _categorieRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: CategorieController/Details/5
        public ActionResult Details(string id)
        {
            return View();
        }

        // GET: CategorieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategorieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategorieCreateViewModel form)
            {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues.");
                if (!ModelState.IsValid) throw new Exception();
                string id = _categorieRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategorieController/Edit/5
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: CategorieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategorieController/Delete/5
        public ActionResult Delete(string id)
        {
            try
            {
                CategorieDeleteViewModel model = _categorieRepository.Get(id).Delete();
                if (model is null) throw new InvalidCastException();
                return View(model);
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = $"L'identifiant {id} est invalide";
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: CategorieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, CategorieDeleteViewModel model)
        {
            try
            {
                _categorieRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
