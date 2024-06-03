using Vinculo_Net_Api.Domain.Entities.Voluntarios;

namespace Vinculo_Net_Api.Domain.Entities.Candidaturas;

public class Candidatura
{
    public Guid CandidaturaId { get; set; }
    public Guid VoluntarioId { get; set; }
    public Guid OngId { get; set; }
    public StatusCandidatura Status { get; set; }
}