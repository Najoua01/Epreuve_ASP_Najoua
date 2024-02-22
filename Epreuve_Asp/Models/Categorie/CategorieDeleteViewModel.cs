using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Epreuve_Asp.Models.Categorie
{
    public class CategorieDeleteViewModel
    {
        
        [DisplayName("Catégorie")]
        [Required]
        public string NomCategorie { get; set; }
    }
}
