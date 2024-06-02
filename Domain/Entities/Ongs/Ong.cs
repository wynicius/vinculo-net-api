using NET.Data.Base;
using Vinculo_Net_Api.Domain.Entities.Enums;

namespace Vinculo_Net_Api.Domain.Entities.Ongs;

public class Ong : EntidadeBase
{
    public Guid OngId { get; set; }
    public string? Nome { get; set; }
    public string? CpfCnpj { get; set; }
    public DateTime DataFundacao { get; set; }
    public string? Missao { get; set; }
    public int Telefone { get; set; }
    public string? Email { get; set; }
    public string? Historico { get; set; }
    public string? Website { get; set; }
    public StatusOng StatusOng { get; set; }
    
}