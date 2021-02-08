using RestApiModeloDDD.Domain.Core.Interface.Repository;
using RestApiModeloDDD.Domain.Core.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> _repository)
        {
            repository = _repository;
        }

        public void Add(TEntity obj)
        {
            repository.Add(obj);
        }

        public void Delete(TEntity obj)
        {
            repository.Delete(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Update(TEntity obj)
        {
            repository.Update(obj);
        }
    }
}
