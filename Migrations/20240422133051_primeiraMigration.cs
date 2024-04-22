using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carrinho.Migrations
{
    /// <inheritdoc />
    public partial class primeiraMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarrinhoCadastrados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoCadastrados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HorarioDaSemana",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiaDaSemana = table.Column<int>(type: "int", nullable: false),
                    HorarioAbertura = table.Column<TimeSpan>(type: "time", nullable: false),
                    HorarioFechamento = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioDaSemana", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CadastroCarrinhoAgendamento",
                columns: table => new
                {
                    AgendamentosDaSemanaId = table.Column<int>(type: "int", nullable: false),
                    CarrinhoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroCarrinhoAgendamento", x => new { x.AgendamentosDaSemanaId, x.CarrinhoId });
                    table.ForeignKey(
                        name: "FK_CadastroCarrinhoAgendamento_CarrinhoCadastrados_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "CarrinhoCadastrados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CadastroCarrinhoAgendamento_HorarioDaSemana_AgendamentosDaSemanaId",
                        column: x => x.AgendamentosDaSemanaId,
                        principalTable: "HorarioDaSemana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CadastroCarrinhoAgendamento_CarrinhoId",
                table: "CadastroCarrinhoAgendamento",
                column: "CarrinhoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroCarrinhoAgendamento");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "CarrinhoCadastrados");

            migrationBuilder.DropTable(
                name: "HorarioDaSemana");
        }
    }
}
