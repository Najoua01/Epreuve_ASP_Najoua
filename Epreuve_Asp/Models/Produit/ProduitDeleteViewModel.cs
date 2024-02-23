using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace Epreuve_Asp.Models.Produit
{
    public class ProduitDeleteViewModel
    {
        
        [DisplayName("Nom du produit")]
        [Required]
        public string Nom { get; set; }

    }
}
