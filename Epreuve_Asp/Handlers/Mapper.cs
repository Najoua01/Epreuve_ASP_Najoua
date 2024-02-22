﻿using BLL_Epreuve.Entities;
using Epreuve_Asp.Models.Categorie;
using Epreuve_Asp.Models.Produit;

namespace Epreuve_Asp.Handlers
{
    public static class Mapper
    {
        #region Categorie
        public static CategorieListItemViewModel ToListItem(this Categorie entity)
        {
            if (entity is null) return null;
            return new CategorieListItemViewModel()
            {
                NomCategorie = entity.NomCategorie
            };
        }
        public static CategorieDeleteViewModel Delete(this Categorie entity)
        {
            if (entity is null) return null;
            return new CategorieDeleteViewModel()
            {
                NomCategorie = entity.NomCategorie
            };
        }
        public static CategorieEditViewModel Edit(this Categorie entity)
        {
            if (entity is null) return null;
            return new CategorieEditViewModel()
            {
                NomCategorie = entity.NomCategorie
            };
        }
        //public static Categorie ToBLL(this CategorieCreateViewModel entity)
        //{
        //    if (entity is null) return null;
        //    return new CategorieCreateViewModel(
        //        entity.NomCategorie
        //    );
        //}

        #endregion

        #region Produit
        public static ProduitListItemViewModel ToListItem(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitListItemViewModel()
            {
                Id_Produit = entity.Id_Produit,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
                NomCategorie = entity.NomCategorie
            };
        }
        public static ProduitDetailsViewModel ToDetails(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDetailsViewModel()
            {
                Id_Produit = entity.Id_Produit,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
                NomCategorie = entity.NomCategorie
            };
        }
        public static ProduitEditViewModel Edit(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitEditViewModel()
            {
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
                NomCategorie = entity.NomCategorie
            };
        }
        public static ProduitDeleteViewModel Delete(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDeleteViewModel()
            {
                Id_Produit = entity.Id_Produit,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
                NomCategorie = entity.NomCategorie
            };
        }
        #endregion

    }
}
