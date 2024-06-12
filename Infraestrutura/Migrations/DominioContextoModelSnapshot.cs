﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Vinculo_Net.Infraestrutura.Contexto;

#nullable disable

namespace Vinculo_Net.Infraestrutura.Migrations
{
    [DbContext(typeof(DominioContexto))]
    partial class DominioContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProjetoVoluntario", b =>
                {
                    b.Property<Guid>("ProjetosProjetoId")
                        .HasColumnType("uuid")
                        .HasColumnName("projetos_projeto_id");

                    b.Property<Guid>("VoluntariosVoluntarioId")
                        .HasColumnType("uuid")
                        .HasColumnName("voluntarios_voluntario_id");

                    b.HasKey("ProjetosProjetoId", "VoluntariosVoluntarioId")
                        .HasName("pk_projeto_voluntario");

                    b.HasIndex("VoluntariosVoluntarioId")
                        .HasDatabaseName("ix_projeto_voluntario_voluntarios_voluntario_id");

                    b.ToTable("projeto_voluntario", "vinculo_net");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Candidaturas.Candidatura", b =>
                {
                    b.Property<Guid>("CandidaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("candidatura_id");

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_cadastro");

                    b.Property<Guid>("ProjetoId")
                        .HasColumnType("uuid")
                        .HasColumnName("projeto_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("UsuarioAtualizacao")
                        .HasColumnType("text")
                        .HasColumnName("usuario_atualizacao");

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("text")
                        .HasColumnName("usuario_cadastro");

                    b.Property<Guid>("VoluntarioId")
                        .HasColumnType("uuid")
                        .HasColumnName("voluntario_id");

                    b.HasKey("CandidaturaId")
                        .HasName("pk_candidaturas");

                    b.ToTable("candidaturas", "vinculo_net");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Causas.Causa", b =>
                {
                    b.Property<Guid>("CausaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("causa_id");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_cadastro");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<Guid?>("InvestidorId")
                        .HasColumnType("uuid")
                        .HasColumnName("investidor_id");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<Guid?>("OngId")
                        .HasColumnType("uuid")
                        .HasColumnName("ong_id");

                    b.Property<string>("UsuarioAtualizacao")
                        .HasColumnType("text")
                        .HasColumnName("usuario_atualizacao");

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("text")
                        .HasColumnName("usuario_cadastro");

                    b.Property<Guid?>("VoluntarioId")
                        .HasColumnType("uuid")
                        .HasColumnName("voluntario_id");

                    b.HasKey("CausaId")
                        .HasName("pk_causas");

                    b.HasIndex("InvestidorId")
                        .HasDatabaseName("ix_causas_investidor_id");

                    b.HasIndex("OngId")
                        .HasDatabaseName("ix_causas_ong_id");

                    b.HasIndex("VoluntarioId")
                        .HasDatabaseName("ix_causas_voluntario_id");

                    b.ToTable("causas", "vinculo_net");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Habilidades.Habilidade", b =>
                {
                    b.Property<Guid>("HabilidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("habilidade_id");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_cadastro");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("UsuarioAtualizacao")
                        .HasColumnType("text")
                        .HasColumnName("usuario_atualizacao");

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("text")
                        .HasColumnName("usuario_cadastro");

                    b.HasKey("HabilidadeId")
                        .HasName("pk_habilidades");

                    b.ToTable("habilidades", "vinculo_net");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Investidores.Investidor", b =>
                {
                    b.Property<Guid>("InvestidorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("investidor_id");

                    b.Property<string>("Cnpj")
                        .HasColumnType("text")
                        .HasColumnName("cnpj");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_cadastro");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<Guid>("LocalizacaoId")
                        .HasColumnType("uuid")
                        .HasColumnName("localizacao_id");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("text")
                        .HasColumnName("nome_fantasia");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("text")
                        .HasColumnName("razao_social");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<int>("TipoInvestidor")
                        .HasColumnType("integer")
                        .HasColumnName("tipo_investidor");

                    b.Property<string>("UsuarioAtualizacao")
                        .HasColumnType("text")
                        .HasColumnName("usuario_atualizacao");

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("text")
                        .HasColumnName("usuario_cadastro");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid")
                        .HasColumnName("usuario_id");

                    b.HasKey("InvestidorId")
                        .HasName("pk_investidores");

                    b.HasIndex("LocalizacaoId")
                        .HasDatabaseName("ix_investidores_localizacao_id");

                    b.HasIndex("UsuarioId")
                        .HasDatabaseName("ix_investidores_usuario_id");

                    b.ToTable("investidores", "vinculo_net");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Investimentos.Investimento", b =>
                {
                    b.Property<Guid>("InvestimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("investimento_id");

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_cadastro");

                    b.Property<Guid>("InvestidorId")
                        .HasColumnType("uuid")
                        .HasColumnName("investidor_id");

                    b.Property<Guid>("ProjetoId")
                        .HasColumnType("uuid")
                        .HasColumnName("projeto_id");

                    b.Property<string>("UsuarioAtualizacao")
                        .HasColumnType("text")
                        .HasColumnName("usuario_atualizacao");

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("text")
                        .HasColumnName("usuario_cadastro");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric")
                        .HasColumnName("valor");

                    b.HasKey("InvestimentoId")
                        .HasName("pk_investimentos");

                    b.HasIndex("ProjetoId")
                        .HasDatabaseName("ix_investimentos_projeto_id");

                    b.ToTable("investimentos", "vinculo_net");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Localizacoes.Localizacao", b =>
                {
                    b.Property<Guid>("LocalizacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("localizacao_id");

                    b.Property<string>("Cep")
                        .HasColumnType("text")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .HasColumnType("text")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .HasColumnType("text")
                        .HasColumnName("complemento");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_cadastro");

                    b.Property<string>("Estado")
                        .HasColumnType("text")
                        .HasColumnName("estado");

                    b.Property<int>("Numero")
                        .HasColumnType("integer")
                        .HasColumnName("numero");

                    b.Property<string>("Pais")
                        .HasColumnType("text")
                        .HasColumnName("pais");

                    b.Property<string>("Rua")
                        .HasColumnType("text")
                        .HasColumnName("rua");

                    b.Property<string>("UsuarioAtualizacao")
                        .HasColumnType("text")
                        .HasColumnName("usuario_atualizacao");

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("text")
                        .HasColumnName("usuario_cadastro");

                    b.HasKey("LocalizacaoId")
                        .HasName("pk_localizacoes");

                    b.ToTable("localizacoes", "vinculo_net");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Ongs.Ong", b =>
                {
                    b.Property<Guid>("OngId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("ong_id");

                    b.Property<string>("Cnpj")
                        .HasColumnType("text")
                        .HasColumnName("cnpj");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_cadastro");

                    b.Property<DateTime>("DataFundacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_fundacao");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Historico")
                        .HasColumnType("text")
                        .HasColumnName("historico");

                    b.Property<Guid>("LocalizacaoId")
                        .HasColumnType("uuid")
                        .HasColumnName("localizacao_id");

                    b.Property<string>("Missao")
                        .HasColumnType("text")
                        .HasColumnName("missao");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<int>("StatusOng")
                        .HasColumnType("integer")
                        .HasColumnName("status_ong");

                    b.Property<int>("Telefone")
                        .HasColumnType("integer")
                        .HasColumnName("telefone");

                    b.Property<string>("UsuarioAtualizacao")
                        .HasColumnType("text")
                        .HasColumnName("usuario_atualizacao");

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("text")
                        .HasColumnName("usuario_cadastro");

                    b.Property<Guid?>("VoluntarioId")
                        .HasColumnType("uuid")
                        .HasColumnName("voluntario_id");

                    b.Property<string>("Website")
                        .HasColumnType("text")
                        .HasColumnName("website");

                    b.HasKey("OngId")
                        .HasName("pk_ongs");

                    b.HasIndex("LocalizacaoId")
                        .HasDatabaseName("ix_ongs_localizacao_id");

                    b.HasIndex("VoluntarioId")
                        .HasDatabaseName("ix_ongs_voluntario_id");

                    b.ToTable("ongs", "vinculo_net");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Projetos.Projeto", b =>
                {
                    b.Property<Guid>("ProjetoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("projeto_id");

                    b.Property<Guid?>("CausaId")
                        .HasColumnType("uuid")
                        .HasColumnName("causa_id");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_cadastro");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_inicio");

                    b.Property<DateTime>("DataTermino")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_termino");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<string>("Metas")
                        .HasColumnType("text")
                        .HasColumnName("metas");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("Objetivos")
                        .HasColumnType("text")
                        .HasColumnName("objetivos");

                    b.Property<Guid>("OngId")
                        .HasColumnType("uuid")
                        .HasColumnName("ong_id");

                    b.Property<int>("Orcamento")
                        .HasColumnType("integer")
                        .HasColumnName("orcamento");

                    b.Property<int>("StatusProjeto")
                        .HasColumnType("integer")
                        .HasColumnName("status_projeto");

                    b.Property<string>("UsuarioAtualizacao")
                        .HasColumnType("text")
                        .HasColumnName("usuario_atualizacao");

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("text")
                        .HasColumnName("usuario_cadastro");

                    b.HasKey("ProjetoId")
                        .HasName("pk_projetos");

                    b.HasIndex("CausaId")
                        .HasDatabaseName("ix_projetos_causa_id");

                    b.HasIndex("OngId")
                        .HasDatabaseName("ix_projetos_ong_id");

                    b.ToTable("projetos", "vinculo_net");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Usuarios.Usuario", b =>
                {
                    b.Property<Guid>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("usuario_id");

                    b.Property<string>("Cpf")
                        .HasColumnType("text")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_cadastro");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<char?>("Genero")
                        .HasColumnType("character(1)")
                        .HasColumnName("genero");

                    b.Property<Guid>("LocalizacaoId")
                        .HasColumnType("uuid")
                        .HasColumnName("localizacao_id");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("text")
                        .HasColumnName("nome_completo");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("text")
                        .HasColumnName("sobrenome");

                    b.Property<string>("Telefone")
                        .HasColumnType("text")
                        .HasColumnName("telefone");

                    b.Property<string>("UsuarioAtualizacao")
                        .HasColumnType("text")
                        .HasColumnName("usuario_atualizacao");

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("text")
                        .HasColumnName("usuario_cadastro");

                    b.HasKey("UsuarioId")
                        .HasName("pk_usuarios");

                    b.HasIndex("LocalizacaoId")
                        .HasDatabaseName("ix_usuarios_localizacao_id");

                    b.ToTable("usuarios", "vinculo_net");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Voluntarios.Voluntario", b =>
                {
                    b.Property<Guid>("VoluntarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("voluntario_id");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_cadastro");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<string>("Disponibilidade")
                        .HasColumnType("text")
                        .HasColumnName("disponibilidade");

                    b.Property<string>("Experiencia")
                        .HasColumnType("text")
                        .HasColumnName("experiencia");

                    b.Property<string>("Formacao")
                        .HasColumnType("text")
                        .HasColumnName("formacao");

                    b.Property<Guid?>("HabilidadesHabilidadeId")
                        .HasColumnType("uuid")
                        .HasColumnName("habilidades_habilidade_id");

                    b.Property<Guid?>("LocalizacaoId")
                        .HasColumnType("uuid")
                        .HasColumnName("localizacao_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("UsuarioAtualizacao")
                        .HasColumnType("text")
                        .HasColumnName("usuario_atualizacao");

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("text")
                        .HasColumnName("usuario_cadastro");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid")
                        .HasColumnName("usuario_id");

                    b.HasKey("VoluntarioId")
                        .HasName("pk_voluntarios");

                    b.HasIndex("HabilidadesHabilidadeId")
                        .HasDatabaseName("ix_voluntarios_habilidades_habilidade_id");

                    b.HasIndex("LocalizacaoId")
                        .HasDatabaseName("ix_voluntarios_localizacao_id");

                    b.HasIndex("UsuarioId")
                        .HasDatabaseName("ix_voluntarios_usuario_id");

                    b.ToTable("voluntarios", "vinculo_net");
                });

            modelBuilder.Entity("ProjetoVoluntario", b =>
                {
                    b.HasOne("Vinculo_Net.Dominio.Entidades.Projetos.Projeto", null)
                        .WithMany()
                        .HasForeignKey("ProjetosProjetoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_projeto_voluntario_projetos_projetos_projeto_id");

                    b.HasOne("Vinculo_Net.Dominio.Entidades.Voluntarios.Voluntario", null)
                        .WithMany()
                        .HasForeignKey("VoluntariosVoluntarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_projeto_voluntario_voluntarios_voluntarios_voluntario_id");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Causas.Causa", b =>
                {
                    b.HasOne("Vinculo_Net.Dominio.Entidades.Investidores.Investidor", null)
                        .WithMany("Causas")
                        .HasForeignKey("InvestidorId")
                        .HasConstraintName("fk_causas_investidores_investidor_id");

                    b.HasOne("Vinculo_Net.Dominio.Entidades.Ongs.Ong", null)
                        .WithMany("Causas")
                        .HasForeignKey("OngId")
                        .HasConstraintName("fk_causas_ongs_ong_id");

                    b.HasOne("Vinculo_Net.Dominio.Entidades.Voluntarios.Voluntario", null)
                        .WithMany("Causas")
                        .HasForeignKey("VoluntarioId")
                        .HasConstraintName("fk_causas_voluntarios_voluntario_id");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Investidores.Investidor", b =>
                {
                    b.HasOne("Vinculo_Net.Dominio.Entidades.Localizacoes.Localizacao", "Localizacao")
                        .WithMany()
                        .HasForeignKey("LocalizacaoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_investidores_localizacoes_localizacao_id");

                    b.HasOne("Vinculo_Net.Dominio.Entidades.Usuarios.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_investidores_usuarios_usuario_id");

                    b.Navigation("Localizacao");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Investimentos.Investimento", b =>
                {
                    b.HasOne("Vinculo_Net.Dominio.Entidades.Projetos.Projeto", "Projeto")
                        .WithMany("Investimentos")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_investimentos_projetos_projeto_id");

                    b.Navigation("Projeto");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Ongs.Ong", b =>
                {
                    b.HasOne("Vinculo_Net.Dominio.Entidades.Localizacoes.Localizacao", "Localizacao")
                        .WithMany()
                        .HasForeignKey("LocalizacaoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_ongs_localizacoes_localizacao_id");

                    b.HasOne("Vinculo_Net.Dominio.Entidades.Voluntarios.Voluntario", null)
                        .WithMany("Ongs")
                        .HasForeignKey("VoluntarioId")
                        .HasConstraintName("fk_ongs_voluntarios_voluntario_id");

                    b.Navigation("Localizacao");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Projetos.Projeto", b =>
                {
                    b.HasOne("Vinculo_Net.Dominio.Entidades.Causas.Causa", "Causa")
                        .WithMany()
                        .HasForeignKey("CausaId")
                        .HasConstraintName("fk_projetos_causas_causa_id");

                    b.HasOne("Vinculo_Net.Dominio.Entidades.Ongs.Ong", null)
                        .WithMany("Projetos")
                        .HasForeignKey("OngId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_projetos_ongs_ong_id");

                    b.Navigation("Causa");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Usuarios.Usuario", b =>
                {
                    b.HasOne("Vinculo_Net.Dominio.Entidades.Localizacoes.Localizacao", "Localizacao")
                        .WithMany()
                        .HasForeignKey("LocalizacaoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_usuarios_localizacoes_localizacao_id");

                    b.Navigation("Localizacao");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Voluntarios.Voluntario", b =>
                {
                    b.HasOne("Vinculo_Net.Dominio.Entidades.Habilidades.Habilidade", "Habilidades")
                        .WithMany()
                        .HasForeignKey("HabilidadesHabilidadeId")
                        .HasConstraintName("fk_voluntarios_habilidades_habilidades_habilidade_id");

                    b.HasOne("Vinculo_Net.Dominio.Entidades.Localizacoes.Localizacao", "Localizacao")
                        .WithMany()
                        .HasForeignKey("LocalizacaoId")
                        .HasConstraintName("fk_voluntarios_localizacoes_localizacao_id");

                    b.HasOne("Vinculo_Net.Dominio.Entidades.Usuarios.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_voluntarios_usuarios_usuario_id");

                    b.Navigation("Habilidades");

                    b.Navigation("Localizacao");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Investidores.Investidor", b =>
                {
                    b.Navigation("Causas");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Ongs.Ong", b =>
                {
                    b.Navigation("Causas");

                    b.Navigation("Projetos");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Projetos.Projeto", b =>
                {
                    b.Navigation("Investimentos");
                });

            modelBuilder.Entity("Vinculo_Net.Dominio.Entidades.Voluntarios.Voluntario", b =>
                {
                    b.Navigation("Causas");

                    b.Navigation("Ongs");
                });
#pragma warning restore 612, 618
        }
    }
}
