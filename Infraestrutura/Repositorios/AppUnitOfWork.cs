using NET.Data.Base;
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
using Vinculo_Net.Infraestrutura.Contexto;
using Vinculo_Net.Infraestrutura.Repositorios;

namespace GESTAO360.Convenios.Infraestrutura.Repositorios;

public class AppUnitOfWork(
        DominioContexto context,
        IRepositorioEscrita<Usuario> usuario,
        IRepositorioEscrita<Ong> ongs,
        IRepositorioEscrita<Voluntario> voluntario,
        IRepositorioEscrita<Investidor> investidor,
        IRepositorioEscrita<Localizacao> localizacao,
        IRepositorioEscrita<Causa> causa,
        IRepositorioEscrita<Projeto> projeto,
        IRepositorioEscrita<Habilidade> habilidade,
        IRepositorioEscrita<Candidatura> candidatura,
        IRepositorioEscrita<Investimento> investimento

    ) : UnitOfWorkBase<DominioContexto>(context), IAppUnitOfWork
{
    public IRepositorioEscrita<Usuario> Usuario { get; set; } = usuario;
    public IRepositorioEscrita<Ong> Ong { get; set; } = ongs;
    public IRepositorioEscrita<Investidor> Investidor { get; set; } = investidor;
    public IRepositorioEscrita<Localizacao> Localizacao { get; set; } = localizacao;
    public IRepositorioEscrita<Causa> Causa { get; set; } = causa;
    public IRepositorioEscrita<Projeto> Projeto { get; set; } = projeto;
    public IRepositorioEscrita<Habilidade> Habilidade { get; set; } = habilidade;
    public IRepositorioEscrita<Candidatura> Candidatura { get; set; } = candidatura;
    public IRepositorioEscrita<Investimento> Investimento { get; set; } = investimento;
    public IRepositorioEscrita<Voluntario> Voluntario { get; set;} = voluntario;
}