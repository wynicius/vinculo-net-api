using Vinculo_Net.Dominio.Entidades.Candidaturas;
using Vinculo_Net.Dominio.Entidades.Causas;
using Vinculo_Net.Dominio.Entidades.Habilidades;
using Vinculo_Net.Dominio.Entidades.Localizacoes;
using Vinculo_Net.Dominio.Entidades.Ongs;
using Vinculo_Net.Dominio.Entidades.Projetos;
using Vinculo_Net.Dominio.Entidades.Usuarios;

namespace Vinculo_Net.Dominio.Entidades.Voluntarios;

public class Voluntario : EntidadeBase
{
    public Guid VoluntarioId { get; set; }
    public Guid UsuarioId { get; set; }
    public StatusVoluntario Status { get; set; }
    public string? Descricao { get; set; }
    public string? Experiencia { get; set; }
    public string? Formacao { get; set; }
    public string? Disponibilidade { get; set; }
    public Habilidade? Habilidades { get; set; }
    public Usuario? Usuario { get; set; }
    public Localizacao? Localizacao { get; set; }
    public List<Projeto>? Projetos { get; set; }
    public List<Causa>? Causas { get; set; }
    public List<Candidatura>? Candidaturas { get; set; }
}