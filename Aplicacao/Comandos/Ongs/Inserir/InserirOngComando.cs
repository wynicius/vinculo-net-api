using MediatR;

namespace Vinculo_Net_Api.Aplicacao.Comandos.Ongs.Inserir;

public class InserirOngComando(NovaOngDto novaOngDto) : IRequest<Guid>
{
    public NovaOngDto? NovaOngDto { get; set; } = novaOngDto;
}