using Vinculo_Net.Dominio.Entidades.Projetos;

namespace Vinculo_Net.Dominio.Entidades.Investimentos;

public class Investimento
{
    public Guid InvestimentoId { get; set; }
    public Guid InvestidorId { get; set; }
    public Guid ProjetoId { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
    public Projeto? Projeto { get; set; }
}