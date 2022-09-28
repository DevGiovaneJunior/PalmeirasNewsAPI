using System.Collections.Generic;

namespace PalmeirasNews.Domain.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        public void Add(TEntity obj);
        public TEntity GetById(int id);
        public IEnumerable<TEntity> GetAll();
        public void Update(TEntity obj);
        public void Remove(TEntity obj);
        public void Dispose();
    }
}
