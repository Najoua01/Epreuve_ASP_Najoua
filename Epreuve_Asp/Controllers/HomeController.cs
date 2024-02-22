using BLL_Epreuve.Services;
using DAL_Epreuve.Services;
using Shared.Repositories;
using Epreuve_Asp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using BLL_Epreuve.Entities;

namespace Epreuve_Asp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProduitRepository<BLL_Epreuve.Entities.Produit> _produitService;

        public HomeController(ILogger<HomeController> logger, IProduitRepository<BLL_Epreuve.Entities.Produit> produitService)
        {
            _logger = logger;
            _produitService = produitService;
        }

        public IActionResult Index()
        {
            IEnumerable<BLL_Epreuve.Entities.Produit> produitRandom = _produitService.GetRandomProduit(3);
            return View(produitRandom);
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
