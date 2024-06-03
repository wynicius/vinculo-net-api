using NET.Data.Interfaces;
using Vinculo_Net.Dominio.Entidades.Ongs;

namespace Vinculo_Net.Infraestrutura.Repositorios;

public interface IAppUnitOfWork : IUnitOfWork
{
    public IRepositorioEscrita<Ong> Ong { get; }
}