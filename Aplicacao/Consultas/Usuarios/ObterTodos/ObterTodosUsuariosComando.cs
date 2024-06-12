using MediatR;

namespace Vinculo_Net.Aplicacao.Consultas.Usuarios.ObterTodos;

public class ObterTodosUsuariosComando : IRequest<IEnumerable<UsuariosListaDto>>
{
    public ObterTodosUsuariosComando()
    { }
}