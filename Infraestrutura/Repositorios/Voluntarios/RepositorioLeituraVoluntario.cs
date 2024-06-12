using Vinculo_Net.Dominio.Entidades.Voluntarios;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Voluntarios;

public class RepositorioLeituraVoluntario(DominioContexto context) : RepositorioLeituraBase<Voluntario, DominioContexto>(context)
{ }