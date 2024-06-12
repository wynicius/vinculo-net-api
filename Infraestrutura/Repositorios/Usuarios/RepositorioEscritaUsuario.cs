using Vinculo_Net.Dominio.Entidades.Usuarios;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Usuarios;

public class RepositorioEscritaUsuario(DominioContexto context) : RepositorioEscritaBase<Usuario, DominioContexto>(context)
{ }