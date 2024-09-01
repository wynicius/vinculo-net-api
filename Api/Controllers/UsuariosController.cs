using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET.Controllers.Controllers;
using Vinculo_Net.Aplicacao.Comandos.Localizacoes.Inserir;
using Vinculo_Net.Aplicacao.Comandos.Usuarios.Inserir;
using Vinculo_Net.Aplicacao.Consultas.Usuarios.ObterTodos;

namespace Api.Controllers;

[ApiController]
[Route("api/usuarios")]
public class UsuariosController(IMediator mediator) : BaseController
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    public async Task<IActionResult> Inserir([FromBody] InserirUsuarioEvento evento)
    {
        return Retorno(await _mediator.Send(new InserirUsuarioComando(evento.NovoUsuarioDto!, evento.NovaLocalizacaoDto!)));
    }

    [HttpGet]
    public async Task<IActionResult> ObterTodos()
    {
        return Retorno(await _mediator.Send(new ObterTodosUsuariosComando()));
    }
}