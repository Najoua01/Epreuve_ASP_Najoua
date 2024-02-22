using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Repositories
{
    
    public interface IProduitRepository<TEntity> : ICrudRepository<TEntity, int> where TEntity: class
    {
        IEnumerable<TEntity> GetByCategorie(string categorie);
    }
}
