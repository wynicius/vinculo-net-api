using NET.Data.Base;

namespace Vinculo_Net_Api.Domain.Entities.Causas;

public class Causa : EntidadeBase
{
    public Guid CausaId { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
}