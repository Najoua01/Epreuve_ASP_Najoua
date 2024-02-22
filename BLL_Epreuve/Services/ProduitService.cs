using BLL_Epreuve.Entities;
using DAL = DAL_Epreuve.Entities;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BLL_Epreuve.Mappers;

namespace BLL_Epreuve.Services
{
    public class ProduitService : IProduitRepository<Produit>
    {
        private readonly IProduitRepository<DAL.Produit> _repository;
        public ProduitService(IProduitRepository<DAL.Produit> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Produit> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());

        }
        public Produit Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public IEnumerable<Produit> GetByCategorie(string categorie)
        {
            IEnumerable<DAL.Produit> dalProduit = _repository.GetByCategorie(categorie);
            IEnumerable<Produit> bllProduit = dalProduit.Select(dalProduit => dalProduit.ToBLL());
            return bllProduit;
        }

        public IEnumerable<Produit> GetRandomProduit(int count)
        {
            return _repository.GetRandomProduit(count).Select(d => d.ToBLL());    
        }

        public int Insert(Produit entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public void Update(Produit entity)
        {
            _repository.Update(entity.ToDAL());
        }
    }
}
