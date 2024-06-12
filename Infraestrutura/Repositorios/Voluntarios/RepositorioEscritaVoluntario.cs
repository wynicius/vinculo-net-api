using Vinculo_Net.Dominio.Entidades.Voluntarios;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Voluntarios;

public class RepositorioEscritaVoluntario(DominioContexto context) : RepositorioEscritaBase<Voluntario, DominioContexto>(context)
{ }