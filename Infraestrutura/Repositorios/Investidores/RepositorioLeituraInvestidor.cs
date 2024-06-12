using Vinculo_Net.Dominio.Entidades.Investidores;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Investidors;

public class RepositorioLeituraInvestidor(DominioContexto context) : RepositorioLeituraBase<Investidor, DominioContexto>(context)
{ }