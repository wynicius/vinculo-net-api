using Vinculo_Net_Api.Dominio.Entidades.Ongs;
using Vinculo_Net_Api.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net_Api.Infraestrutura.Repositorios.Ongs;

public class RepositorioLeituraOng(DominioContexto context) : RepositorioLeituraBase<Ong, DominioContexto>(context)
{ }