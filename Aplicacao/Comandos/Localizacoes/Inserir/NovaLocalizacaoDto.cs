namespace Vinculo_Net.Aplicacao.Comandos.Localizacoes.Inserir;

public class NovaLocalizacaoDto
{
    public string? Rua { get; set; }
    public int Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public string? Pais { get; set; }
    public string? Cep { get; set; }
}