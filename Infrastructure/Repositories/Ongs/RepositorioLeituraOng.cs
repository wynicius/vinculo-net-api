using Vinculo_Net_Api.Domain.Entities.Ongs;
using Vinculo_Net_Api.Infrastructure.Context;
using NET.Data.Base;

namespace Vinculo_Net_Api.Infrastructure.Repositories.Ongs;

public class RepositorioLeituraOng(DomainContext context) : RepositorioLeituraBase<Ong, DomainContext>(context)
{ }