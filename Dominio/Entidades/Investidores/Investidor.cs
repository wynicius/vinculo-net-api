using Dominio.Entidades.Localizacoes;
using NET.Data.Base;
using Vinculo_Net_Api.Dominio.Entidades.Causas;
using Vinculo_Net_Api.Dominio.Entidades.Usuarios;

namespace Vinculo_Net_Api.Dominio.Entidades.Investidores;

public class Investidor : EntidadeBase
{
    public Guid InvestidorId { get; set; }
    public Guid UsuarioId { get; set; }
    public Guid LocalizacaoId { get; set; }
    public TipoInvestidor TipoInvestidor { get; set; }
    public StatusInvestidor Status { get; set; }
    public string? NomeFantasia { get; set; }
    public string? RazaoSocial { get; set; }
    public string? CaminhoFotoPerfil { get; set; }
    public string? Email { get; set; }
    public string? Descricao { get; set; }
    public string? Cnpj { get; set; }
    public Usuario? Usuario { get; set; }
    public Localizacao? Localizacao { get; set; }
    public List<Causa>? Causas { get; set; }
}