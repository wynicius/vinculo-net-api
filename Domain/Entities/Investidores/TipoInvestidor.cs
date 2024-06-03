using System.ComponentModel;

namespace Vinculo_Net_Api.Domain.Entities.Investidores;

public enum TipoInvestidor
{
    [Description("Pessoa Física")]
    PessoaFisica,
    [Description("Pessoa Jurídica")]
    PessoaJuridica
}