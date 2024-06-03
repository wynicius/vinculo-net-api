using Domain.Entities.Localizacoes;
using NET.Data.Base;

namespace Vinculo_Net_Api.Domain.Entities.Usuarios;

public class Usuario : EntidadeBase
{
    public Guid UsuarioId { get; set; }
    public Guid LocalizacaoId { get; set; }
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string? NomeCompleto { get; set; }
    public string? CaminhoFotoPerfil { get; set; }
    public DateTime DataNascimento { get; set; }
    public string? Cpf { get; set; }
    public string? Gênero { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public Localizacao? Localizacao { get; set; }
}