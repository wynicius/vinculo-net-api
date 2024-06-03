using System.ComponentModel;

namespace Vinculo_Net_Api.Dominio.Entidades.Voluntarios;

public enum StatusVoluntario
{
    [Description("Ativo")]
    Ativo,
    [Description("Inativo")]
    Inativo,
    [Description("Em Análise")]
    EmAnalise
}