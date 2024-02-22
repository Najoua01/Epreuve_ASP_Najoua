using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Epreuve_Asp.Models.Categorie
{
    public class CategorieEditViewModel
    {
        

        [DisplayName("Catégorie")]
        [Required]
        public string NomCategorie { get; set; }
    }
}
