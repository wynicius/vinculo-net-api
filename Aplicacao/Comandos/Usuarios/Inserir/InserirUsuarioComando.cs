using MediatR;
using Vinculo_Net.Aplicacao.Comandos.Localizacoes.Inserir;

namespace Vinculo_Net.Aplicacao.Comandos.Usuarios.Inserir;

public class InserirUsuarioComando(NovoUsuarioDto NovoUsuarioDto, NovaLocalizacaoDto novaLocalizacaoDto) : IRequest<Guid>
{
    public NovoUsuarioDto? NovoUsuarioDto { get; set; } = NovoUsuarioDto;
    public NovaLocalizacaoDto? NovaLocalizacaoDto { get; set; } = novaLocalizacaoDto;
}