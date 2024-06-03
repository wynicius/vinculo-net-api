using System.ComponentModel;

namespace Vinculo_Net.Dominio.Entidades.Investidores;

public enum TipoInvestidor
{
    [Description("Pessoa Física")]
    PF,
    [Description("Pessoa Jurídica")]
    PJ
}