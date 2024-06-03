using System.ComponentModel;

namespace Vinculo_Net.Dominio.Entidades.Investidores;

public enum StatusInvestidor
{
    [Description("Em Análise")]
    EmAnalise,
    [Description("Ativo")]
    Ativo,
    [Description("Inativo")]
    Inativo,
}