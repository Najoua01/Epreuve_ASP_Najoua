using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Epreuve_Asp.Models.Produit
{
    public class ProduitListItemViewModel
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
        [Required]
        public decimal Prix { get; set; }

        [DisplayName("Eco score")]
        [Required]
        public char EcoScore { get; set; }

        [DisplayName("Nom de la catégorie")]
        public string NomCategorie { get; set; }
    }
}
