using Vinculo_Net.Dominio.Entidades.Candidaturas;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Candidaturas;

public class RepositorioEscritaCandidatura(DominioContexto context) : RepositorioEscritaBase<Candidatura, DominioContexto>(context)
{ }