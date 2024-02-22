using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Repositories
{
    public interface ICategorieRepository<TEntity> : ICrudRepository<TEntity, int> where TEntity : class
    {
    }
}
