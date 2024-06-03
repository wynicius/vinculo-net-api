using Domain.Entities.Localizacoes;
using NET.Data.Base;
using Vinculo_Net_Api.Domain.Entities.Causas;
using Vinculo_Net_Api.Domain.Entities.Projetos;

namespace Vinculo_Net_Api.Domain.Entities.Ongs;

public class Ong : EntidadeBase
{
    public Guid OngId { get; set; }
    public Guid LocalizacaoId { get; set; }
    public StatusOng StatusOng { get; set; }
    public string? Nome { get; set; }
    public string? Cnpj { get; set; }
    public string? CaminhoFotoPerfil { get; set; }
    public DateTime DataFundacao { get; set; }
    public string? Missao { get; set; }
    public int Telefone { get; set; }
    public string? Email { get; set; }
    public string? Historico { get; set; }
    public string? Website { get; set; }
    public Localizacao? Localizacao { get; set; }
    public List<Projeto>? Projetos { get; set; }
    public List<Causa>? Causas { get; set; }
}