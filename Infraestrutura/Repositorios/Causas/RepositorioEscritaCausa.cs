using Vinculo_Net.Dominio.Entidades.Causas;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Causas;

public class RepositorioEscritaCausa(DominioContexto context) : RepositorioEscritaBase<Causa, DominioContexto>(context)
{ }