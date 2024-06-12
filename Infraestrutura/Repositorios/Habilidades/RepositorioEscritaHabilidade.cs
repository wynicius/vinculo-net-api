using Vinculo_Net.Dominio.Entidades.Habilidades;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Habilidades;

public class RepositorioEscritaHabilidade(DominioContexto context) : RepositorioEscritaBase<Habilidade, DominioContexto>(context)
{ }