using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Mappers.Interfaces;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            Produto produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };
            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            ProdutoDto produtoDto = new ProdutoDto()
            {
                Valor = produto.Valor,
                Nome = produto.Nome,
                Id = produto.Id
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            return produtos.Select(produto => MapperEntityToDto(produto));
        }
    }
}