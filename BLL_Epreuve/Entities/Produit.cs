using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class Produit
    {
        public int Id_Produit { get; private set; }
        public string Nom { get; private set; }
        public string? Description { get;private set; }
        public decimal Prix { get; private set; }
        public char EcoScore { get; private set; }
        public string NomCategorie { get; private set; }
        
        public Produit(int id_Produit, string nom, string? description, decimal prix, char ecoScore, string NomCategorie)
        {
            Id_Produit = id_Produit;
            Nom = nom;
            Description = description;
            Prix = prix;
            EcoScore = ecoScore;
            this.NomCategorie = NomCategorie;
        }

    }
}
