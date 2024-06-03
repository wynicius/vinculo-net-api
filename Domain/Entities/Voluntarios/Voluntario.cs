using Domain.Entities.Localizacoes;
using NET.Data.Base;
using Vinculo_Net_Api.Domain.Entities.Causas;
using Vinculo_Net_Api.Domain.Entities.Habilidades;
using Vinculo_Net_Api.Domain.Entities.Ongs;
using Vinculo_Net_Api.Domain.Entities.Projetos;
using Vinculo_Net_Api.Domain.Entities.Usuarios;

namespace Vinculo_Net_Api.Domain.Entities.Voluntarios;

public class Voluntario : EntidadeBase
{
    public Guid VoluntarioId { get; set; }
    public Guid UsuarioId { get; set; }
    public StatusVoluntario Status { get; set; }
    public string? CaminhoFotoPerfil { get; set; }
    public string? Descricao { get; set; }
    public string? Experiencia { get; set; }
    public string? Formacao { get; set; }
    public string? Disponibilidade { get; set; }
    public Habilidade? Habilidades { get; set; }
    public Usuario? Usuario { get; set; }
    public Localizacao? Localizacao { get; set; }
    public List<Projeto>? Projetos { get; set; }
    public List<Causa>? Causas { get; set; }
    public List<Ong>? Ongs { get; set; }
}