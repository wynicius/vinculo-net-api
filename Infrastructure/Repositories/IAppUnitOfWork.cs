using NET.Data.Repositorio;
using Vinculo_Net_Api.Domain.Entities.Ongs;

namespace Vinculo_Net_Api.Infrastructure.Repositories;

public interface IAppUnitOfWork : UnitOfWork
{
    public RepositorioEscrita<Ong> Ong { get; }
}