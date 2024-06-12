using Vinculo_Net.Infraestrutura.Contexto;
using NET.Data.Base;
using Vinculo_Net.Dominio.Entidades.Localizacoes;

namespace Vinculo_Net.Infraestrutura.Repositorios.Localizacaos;

public class RepositorioLeituraLocalizacao(DominioContexto context) : RepositorioLeituraBase<Localizacao, DominioContexto>(context)
{ }