using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Vinculo_Net_Api.Infraestrutura.Contexto;

public class DominioContextoFactory : IDesignTimeDbContextFactory<DominioContexto>
{
    public DominioContexto CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DominioContexto>();
        optionsBuilder.UseNpgsql("XXXX");
        return new DominioContexto(optionsBuilder.Options);
    }
}