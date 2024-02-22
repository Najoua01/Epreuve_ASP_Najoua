using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class Categorie
    {
        public string NomCategorie { get; private set; }
        
        public Categorie(string nomCategorie)
        {
            NomCategorie = nomCategorie;
        }

    }
}
