using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace Epreuve_Asp.Models.Produit
{
    public class ProduitDeleteViewModel
    {
        [ScaffoldColumn(false)]
        [Required]
        public int Id_Produit { get; set; }

        [DisplayName("Nom du produit")]
        [Required]
        public string Nom { get; set; }

        [DisplayName("Description")]
        public string? Description { get; set; }

        [DisplayName("Prix")]
        [DataType(DataType.Currency)]
        [Required]
        public decimal Prix { get; set; }

        [DisplayName("Eco score")]
        [Required]
        public char EcoScore { get; set; }

        [DisplayName("Nom de la catégorie")]
        
        public string NomCategorie { get; set; }

    }
}
