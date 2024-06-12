using NET.Data.Base;
using Vinculo_Net.Dominio.Entidades.Voluntarios;

namespace Vinculo_Net.Dominio.Entidades.Candidaturas;

public class Candidatura : EntidadeBase
{
    public Guid CandidaturaId { get; set; }
    public Guid VoluntarioId { get; set; }
    public Guid ProjetoId { get; set; }
    public DateTime Data { get; set; }
    public StatusCandidatura Status { get; set; }
}