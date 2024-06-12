using Vinculo_Net.Dominio.Entidades.Investimentos;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Investimentos;

public class RepositorioEscritaInvestimento(DominioContexto context) : RepositorioEscritaBase<Investimento, DominioContexto>(context)
{ }