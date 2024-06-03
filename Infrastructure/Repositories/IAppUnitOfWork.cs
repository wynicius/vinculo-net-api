using NET.Data.Interfaces;
using Vinculo_Net_Api.Domain.Entities.Ongs;

namespace Vinculo_Net_Api.Infrastructure.Repositories;

public interface IAppUnitOfWork : IUnitOfWork
{
    public IRepositorioEscrita<Ong> Ong { get; }
}