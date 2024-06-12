using Vinculo_Net.Dominio.Entidades.Usuarios;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Usuarios;

public class RepositorioLeituraUsuario(DominioContexto context) : RepositorioLeituraBase<Usuario, DominioContexto>(context)
{ }