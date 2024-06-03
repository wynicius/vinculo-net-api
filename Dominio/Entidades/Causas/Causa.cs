using NET.Data.Base;

namespace Vinculo_Net_Api.Dominio.Entidades.Causas;

public class Causa : EntidadeBase
{
    public Guid CausaId { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
}