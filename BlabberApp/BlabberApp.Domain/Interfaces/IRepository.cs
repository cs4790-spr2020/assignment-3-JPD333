using BlabberApp.Domain.Entities;
using System.Collections.Generic;

namespace BlabberApp.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        T GetBySysId(string sysId);
        T GetByUserId(string userId);
    }
}
