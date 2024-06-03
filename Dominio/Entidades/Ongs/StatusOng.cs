using System.ComponentModel;

namespace Vinculo_Net_Api.Dominio.Entidades.Ongs;

public enum StatusOng
{
    [Description("Ativa")]
    Ativa = 1,
    [Description("Inativa")]
    Inativa = 2,
    [Description("Em Análise")]
    EmAnalise = 3
}