using Microsoft.EntityFrameworkCore;
using NET.Data.Base;
using Vinculo_Net.Dominio.Entidades.Candidaturas;
using Vinculo_Net.Dominio.Entidades.Causas;
using Vinculo_Net.Dominio.Entidades.Habilidades;
using Vinculo_Net.Dominio.Entidades.Investidores;
using Vinculo_Net.Dominio.Entidades.Investimentos;
using Vinculo_Net.Dominio.Entidades.Localizacoes;
using Vinculo_Net.Dominio.Entidades.Ongs;
using Vinculo_Net.Dominio.Entidades.Projetos;
using Vinculo_Net.Dominio.Entidades.Usuarios;
using Vinculo_Net.Dominio.Entidades.Voluntarios;

namespace Vinculo_Net.Infraestrutura.Contexto;


#nullable disable

public class DominioContexto : DbContextBase<DominioContexto>
{
    public DominioContexto(DbContextOptions<DominioContexto> options)
        : base(options)
    { }

    public DominioContexto(DbContextOptions<DominioContexto> options, IHttpContextAccessor httpContextAccessor)
        : base(options, httpContextAccessor)
    { }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Ong> Ongs { get; set; }
    public DbSet<Voluntario> Voluntarios { get; set; }
    public DbSet<Investidor> Investidores { get; set; }
    public DbSet<Localizacao> Localizacoes { get; set; }
    public DbSet<Causa> Causas { get; set; }
    public DbSet<Projeto> Projetos { get; set; }
    public DbSet<Habilidade> Habilidades { get; set; }
    public DbSet<Candidatura> Candidaturas { get; set; }
    public DbSet<Investimento> Investimentos { get; set; }

    
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