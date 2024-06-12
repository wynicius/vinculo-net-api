namespace Vinculo_Net.Aplicacao.Comandos.Usuarios.Inserir;

public class NovoUsuarioDto
{
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string? NomeCompleto { get; set; }
    public DateTime DataNascimento { get; set; }
    public string? Cpf { get; set; }
    public char? Genero { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}