using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Epreuve_Asp.Models.Categorie
{
    public class CategorieListItemViewModel
    {
        [DisplayName("Catégorie")]
        [Required]
        public string NomCategorie { get; set; }
    }
}
