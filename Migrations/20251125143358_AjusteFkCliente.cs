using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketManager.Migrations
{
    /// <inheritdoc />
    public partial class AjusteFkCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caso_Cliente_ClienteId",
                table: "Caso");

            migrationBuilder.DropIndex(
                name: "IX_Caso_ClienteId",
                table: "Caso");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Caso");

            migrationBuilder.CreateIndex(
                name: "IX_Caso_CodigoCliente",
                table: "Caso",
                column: "CodigoCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Caso_Cliente_CodigoCliente",
                table: "Caso",
                column: "CodigoCliente",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caso_Cliente_CodigoCliente",
                table: "Caso");

            migrationBuilder.DropIndex(
                name: "IX_Caso_CodigoCliente",
                table: "Caso");

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Caso",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Caso_ClienteId",
                table: "Caso",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caso_Cliente_ClienteId",
                table: "Caso",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id");
        }
    }
}
