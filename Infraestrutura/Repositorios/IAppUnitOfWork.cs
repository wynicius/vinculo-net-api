using NET.Data.Interfaces;
using Vinculo_Net.Dominio.Entidades.Candidaturas;
using Vinculo_Net.Dominio.Entidades.Causas;
using Vinculo_Net.Dominio.Entidades.Habilidades;
using Vinculo_Net.Dominio.Entidades.Investidores;
using Vinculo_Net.Dominio.Entidades.Investimentos;
using Vinculo_Net.Dominio.Entidades.Localizacoes;
using Vinculo_Net.Dominio.Entidades.Ongs;
using Vinculo_Net.Dominio.Entidades.Projetos;
using Vinculo_Net.Dominio.Entidades.Usuarios;
using Vinculo_Net.Dominio.Entidades.Voluntarios;

namespace Vinculo_Net.Infraestrutura.Repositorios;

public interface IAppUnitOfWork : IUnitOfWork
{
    public IRepositorioEscrita<Usuario> Usuario { get; }
    public IRepositorioEscrita<Ong> Ong { get; }
    public IRepositorioEscrita<Voluntario> Voluntario { get; }
    public IRepositorioEscrita<Investidor> Investidor { get; }
    public IRepositorioEscrita<Localizacao> Localizacao { get; }
    public IRepositorioEscrita<Causa> Causa { get; }
    public IRepositorioEscrita<Projeto> Projeto { get; }
    public IRepositorioEscrita<Habilidade> Habilidade { get; }
    public IRepositorioEscrita<Candidatura> Candidatura { get; }
    public IRepositorioEscrita<Investimento> Investimento { get; }
}