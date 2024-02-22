using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Epreuve_Asp.Models.Categorie
{
    public class CategorieCreateViewModel
    {
        [DisplayName("Catégorie")]
        [Required(ErrorMessage = "Le nom de la catégorie est obligatoire.")]
        [MinLength(2, ErrorMessage = "Le nom doit avoir au minimum 2 caractères.")]
        public string NomCategorie { get; set; }
    }
}
