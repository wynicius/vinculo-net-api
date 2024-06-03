using System.ComponentModel;

namespace Vinculo_Net_Api.Dominio.Entidades.Candidaturas;

public enum StatusCandidatura
{
    [Description("Em Análise")]
    EmAnalise,
    [Description("Aprovada")]
    Aprovada,
    [Description("Reprovada")]
    Reprovada
}