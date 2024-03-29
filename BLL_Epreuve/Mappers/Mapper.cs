﻿using System;
using System.Collections.Generic;
using System.Text;
using BLL = BLL_Epreuve.Entities;
using DAL = DAL_Epreuve.Entities;

namespace BLL_Epreuve.Mappers
{
    internal static class Mapper
    {
        #region Categorie
        public static BLL.Categorie ToBLL(this DAL.Categorie entity)
        {
            if (entity is null) return null;
            return new BLL.Categorie(
                entity.NomCategorie);
        }

        public static DAL.Categorie ToDAL(this BLL.Categorie entity)
        {
            if (entity is null) return null;
            return new DAL.Categorie()
            {
                NomCategorie = entity.NomCategorie
            };
        }
        #endregion

        #region Produit
        public static BLL.Produit ToBLL(this DAL.Produit entity)
        {
            if (entity is null) return null;
            return new BLL.Produit(
                entity.Id_Produit,
                entity.Nom,
                entity.Description,
                entity.Prix,
                entity.EcoScore,
                entity.NomCategorie);
        }

        public static DAL.Produit ToDAL(this BLL.Produit entity)
        {
            if (entity is null) return null;
            return new DAL.Produit()
            {
                Id_Produit = entity.Id_Produit,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
                NomCategorie= entity.NomCategorie
            };
        }
        #endregion

        #region Produit
        public static BLL.Media ToBLL(this DAL.Media entity)
        {
            if (entity is null) return null;
            return new BLL.Media(
                entity.Id_Media,
                entity.Nom,
                entity.Url,
                entity.Id_produit,
                null);
        }

        public static DAL.Media ToDAL(this BLL.Media entity)
        {
            if (entity is null) return null;
            return new DAL.Media()
            {
                Id_Media = entity.Id_Media,
                Nom = entity.Nom,
                Url = entity.Url,
                Id_produit = entity.Id_produit
            };
        }
        #endregion
    }
}
