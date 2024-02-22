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
        public ActionResult Details(int id)
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
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategorieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategorieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategorieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
