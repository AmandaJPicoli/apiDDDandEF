using RestApiModeloDDD.Domain.Core.Interface.Repository;
using RestApiModeloDDD.Domain.Core.Interface.Services;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto _repositoryProduto) : base(_repositoryProduto)
        {
            repositoryProduto = _repositoryProduto;
        }
    }
}
