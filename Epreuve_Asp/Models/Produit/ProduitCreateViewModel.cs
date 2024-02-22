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
        [Required(ErrorMessage = "Le prix de la catégorie est obligatoire.")]
        [MinLength(2, ErrorMessage = "Le prix doit avoir au minimum 1 chiffre.")]
        public decimal Prix { get; set; }

        [DisplayName("Eco score")]
        [Required(ErrorMessage = "L'eco score de la catégorie est obligatoire.")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "L'eco score doit avoir 1 caractère.")]
        public char EcoScore { get; set; }

        [Display(Name = "Nom de la catégorie")]
        public string NomCategorie { get; set; }
    }
}
