using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vinculo_Net.Dominio.Entidades.Voluntarios;

namespace Vinculo_Net.Infraestrutura.EntidadesConfiguracoes;

public class VoluntarioEntidadeConfiguracao : IEntityTypeConfiguration<Voluntario>
{
    public void Configure(EntityTypeBuilder<Voluntario> builder)
    {
        builder.ToTable("voluntarios", "vinculo_net");

        builder.HasKey(p => p.VoluntarioId);

        // Additional configuration can be added here
    }
}