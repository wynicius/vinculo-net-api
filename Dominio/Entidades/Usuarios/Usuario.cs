using NET.Data.Base;
using Vinculo_Net.Dominio.Entidades.Localizacoes;

namespace Vinculo_Net.Dominio.Entidades.Usuarios;

public class Usuario : EntidadeBase
{
    public Guid UsuarioId { get; set; }
    public Guid LocalizacaoId { get; set; }
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string? NomeCompleto { get; set; }
    public DateTime DataNascimento { get; set; }
    public string? Cpf { get; set; }
    public char? Genero { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public Localizacao? Localizacao { get; set; }
}