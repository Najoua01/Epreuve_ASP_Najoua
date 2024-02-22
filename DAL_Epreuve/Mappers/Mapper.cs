using DAL_Epreuve.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL_Epreuve.Mappers
{
    internal static class Mapper
    {
        public static Categorie ToCategorie(this IDataRecord record)
        {
            if (record is null) return null;
            return new Categorie()
            {
                NomCategorie = (string)record["NomCategorie"],
            };
        }
        public static Produit ToProduit(this IDataRecord record)
        {
            if (record is null) return null;
            return new Produit()
            {
                Id_Produit = (int)record["Id_Produit"],
                Nom = (string)record["Nom"],
                Description = (string)record["Description"],
                Prix = (decimal)record["Prix"],
                EcoScore = record["EcoScore"].ToString()[0],
                NomCategorie = (string)record["NomCategorie"]
            };
        }
    }
}
