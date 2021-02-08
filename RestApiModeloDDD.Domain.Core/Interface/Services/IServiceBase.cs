using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Core.Interface.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
