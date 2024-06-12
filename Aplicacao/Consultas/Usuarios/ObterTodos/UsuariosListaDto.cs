using AutoMapper;
using Vinculo_Net.Dominio.Entidades.Localizacoes;
using Vinculo_Net.Dominio.Entidades.Usuarios;

namespace Vinculo_Net.Aplicacao.Consultas.Usuarios.ObterTodos;

[AutoMap(typeof(Usuario), ReverseMap = true)]
public class UsuariosListaDto
{
    public Guid UsuarioId { get; set; }
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