using Vinculo_Net.Dominio.Entidades.Ongs;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Ongs;

public class RepositorioLeituraOng(DominioContexto context) : RepositorioLeituraBase<Ong, DominioContexto>(context)
{ }