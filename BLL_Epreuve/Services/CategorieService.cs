using BLL_Epreuve.Entities;
using DAL = DAL_Epreuve.Entities;
using Shared.Repositories;
using BLL_Epreuve.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLL_Epreuve.Services
{
    public class CategorieService : ICategorieRepository<Categorie>
    {
        private readonly ICategorieRepository<DAL.Categorie> _repository;
        public CategorieService(ICategorieRepository<DAL.Categorie> repository)
        { 
            _repository = repository;
        }
        public void Delete(string id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Categorie> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }

        public Categorie Get(string id)
        {
            return _repository.Get(id).ToBLL();
        }

        public string Insert(Categorie entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public void Update(Categorie entity)
        {
            _repository.Update(entity.ToDAL());
        }
    }
}
