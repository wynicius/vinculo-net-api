using AutoMapper;
using MediatR;
using NET.Data.Interfaces;
using NET.Data.Query;
using Vinculo_Net.Dominio.Entidades.Usuarios;

namespace Vinculo_Net.Aplicacao.Consultas.Usuarios.ObterTodos;

public class ObterTodosUsuariosComandoHandler(IMapper mapper, IRepositorioLeitura<Usuario> repositorioLeituraUsuario) 
    : IRequestHandler<ObterTodosUsuariosComando, IEnumerable<UsuariosListaDto>>
{
    private readonly IMapper _mapper = mapper;
    private readonly IRepositorioLeitura<Usuario> _usuarioRepositorioLeitura = repositorioLeituraUsuario;

    public async Task<IEnumerable<UsuariosListaDto>> Handle(ObterTodosUsuariosComando request, CancellationToken cancellationToken)
    {
        var usuarios = await _usuarioRepositorioLeitura.ObterTodos(x => true, 
            new () { OrderBy = p => p.DataAtualizacao, Order = QueryOrder.Desc }, 
                ["Localizacao"]);
        
        return _mapper.Map<IEnumerable<UsuariosListaDto>>(usuarios);
    }
}