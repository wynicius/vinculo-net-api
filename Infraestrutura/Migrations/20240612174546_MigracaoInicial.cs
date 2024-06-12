using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vinculo_Net.Infraestrutura.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "vinculo_net");

            migrationBuilder.CreateTable(
                name: "candidaturas",
                schema: "vinculo_net",
                columns: table => new
                {
                    candidatura_id = table.Column<Guid>(type: "uuid", nullable: false),
                    voluntario_id = table.Column<Guid>(type: "uuid", nullable: false),
                    projeto_id = table.Column<Guid>(type: "uuid", nullable: false),
                    data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    usuario_cadastro = table.Column<string>(type: "text", nullable: true),
                    usuario_atualizacao = table.Column<string>(type: "text", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_candidaturas", x => x.candidatura_id);
                });

            migrationBuilder.CreateTable(
                name: "habilidades",
                schema: "vinculo_net",
                columns: table => new
                {
                    habilidade_id = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    usuario_cadastro = table.Column<string>(type: "text", nullable: true),
                    usuario_atualizacao = table.Column<string>(type: "text", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_habilidades", x => x.habilidade_id);
                });

            migrationBuilder.CreateTable(
                name: "localizacoes",
                schema: "vinculo_net",
                columns: table => new
                {
                    localizacao_id = table.Column<Guid>(type: "uuid", nullable: false),
                    rua = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<int>(type: "integer", nullable: false),
                    complemento = table.Column<string>(type: "text", nullable: true),
                    cidade = table.Column<string>(type: "text", nullable: true),
                    estado = table.Column<string>(type: "text", nullable: true),
                    pais = table.Column<string>(type: "text", nullable: true),
                    cep = table.Column<string>(type: "text", nullable: true),
                    usuario_cadastro = table.Column<string>(type: "text", nullable: true),
                    usuario_atualizacao = table.Column<string>(type: "text", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_localizacoes", x => x.localizacao_id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                schema: "vinculo_net",
                columns: table => new
                {
                    usuario_id = table.Column<Guid>(type: "uuid", nullable: false),
                    localizacao_id = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    sobrenome = table.Column<string>(type: "text", nullable: true),
                    nome_completo = table.Column<string>(type: "text", nullable: true),
                    data_nascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    cpf = table.Column<string>(type: "text", nullable: true),
                    genero = table.Column<char>(type: "character(1)", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    telefone = table.Column<string>(type: "text", nullable: true),
                    usuario_cadastro = table.Column<string>(type: "text", nullable: true),
                    usuario_atualizacao = table.Column<string>(type: "text", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_usuarios", x => x.usuario_id);
                    table.ForeignKey(
                        name: "fk_usuarios_localizacoes_localizacao_id",
                        column: x => x.localizacao_id,
                        principalSchema: "vinculo_net",
                        principalTable: "localizacoes",
                        principalColumn: "localizacao_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "investidores",
                schema: "vinculo_net",
                columns: table => new
                {
                    investidor_id = table.Column<Guid>(type: "uuid", nullable: false),
                    usuario_id = table.Column<Guid>(type: "uuid", nullable: false),
                    localizacao_id = table.Column<Guid>(type: "uuid", nullable: false),
                    tipo_investidor = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    nome_fantasia = table.Column<string>(type: "text", nullable: true),
                    razao_social = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    cnpj = table.Column<string>(type: "text", nullable: true),
                    usuario_cadastro = table.Column<string>(type: "text", nullable: true),
                    usuario_atualizacao = table.Column<string>(type: "text", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_investidores", x => x.investidor_id);
                    table.ForeignKey(
                        name: "fk_investidores_localizacoes_localizacao_id",
                        column: x => x.localizacao_id,
                        principalSchema: "vinculo_net",
                        principalTable: "localizacoes",
                        principalColumn: "localizacao_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_investidores_usuarios_usuario_id",
                        column: x => x.usuario_id,
                        principalSchema: "vinculo_net",
                        principalTable: "usuarios",
                        principalColumn: "usuario_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "voluntarios",
                schema: "vinculo_net",
                columns: table => new
                {
                    voluntario_id = table.Column<Guid>(type: "uuid", nullable: false),
                    usuario_id = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    experiencia = table.Column<string>(type: "text", nullable: true),
                    formacao = table.Column<string>(type: "text", nullable: true),
                    disponibilidade = table.Column<string>(type: "text", nullable: true),
                    habilidades_habilidade_id = table.Column<Guid>(type: "uuid", nullable: true),
                    localizacao_id = table.Column<Guid>(type: "uuid", nullable: true),
                    usuario_cadastro = table.Column<string>(type: "text", nullable: true),
                    usuario_atualizacao = table.Column<string>(type: "text", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_voluntarios", x => x.voluntario_id);
                    table.ForeignKey(
                        name: "fk_voluntarios_habilidades_habilidades_habilidade_id",
                        column: x => x.habilidades_habilidade_id,
                        principalSchema: "vinculo_net",
                        principalTable: "habilidades",
                        principalColumn: "habilidade_id");
                    table.ForeignKey(
                        name: "fk_voluntarios_localizacoes_localizacao_id",
                        column: x => x.localizacao_id,
                        principalSchema: "vinculo_net",
                        principalTable: "localizacoes",
                        principalColumn: "localizacao_id");
                    table.ForeignKey(
                        name: "fk_voluntarios_usuarios_usuario_id",
                        column: x => x.usuario_id,
                        principalSchema: "vinculo_net",
                        principalTable: "usuarios",
                        principalColumn: "usuario_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ongs",
                schema: "vinculo_net",
                columns: table => new
                {
                    ong_id = table.Column<Guid>(type: "uuid", nullable: false),
                    localizacao_id = table.Column<Guid>(type: "uuid", nullable: false),
                    status_ong = table.Column<int>(type: "integer", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    cnpj = table.Column<string>(type: "text", nullable: true),
                    data_fundacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    missao = table.Column<string>(type: "text", nullable: true),
                    telefone = table.Column<int>(type: "integer", nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    historico = table.Column<string>(type: "text", nullable: true),
                    website = table.Column<string>(type: "text", nullable: true),
                    voluntario_id = table.Column<Guid>(type: "uuid", nullable: true),
                    usuario_cadastro = table.Column<string>(type: "text", nullable: true),
                    usuario_atualizacao = table.Column<string>(type: "text", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ongs", x => x.ong_id);
                    table.ForeignKey(
                        name: "fk_ongs_localizacoes_localizacao_id",
                        column: x => x.localizacao_id,
                        principalSchema: "vinculo_net",
                        principalTable: "localizacoes",
                        principalColumn: "localizacao_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_ongs_voluntarios_voluntario_id",
                        column: x => x.voluntario_id,
                        principalSchema: "vinculo_net",
                        principalTable: "voluntarios",
                        principalColumn: "voluntario_id");
                });

            migrationBuilder.CreateTable(
                name: "causas",
                schema: "vinculo_net",
                columns: table => new
                {
                    causa_id = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    investidor_id = table.Column<Guid>(type: "uuid", nullable: true),
                    ong_id = table.Column<Guid>(type: "uuid", nullable: true),
                    voluntario_id = table.Column<Guid>(type: "uuid", nullable: true),
                    usuario_cadastro = table.Column<string>(type: "text", nullable: true),
                    usuario_atualizacao = table.Column<string>(type: "text", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_causas", x => x.causa_id);
                    table.ForeignKey(
                        name: "fk_causas_investidores_investidor_id",
                        column: x => x.investidor_id,
                        principalSchema: "vinculo_net",
                        principalTable: "investidores",
                        principalColumn: "investidor_id");
                    table.ForeignKey(
                        name: "fk_causas_ongs_ong_id",
                        column: x => x.ong_id,
                        principalSchema: "vinculo_net",
                        principalTable: "ongs",
                        principalColumn: "ong_id");
                    table.ForeignKey(
                        name: "fk_causas_voluntarios_voluntario_id",
                        column: x => x.voluntario_id,
                        principalSchema: "vinculo_net",
                        principalTable: "voluntarios",
                        principalColumn: "voluntario_id");
                });

            migrationBuilder.CreateTable(
                name: "projetos",
                schema: "vinculo_net",
                columns: table => new
                {
                    projeto_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ong_id = table.Column<Guid>(type: "uuid", nullable: false),
                    status_projeto = table.Column<int>(type: "integer", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    objetivos = table.Column<string>(type: "text", nullable: true),
                    metas = table.Column<string>(type: "text", nullable: true),
                    orcamento = table.Column<int>(type: "integer", nullable: false),
                    data_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_termino = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    causa_id = table.Column<Guid>(type: "uuid", nullable: true),
                    usuario_cadastro = table.Column<string>(type: "text", nullable: true),
                    usuario_atualizacao = table.Column<string>(type: "text", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_projetos", x => x.projeto_id);
                    table.ForeignKey(
                        name: "fk_projetos_causas_causa_id",
                        column: x => x.causa_id,
                        principalSchema: "vinculo_net",
                        principalTable: "causas",
                        principalColumn: "causa_id");
                    table.ForeignKey(
                        name: "fk_projetos_ongs_ong_id",
                        column: x => x.ong_id,
                        principalSchema: "vinculo_net",
                        principalTable: "ongs",
                        principalColumn: "ong_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "investimentos",
                schema: "vinculo_net",
                columns: table => new
                {
                    investimento_id = table.Column<Guid>(type: "uuid", nullable: false),
                    investidor_id = table.Column<Guid>(type: "uuid", nullable: false),
                    projeto_id = table.Column<Guid>(type: "uuid", nullable: false),
                    valor = table.Column<decimal>(type: "numeric", nullable: false),
                    data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    usuario_cadastro = table.Column<string>(type: "text", nullable: true),
                    usuario_atualizacao = table.Column<string>(type: "text", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_investimentos", x => x.investimento_id);
                    table.ForeignKey(
                        name: "fk_investimentos_projetos_projeto_id",
                        column: x => x.projeto_id,
                        principalSchema: "vinculo_net",
                        principalTable: "projetos",
                        principalColumn: "projeto_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "projeto_voluntario",
                schema: "vinculo_net",
                columns: table => new
                {
                    projetos_projeto_id = table.Column<Guid>(type: "uuid", nullable: false),
                    voluntarios_voluntario_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_projeto_voluntario", x => new { x.projetos_projeto_id, x.voluntarios_voluntario_id });
                    table.ForeignKey(
                        name: "fk_projeto_voluntario_projetos_projetos_projeto_id",
                        column: x => x.projetos_projeto_id,
                        principalSchema: "vinculo_net",
                        principalTable: "projetos",
                        principalColumn: "projeto_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_projeto_voluntario_voluntarios_voluntarios_voluntario_id",
                        column: x => x.voluntarios_voluntario_id,
                        principalSchema: "vinculo_net",
                        principalTable: "voluntarios",
                        principalColumn: "voluntario_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_causas_investidor_id",
                schema: "vinculo_net",
                table: "causas",
                column: "investidor_id");

            migrationBuilder.CreateIndex(
                name: "ix_causas_ong_id",
                schema: "vinculo_net",
                table: "causas",
                column: "ong_id");

            migrationBuilder.CreateIndex(
                name: "ix_causas_voluntario_id",
                schema: "vinculo_net",
                table: "causas",
                column: "voluntario_id");

            migrationBuilder.CreateIndex(
                name: "ix_investidores_localizacao_id",
                schema: "vinculo_net",
                table: "investidores",
                column: "localizacao_id");

            migrationBuilder.CreateIndex(
                name: "ix_investidores_usuario_id",
                schema: "vinculo_net",
                table: "investidores",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "ix_investimentos_projeto_id",
                schema: "vinculo_net",
                table: "investimentos",
                column: "projeto_id");

            migrationBuilder.CreateIndex(
                name: "ix_ongs_localizacao_id",
                schema: "vinculo_net",
                table: "ongs",
                column: "localizacao_id");

            migrationBuilder.CreateIndex(
                name: "ix_ongs_voluntario_id",
                schema: "vinculo_net",
                table: "ongs",
                column: "voluntario_id");

            migrationBuilder.CreateIndex(
                name: "ix_projeto_voluntario_voluntarios_voluntario_id",
                schema: "vinculo_net",
                table: "projeto_voluntario",
                column: "voluntarios_voluntario_id");

            migrationBuilder.CreateIndex(
                name: "ix_projetos_causa_id",
                schema: "vinculo_net",
                table: "projetos",
                column: "causa_id");

            migrationBuilder.CreateIndex(
                name: "ix_projetos_ong_id",
                schema: "vinculo_net",
                table: "projetos",
                column: "ong_id");

            migrationBuilder.CreateIndex(
                name: "ix_usuarios_localizacao_id",
                schema: "vinculo_net",
                table: "usuarios",
                column: "localizacao_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntarios_habilidades_habilidade_id",
                schema: "vinculo_net",
                table: "voluntarios",
                column: "habilidades_habilidade_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntarios_localizacao_id",
                schema: "vinculo_net",
                table: "voluntarios",
                column: "localizacao_id");

            migrationBuilder.CreateIndex(
                name: "ix_voluntarios_usuario_id",
                schema: "vinculo_net",
                table: "voluntarios",
                column: "usuario_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "candidaturas",
                schema: "vinculo_net");

            migrationBuilder.DropTable(
                name: "investimentos",
                schema: "vinculo_net");

            migrationBuilder.DropTable(
                name: "projeto_voluntario",
                schema: "vinculo_net");

            migrationBuilder.DropTable(
                name: "projetos",
                schema: "vinculo_net");

            migrationBuilder.DropTable(
                name: "causas",
                schema: "vinculo_net");

            migrationBuilder.DropTable(
                name: "investidores",
                schema: "vinculo_net");

            migrationBuilder.DropTable(
                name: "ongs",
                schema: "vinculo_net");

            migrationBuilder.DropTable(
                name: "voluntarios",
                schema: "vinculo_net");

            migrationBuilder.DropTable(
                name: "habilidades",
                schema: "vinculo_net");

            migrationBuilder.DropTable(
                name: "usuarios",
                schema: "vinculo_net");

            migrationBuilder.DropTable(
                name: "localizacoes",
                schema: "vinculo_net");
        }
    }
}
