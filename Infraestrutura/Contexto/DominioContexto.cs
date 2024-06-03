using Microsoft.EntityFrameworkCore;
using NET.Data.Base;
using Vinculo_Net_Api.Dominio.Entidades.Ongs;

namespace Vinculo_Net_Api.Infraestrutura.Contexto;


#nullable disable

public class DominioContexto : DbContextBase<DominioContexto>
{
    public DominioContexto(DbContextOptions<DominioContexto> options)
        : base(options)
    { }

    public DominioContexto(DbContextOptions<DominioContexto> options, IHttpContextAccessor httpContextAccessor)
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