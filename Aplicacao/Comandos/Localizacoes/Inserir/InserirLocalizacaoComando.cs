using MediatR;

namespace Vinculo_Net.Aplicacao.Comandos.Localizacoes.Inserir;

public class InserirLocalizacaoComando(NovaLocalizacaoDto novaLocalizacaoDto) : IRequest<Guid>
{
    public NovaLocalizacaoDto? NovaLocalizacaoDto { get; set; } = novaLocalizacaoDto;
}