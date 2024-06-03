using System.Reflection;
using Vinculo_Net_Api.Dominio;

namespace Vinculo_Net_Api.Infraestrutura;

#nullable disable
public class Configuracao : IConfiguracao
{
    public List<Assembly> Assemblies { get; set; } = new();
    public List<Type> ComportamentosAbertos { get; set; } = new();
}