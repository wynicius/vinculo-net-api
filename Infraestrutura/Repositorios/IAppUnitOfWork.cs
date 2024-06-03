using NET.Data.Interfaces;
using Vinculo_Net_Api.Dominio.Entidades.Ongs;

namespace Vinculo_Net_Api.Infraestrutura.Repositorios;

public interface IAppUnitOfWork : IUnitOfWork
{
    public IRepositorioEscrita<Ong> Ong { get; }
}