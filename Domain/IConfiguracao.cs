using System.Reflection;

namespace Vinculo_Net_Api.Domain;

public interface IConfiguracao
{
    public List<Assembly> Assemblies { get; set; }
    public List<Type> ComportamentosAbertos { get; set; }
}