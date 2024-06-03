using System.ComponentModel;

namespace Vinculo_Net.Dominio.Entidades.Voluntarios;

public enum StatusVoluntario
{
    [Description("Em Análise")]
    EmAnalise,
    [Description("Ativo")]
    Ativo,
    [Description("Inativo")]
    Inativo,
}