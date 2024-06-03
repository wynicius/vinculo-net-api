using NET.Data.Base;
using NET.Data.Interfaces;
using Vinculo_Net_Api.Dominio.Entidades.Ongs;
using Vinculo_Net_Api.Infraestrutura.Contexto;

namespace Vinculo_Net_Api.Infraestrutura.Repositorios;

public class AppUnitOfWork(DominioContexto context, 
    IRepositorioEscrita<Ong> ong
    
) : UnitOfWorkBase<DominioContexto>(context), IAppUnitOfWork
{
    public IRepositorioEscrita<Ong> Ong { get; set; } = ong;
}