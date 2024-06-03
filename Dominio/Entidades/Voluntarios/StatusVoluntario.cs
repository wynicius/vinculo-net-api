using System.ComponentModel;

namespace Vinculo_Net.Dominio.Entidades.Voluntarios;

public enum StatusVoluntario
{
    [Description("Ativo")]
    Ativo,
    [Description("Inativo")]
    Inativo,
    [Description("Em Análise")]
    EmAnalise
}