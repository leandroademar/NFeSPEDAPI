using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NFeSPEDAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nfes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    chave_acesso = table.Column<string>(type: "text", nullable: false),
                    numero = table.Column<string>(type: "text", nullable: false),
                    serie = table.Column<string>(type: "text", nullable: false),
                    data_emissao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    valor_total = table.Column<decimal>(type: "numeric", nullable: false),
                    cnpj_emitente = table.Column<string>(type: "text", nullable: false),
                    nome_emitente = table.Column<string>(type: "text", nullable: false),
                    cnpj_destinatario = table.Column<string>(type: "text", nullable: false),
                    nome_destinatario = table.Column<string>(type: "text", nullable: false),
                    data_importacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    xml_completo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sped_arquivos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    cnpj = table.Column<string>(type: "text", nullable: false),
                    nome_empresa = table.Column<string>(type: "text", nullable: false),
                    periodo_inicial = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    periodo_final = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    data_importacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    arquivo_completo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sped_arquivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nfe_itens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    nfe_id = table.Column<Guid>(type: "uuid", nullable: false),
                    numero_item = table.Column<int>(type: "integer", nullable: false),
                    codigo_produto = table.Column<string>(type: "text", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: false),
                    ncm = table.Column<string>(type: "text", nullable: false),
                    cfop = table.Column<string>(type: "text", nullable: false),
                    unidade = table.Column<string>(type: "text", nullable: false),
                    quantidade = table.Column<decimal>(type: "numeric", nullable: false),
                    valor_unitario = table.Column<decimal>(type: "numeric", nullable: false),
                    valor_total = table.Column<decimal>(type: "numeric", nullable: false),
                    valor_icms = table.Column<decimal>(type: "numeric", nullable: false),
                    valor_ipi = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfe_itens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nfe_itens_nfes_nfe_id",
                        column: x => x.nfe_id,
                        principalTable: "nfes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sped_blocos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    sped_id = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo_bloco = table.Column<string>(type: "text", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sped_blocos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sped_blocos_sped_arquivos_sped_id",
                        column: x => x.sped_id,
                        principalTable: "sped_arquivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sped_registros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    bloco_id = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo_registro = table.Column<string>(type: "text", nullable: false),
                    conteudo = table.Column<string>(type: "text", nullable: false),
                    linha_arquivo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sped_registros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sped_registros_sped_blocos_bloco_id",
                        column: x => x.bloco_id,
                        principalTable: "sped_blocos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_nfe_itens_nfe_id",
                table: "nfe_itens",
                column: "nfe_id");

            migrationBuilder.CreateIndex(
                name: "IX_sped_blocos_sped_id",
                table: "sped_blocos",
                column: "sped_id");

            migrationBuilder.CreateIndex(
                name: "IX_sped_registros_bloco_id",
                table: "sped_registros",
                column: "bloco_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nfe_itens");

            migrationBuilder.DropTable(
                name: "sped_registros");

            migrationBuilder.DropTable(
                name: "nfes");

            migrationBuilder.DropTable(
                name: "sped_blocos");

            migrationBuilder.DropTable(
                name: "sped_arquivos");
        }
    }
}
