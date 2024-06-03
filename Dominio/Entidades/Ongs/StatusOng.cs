using System.ComponentModel;

namespace Vinculo_Net.Dominio.Entidades.Ongs;

public enum StatusOng
{
    [Description("Em Análise")]
    EmAnalise,
    [Description("Ativa")]
    Ativa,
    [Description("Inativa")]
    Inativa,
}