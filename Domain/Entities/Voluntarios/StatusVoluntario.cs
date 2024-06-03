using System.ComponentModel;

namespace Vinculo_Net_Api.Domain.Entities.Voluntarios;

public enum StatusVoluntario
{
    [Description("Ativo")]
    Ativo,
    [Description("Inativo")]
    Inativo,
    [Description("Em Análise")]
    EmAnalise
}