using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve.Entities
{
    public class Produit
    {
        public int Id_Produit { get; set; }
        public string Nom { get; set; }
        public string? Description { get; set; }
        public decimal Prix { get; set; }
        public char EcoScore { get; set; }
        public string NomCategorie { get; set; }
    }
}
