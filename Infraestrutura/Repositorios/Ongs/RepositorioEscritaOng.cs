using Vinculo_Net.Dominio.Entidades.Ongs;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Ongs;

public class RepositorioEscritaOng(DominioContexto context) : RepositorioEscritaBase<Ong, DominioContexto>(context)
{ }