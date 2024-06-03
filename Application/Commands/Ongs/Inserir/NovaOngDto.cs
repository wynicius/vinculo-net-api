using AutoMapper.Configuration.Annotations;

namespace Vinculo_Net_Api.Application.Commands.Ongs.Inserir;

public class NovaOngDto
{
    public string? Nome { get; set; }
    public string? CNPJ { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string? Endereco { get; set; }
}