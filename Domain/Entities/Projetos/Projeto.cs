using NET.Data.Base;
using Vinculo_Net_Api.Domain.Entities.Causas;

namespace Vinculo_Net_Api.Domain.Entities.Projetos;

public class Projeto : EntidadeBase
{
    public Guid ProjetoId { get; set; }
    public Guid OngId { get; set; }
    public StatusProjeto StatusProjeto { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public string? Objetivos { get; set; }
    public int Orcamento { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
    public Causa? Causa { get; set; }
}