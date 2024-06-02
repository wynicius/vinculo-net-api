using Microsoft.EntityFrameworkCore;
using NET.Data.Base;
using Vinculo_Net_Api.Domain.Entities.Ongs;

namespace Vinculo_Net_Api.Infrastructure.Context;


#nullable disable

public class DomainContext : DbContextBase<DomainContext>
{
    public DomainContext(DbContextOptions<DomainContext> options)
        : base(options)
    { }

    public DomainContext(DbContextOptions<DomainContext> options, IHttpContextAccessor httpContextAccessor)
        : base(options, httpContextAccessor)
    { }
    public DbSet<Ong> Ongs { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.EnableDetailedErrors();
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.UseSnakeCaseNamingConvention();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            entityType.GetForeignKeys()
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                .ToList()
                .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
        }

        base.OnModelCreating(modelBuilder);
    }
}