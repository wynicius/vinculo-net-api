using NET.Data.Base;
using NET.Data.Repositorio;
using Vinculo_Net_Api.Domain.Entities.Ongs;
using Vinculo_Net_Api.Infrastructure.Context;

namespace Vinculo_Net_Api.Infrastructure.Repositories;

public class AppUnitOfWork(
    DomainContext context,
    RepositorioEscrita<Ong> ong
    ) : UnitOfWorkBase<DomainContext>(context), IAppUnitOfWork
{
    public RepositorioEscrita<Ong> Ong { get; set; } = ong;
}