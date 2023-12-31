﻿using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }
    }
}