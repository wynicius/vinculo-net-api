using Vinculo_Net.Dominio.Entidades.Investidores;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Investidors;

public class RepositorioEscritaInvestidor(DominioContexto context) : RepositorioEscritaBase<Investidor, DominioContexto>(context)
{ }