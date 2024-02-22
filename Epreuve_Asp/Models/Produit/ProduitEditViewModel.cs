using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Epreuve_Asp.Models.Produit
{
    public class ProduitEditViewModel
    {
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

        [ScaffoldColumn(false)]
        [Required]
        public String NomCategorie { get; set; }

    }
}
