using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class Media
    {

        public int Id_Media { get; private set; }
        public string Nom { get; private set; }
        public string Url { get; private set; }
        public int? Id_produit { get; private set; }
        public Produit Produit { get; private set; }
        
        public Media(int id_Media, string nom, string url, int? id_produit, Produit produit)
        {
            Id_Media = id_Media;
            Nom = nom;
            Url = url;
            Id_produit = id_produit;
            Produit = produit;
        }
    }
}
