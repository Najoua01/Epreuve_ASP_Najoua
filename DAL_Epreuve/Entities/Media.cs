using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve.Entities
{
    public class Media
    {
        public int Id_Media { get; set; }
        public string Nom { get; set; }
        public string Url { get; set; }
        public int? Id_produit { get; set; }
        public Produit Produit { get; set; }
    }
}
