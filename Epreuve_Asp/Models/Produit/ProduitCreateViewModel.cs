using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace Epreuve_Asp.Models.Produit
{
    public class ProduitCreateViewModel
    {
        [DisplayName("Nom du produit")]
        [Required(ErrorMessage = "Le nom du produit est obligatoire.")]
        [MinLength(2, ErrorMessage = "Le nom doit avoir au minimum 2 caractères.")]
        public string Nom { get; set; }

        [DisplayName("Description")]
        public string? Description { get; set; }

        [DisplayName("Prix")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Le prix de la catégorie est obligatoire.")]
        [Range(0, double.MaxValue, ErrorMessage = "Le prix doit être supérieur ou égal à 0.")]
        public decimal Prix { get; set; }

        [DisplayName("Eco score")]
        public char EcoScore { get; set; }

        [Display(Name = "Nom de la catégorie")]
        public string NomCategorie { get; set; }
    }
}
