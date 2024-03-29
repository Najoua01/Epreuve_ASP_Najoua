﻿using DAL_Epreuve.Entities;
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
                Description = (record["Description"] == DBNull.Value) ? null : (string?)record["Description"],
                Prix = (decimal)record["Prix"],
                EcoScore = record["EcoScore"].ToString()[0],
                NomCategorie = (string)record["NomCategorie"]
            };
        }
        public static Media ToMedia(this IDataRecord record)
        {
            if (record is null) return null;
            return new Media()
            {
                Id_Media = (int)record["Id_Media"],
                Nom = (string)record["Nom"],
                Url = record["Url"].ToString(),
                Id_produit = (record["Id_Produit"] == DBNull.Value) ? null : (int?)record["Id_Produit"]
               
            };
        }
    }
}
