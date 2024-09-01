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
    }
}