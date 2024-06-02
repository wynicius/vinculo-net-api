using System.Reflection;
using Vinculo_Net_Api.Domain;

namespace Vinculo_Net_Api.Infrastructure;

#nullable disable
public class Configuracao : IConfiguracao
{
    public List<Assembly> Assemblies { get; set; } = new();
    public List<Type> ComportamentosAbertos { get; set; } = new();
}