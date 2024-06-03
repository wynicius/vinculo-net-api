using MediatR;
using Vinculo_Net_Api.Application.Commands.Ongs.Inserir;
using Vinculo_Net_Api.Domain.Entities.Ongs;
using Vinculo_Net_Api.Infrastructure.Repositories;

namespace Vinculo_Net_Api.Application.Functionalities.Handlers;

public class InserirOngComandoHandler : IRequestHandler<InserirOngComando, Guid>
{
    // private readonly IAppUnitOfWork _unitOfWork;

    // public InserirOngComandoHandler(IAppUnitOfWork unitOfWork)
    // {
    //     _unitOfWork = unitOfWork;
    // }

    public async Task<Guid> Handle(InserirOngComando request, CancellationToken cancellationToken)
    {
        // var ong = new Ong
        // {
        //     OngId = Guid.NewGuid(),
        //     Nome = request.Nome,
        //     CNPJ = request.CNPJ,
        //     Email = request.Email,
        //     Telefone = request.Telefone,
        //     Endereco = request.Endereco,
        //     Status = StatusOng.EmAnalise
        // };

        // await _unitOfWork.Ong.Adicionar(ong);
        // await _unitOfWork.SalvarAlteracoes();

        return Guid.NewGuid();
    }
}