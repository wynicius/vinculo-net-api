using MediatR;

namespace Vinculo_Net_Api.Application.Commands.Ongs.Inserir;

public class InserirOngComando(NovaOngDto novaOngDto) : IRequest<Guid>
{
    public NovaOngDto? NovaOngDto { get; set; } = novaOngDto;
}