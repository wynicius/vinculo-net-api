using NET.Data.Base;

namespace Vinculo_Net.Dominio.Entidades.Habilidades;

public class Habilidade : EntidadeBase
{
    public Guid HabilidadeId { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
}