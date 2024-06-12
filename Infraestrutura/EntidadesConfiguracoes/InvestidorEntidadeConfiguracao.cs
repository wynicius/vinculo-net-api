using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vinculo_Net.Dominio.Entidades.Investidores;

namespace Vinculo_Net.Infraestrutura.Contexto.EntidadesConfiguracoes;

public class InvestidorEntidadeConfiguracao : IEntityTypeConfiguration<Investidor>
{
    public void Configure(EntityTypeBuilder<Investidor> builder)
    {
        builder.ToTable("investidores", "vinculo_net");

        builder.HasKey(p => p.InvestidorId);

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