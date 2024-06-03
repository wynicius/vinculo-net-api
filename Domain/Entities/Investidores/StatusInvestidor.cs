using System.ComponentModel;

namespace Vinculo_Net_Api.Domain.Entities.Investidores;

public enum StatusInvestidor
{
    [Description("Ativo")]
    Ativo,
    [Description("Inativo")]
    Inativo,
    [Description("Em Análise")]
    EmAnalise
}