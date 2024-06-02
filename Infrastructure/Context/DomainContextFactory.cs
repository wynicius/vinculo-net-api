using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Vinculo_Net_Api.Infrastructure.Context;

public class DomainContextFactory : IDesignTimeDbContextFactory<DomainContext>
{
    public DomainContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DomainContext>();
        optionsBuilder.UseNpgsql("XXXX");
        return new DomainContext(optionsBuilder.Options);
    }
}