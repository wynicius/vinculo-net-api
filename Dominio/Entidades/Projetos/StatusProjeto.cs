using System.ComponentModel;

namespace Vinculo_Net.Dominio.Entidades.Projetos;

public enum StatusProjeto
{
    [Description("Em Análise")]
    EmAnalise,
    [Description("Ativo")]
    Ativo,
    [Description("Inativo")]
    Inativo,
}