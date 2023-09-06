using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Mappers.Interfaces;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            Cliente cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.Sobrenome,
                Email = clienteDto.Email,
                IsAtivo = true
            };
            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            ClienteDto clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Email = cliente.Email,
                Sobrenome = cliente.Sobrenome,
                Nome = cliente.Nome
            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            return clientes.Select(cliente => MapperEntityToDto(cliente));
        }
    }
}