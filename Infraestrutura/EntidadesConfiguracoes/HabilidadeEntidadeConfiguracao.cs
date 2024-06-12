using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vinculo_Net.Dominio.Entidades.Habilidades;

namespace Vinculo_Net.Infraestrutura.Contexto.EntidadesConfiguracoes;

public class HabilidadeEntidadeConfiguracao : IEntityTypeConfiguration<Habilidade>
{
    public void Configure(EntityTypeBuilder<Habilidade> builder)
    {
        builder.ToTable("habilidades", "vinculo_net");

        builder.HasKey(p => p.HabilidadeId);

        // builder.Property(p => p.Nome)
        //     .IsRequired();

        // builder.HasOne(p => p.Convenio)
        //     .WithMany( p => p.Acoes)
        //     .HasForeignKey(p => p.ConvenioId)
        //     .IsRequired();

        // builder.HasOne(p => p.Unidade)
        //     .WithMany()
        //     .HasForeignKey(p => p.UnidadeId)
        //     .IsRequired();

        // builder.HasOne(p => p.Gestor)
        //     .WithMany()
        //     .HasForeignKey(p => p.GestorId)
        //     .IsRequired();

        // builder.Property(p => p.Nome)
        //     .IsRequired();
            
        // builder.HasOne(p => p.Unidade)
        //     .WithMany()
        //     .HasForeignKey(p => p.UnidadeId)
        //     .IsRequired(false);
    }
}