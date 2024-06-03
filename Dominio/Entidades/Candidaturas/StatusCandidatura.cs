using System.ComponentModel;

namespace Vinculo_Net.Dominio.Entidades.Candidaturas;

public enum StatusCandidatura
{
    [Description("Em Análise")]
    EmAnalise,
    [Description("Aprovada")]
    Aprovada,
    [Description("Reprovada")]
    Reprovada
}