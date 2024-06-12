using MediatR;
using Vinculo_Net.Dominio.Entidades.Localizacoes;
using Vinculo_Net.Infraestrutura.Repositorios;

namespace Vinculo_Net.Aplicacao.Comandos.Localizacoes.Inserir;

public class InserirLocalizacaoComandoHandler(IAppUnitOfWork uow) : IRequestHandler<InserirLocalizacaoComando, Guid>
{
    private readonly IAppUnitOfWork _uow = uow;
    public async Task<Guid> Handle(InserirLocalizacaoComando request, CancellationToken cancellationToken)
    {
        Localizacao localizacao = new()
        {
            LocalizacaoId = Guid.NewGuid(),
            Rua = request.NovaLocalizacaoDto!.Rua,
            Numero = request.NovaLocalizacaoDto.Numero,
            Complemento = request.NovaLocalizacaoDto.Complemento,
            Cidade = request.NovaLocalizacaoDto.Cidade,
            Estado = request.NovaLocalizacaoDto.Estado,
            Pais = request.NovaLocalizacaoDto.Pais,
            Cep = request.NovaLocalizacaoDto.Cep,
        };

        await _uow.Localizacao.Adicionar(localizacao);

        return localizacao.LocalizacaoId;
    }
}