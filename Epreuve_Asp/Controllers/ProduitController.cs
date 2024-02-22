using BLL_Epreuve.Entities;
using Epreuve_Asp.Handlers;
using Epreuve_Asp.Models.Categorie;
using Epreuve_Asp.Models.Produit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Repositories;

namespace Epreuve_Asp.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitRepository<Produit> _produitRepository;
        private string? categorie;

        public ProduitController(IProduitRepository<Produit> produitRepository)
        {
            _produitRepository = produitRepository;
        }

        // GET: ProduitController
        //public ActionResult Index()
        //{
        //    IEnumerable<ProduitListItemViewModel> model = _produitRepository.Get().Select(d => d.ToListItem());
        //    return View(model);
        //}

        // Action Index pour le liste des produits par catégorie
        public ActionResult Index(string? categorie)
        {
            IEnumerable<ProduitListItemViewModel> model;
            if (string.IsNullOrEmpty(categorie))
            {
                model = _produitRepository.Get().Select(d => d.ToListItem());
            }
            else
            {
                model = _produitRepository.GetByCategorie(categorie).Select(d => d.ToListItem());
            }
            return View(model);
        }

        //Ajout d'une methode produit random
        public ActionResult ProduitRandom()
        { 
            IEnumerable<Produit> produitRandom = _produitRepository.GetRandomProduit(3);
            return View(produitRandom);
        }

        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            ProduitDetailsViewModel model = _produitRepository.Get(id).ToDetails();
            return View(model);
        }

        // GET: ProduitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ProduitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProduitController/Edit/5
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

        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProduitController/Delete/5
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
