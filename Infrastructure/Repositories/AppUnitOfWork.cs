using NET.Data.Base;
using NET.Data.Interfaces;
using Vinculo_Net_Api.Domain.Entities.Ongs;
using Vinculo_Net_Api.Infrastructure.Context;

namespace Vinculo_Net_Api.Infrastructure.Repositories;

public class AppUnitOfWork(DomainContext context, 
    IRepositorioEscrita<Ong> ong
    
) : UnitOfWorkBase<DomainContext>(context), IAppUnitOfWork
{
    public IRepositorioEscrita<Ong> Ong { get; set; } = ong;
}