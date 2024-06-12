using MediatR;
using Vinculo_Net.Aplicacao.Comandos.Localizacoes.Inserir;
using Vinculo_Net.Dominio.Entidades.Usuarios;
using Vinculo_Net.Infraestrutura.Repositorios;

namespace Vinculo_Net.Aplicacao.Comandos.Usuarios.Inserir;

public class InserirUsuarioComandoHandler(IAppUnitOfWork uow, IMediator mediator) : IRequestHandler<InserirUsuarioComando, Guid>
{
    private readonly IAppUnitOfWork _uow = uow;
    private readonly IMediator _mediator = mediator;

    public async Task<Guid> Handle(InserirUsuarioComando request, CancellationToken cancellationToken)
    {
        Usuario usuario = new()
        {
            UsuarioId = Guid.NewGuid(),
            LocalizacaoId = await _mediator.Send(new InserirLocalizacaoComando(request.NovaLocalizacaoDto!), cancellationToken),
            Nome = request.NovoUsuarioDto!.Nome,
            Sobrenome = request.NovoUsuarioDto.Sobrenome,
            NomeCompleto = request.NovoUsuarioDto.NomeCompleto,
            DataNascimento = request.NovoUsuarioDto.DataNascimento,
            Cpf = request.NovoUsuarioDto.Cpf,
            Genero = request.NovoUsuarioDto.Genero,
            Email = request.NovoUsuarioDto.Email,
            Telefone = request.NovoUsuarioDto.Telefone,
        };

        await _uow.Usuario.Adicionar(usuario);
        await _uow.SalvarAlteracoes();

        return Guid.NewGuid();
    }
}