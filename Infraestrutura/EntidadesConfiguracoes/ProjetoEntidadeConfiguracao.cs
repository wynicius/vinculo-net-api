using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vinculo_Net.Dominio.Entidades.Projetos;

namespace Vinculo_Net.Infraestrutura.Contexto.EntidadesConfiguracoes;

public class ProjetoEntidadeConfiguracao : IEntityTypeConfiguration<Projeto>
{
    public void Configure(EntityTypeBuilder<Projeto> builder)
    {
        builder.ToTable("projetos", "vinculo_net");

        builder.HasKey(p => p.ProjetoId);

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