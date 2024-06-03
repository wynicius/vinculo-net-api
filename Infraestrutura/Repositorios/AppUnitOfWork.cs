using NET.Data.Base;
using NET.Data.Interfaces;
using Vinculo_Net.Dominio.Entidades.Ongs;
using Vinculo_Net.Infraestrutura.Contexto;
using Vinculo_Net.Infraestrutura.Repositorios;

namespace GESTAO360.Convenios.Infraestrutura.Repositorios;

public class AppUnitOfWork(
        DominioContexto context,
        IRepositorioEscrita<Ong> ongs
    ) : UnitOfWorkBase<DominioContexto>(context), IAppUnitOfWork
{
    public IRepositorioEscrita<Ong> Ong { get; set; } = ongs;
}