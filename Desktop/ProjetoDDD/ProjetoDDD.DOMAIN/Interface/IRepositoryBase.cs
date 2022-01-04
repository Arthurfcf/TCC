

using System.Collections.Generic;

namespace ProjetoDDD.DOMAIN.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

       

        void Remove(TEntity obj);

      

    }
}
