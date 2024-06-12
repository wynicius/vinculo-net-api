using Vinculo_Net.Dominio.Entidades.Projetos;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Projetos;

public class RepositorioEscritaProjeto(DominioContexto context) : RepositorioEscritaBase<Projeto, DominioContexto>(context)
{ }