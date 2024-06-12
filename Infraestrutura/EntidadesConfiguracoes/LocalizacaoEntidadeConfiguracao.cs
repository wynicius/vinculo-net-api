using Dominio.Entidades.Localizacoes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Vinculo_Net.Infraestrutura.Contexto.EntidadesConfiguracoes;

public class LocalizacaoEntidadeConfiguracao : IEntityTypeConfiguration<Localizacao>
{
    public void Configure(EntityTypeBuilder<Localizacao> builder)
    {
        builder.ToTable("localizacoes", "vinculo_net");

        builder.HasKey(p => p.LocalizacaoId);

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