using System.ComponentModel;

namespace Vinculo_Net_Api.Dominio.Entidades.Investidores;

public enum TipoInvestidor
{
    [Description("Pessoa Física")]
    PessoaFisica,
    [Description("Pessoa Jurídica")]
    PessoaJuridica
}