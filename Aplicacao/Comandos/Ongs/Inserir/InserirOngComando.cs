using MediatR;

namespace Vinculo_Net.Aplicacao.Comandos.Ongs.Inserir;

public class InserirOngComando(NovaOngDto novaOngDto) : IRequest<Guid>
{
    public NovaOngDto? NovaOngDto { get; set; } = novaOngDto;
}