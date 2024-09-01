using NET.Data.Base;
using Vinculo_Net.Dominio.Entidades.Candidaturas;
using Vinculo_Net.Dominio.Entidades.Causas;
using Vinculo_Net.Dominio.Entidades.Investimentos;
using Vinculo_Net.Dominio.Entidades.Voluntarios;

namespace Vinculo_Net.Dominio.Entidades.Projetos;

public class Projeto : EntidadeBase
{
    public Guid ProjetoId { get; set; }
    public Guid OngId { get; set; }
    public StatusProjeto StatusProjeto { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public string? Objetivos { get; set; }
    public string? Metas { get; set; }
    public int Orcamento { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
    public Causa? Causa { get; set; }
    public List<Voluntario>? Voluntarios { get; set; }
    public List<Investimento>? Investimentos { get; set; }
    public List<Candidatura> Candidaturas { get; set; }
}