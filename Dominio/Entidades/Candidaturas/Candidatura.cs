using Vinculo_Net_Api.Dominio.Entidades.Voluntarios;

namespace Vinculo_Net_Api.Dominio.Entidades.Candidaturas;

public class Candidatura
{
    public Guid CandidaturaId { get; set; }
    public Guid VoluntarioId { get; set; }
    public Guid OngId { get; set; }
    public StatusCandidatura Status { get; set; }
}