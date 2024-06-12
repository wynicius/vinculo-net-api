using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vinculo_Net.Dominio.Entidades.Usuarios;

namespace Vinculo_Net.Infraestrutura.Contexto.EntidadesConfiguracoes;

public class UsuarioEntidadeConfiguracao : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("usuarios", "vinculo_net");

        builder.HasKey(p => p.UsuarioId);

        // builder.Property(p => p.Nome)
        //     .IsRequired();
    }
}