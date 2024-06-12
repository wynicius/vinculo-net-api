using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vinculo_Net.Dominio.Entidades.Investimentos;

namespace Vinculo_Net.Infraestrutura.Contexto.EntidadesConfiguracoes;

public class InvestimentoEntidadeConfiguracao : IEntityTypeConfiguration<Investimento>
{
    public void Configure(EntityTypeBuilder<Investimento> builder)
    {
        builder.ToTable("investimentos", "vinculo_net");

        builder.HasKey(p => p.InvestimentoId);

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