using Vinculo_Net.Dominio.Entidades.Causas;
using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;

namespace Vinculo_Net.Infraestrutura.Repositorios.Causas;

public class RepositorioLeituraCausa(DominioContexto context) : RepositorioLeituraBase<Causa, DominioContexto>(context)
{ }