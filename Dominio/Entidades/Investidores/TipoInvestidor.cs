using System.ComponentModel;

namespace Vinculo_Net.Dominio.Entidades.Investidores;

public enum TipoInvestidor
{
    [Description("Pessoa Física")]
    PessoaFisica,
    [Description("Pessoa Jurídica")]
    PessoaJuridica
}