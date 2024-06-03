using System.ComponentModel;

namespace Vinculo_Net.Dominio.Entidades.Projetos;

public enum StatusProjeto
{
    [Description("Ativo")]
    Ativo = 1,
    [Description("Inativo")]
    Inativo = 2,
    [Description("Em Análise")]
    EmAnalise = 3
}