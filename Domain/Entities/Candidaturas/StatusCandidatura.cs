using System.ComponentModel;

namespace Vinculo_Net_Api.Domain.Entities.Candidaturas;

public enum StatusCandidatura
{
    [Description("Em Análise")]
    EmAnalise,
    [Description("Aprovada")]
    Aprovada,
    [Description("Reprovada")]
    Reprovada
}