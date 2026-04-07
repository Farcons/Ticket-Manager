using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketManager.Migrations
{
    /// <inheritdoc />
    public partial class AlterTempoDecorridoToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Converte os valores decimais existentes (ex: 1.5) para formato HH:MM (ex: "01:30")
            migrationBuilder.Sql("""
                UPDATE Caso
                SET TempoDecorrido =
                    PRINTF('%02d:%02d',
                        CAST(TempoDecorrido AS INTEGER),
                        CAST((TempoDecorrido - CAST(TempoDecorrido AS INTEGER)) * 60 AS INTEGER))
                WHERE TempoDecorrido IS NOT NULL
                  AND TempoDecorrido NOT LIKE '%:%';
                """);

            migrationBuilder.AlterColumn<string>(
                name: "TempoDecorrido",
                table: "Caso",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TempoDecorrido",
                table: "Caso",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
