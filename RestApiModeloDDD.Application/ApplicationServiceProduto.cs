﻿using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Mappers.Interfaces;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapperProduto _mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            _serviceProduto = serviceProduto;
            _mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);

            _serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var ProdutosDto = _serviceProduto.GetAll();

            return _mapperProduto.MapperListProdutosDto(ProdutosDto);
        }

        public ProdutoDto GetById(int id)
        {
            var produto = _serviceProduto.GetById(id);
            return _mapperProduto.MapperEntityToDto(produto);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Update(produto);
        }
    }
}