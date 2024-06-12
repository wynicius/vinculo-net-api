using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vinculo_Net.Dominio.Entidades.Candidaturas;

namespace Vinculo_Net.Infraestrutura.Contexto.EntidadesConfiguracoes;

public class CandidaturaEntidadeConfiguracao : IEntityTypeConfiguration<Candidatura>
{
    public void Configure(EntityTypeBuilder<Candidatura> builder)
    {
        builder.ToTable("candidaturas", "vinculo_net");

        builder.HasKey(p => p.CandidaturaId);

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