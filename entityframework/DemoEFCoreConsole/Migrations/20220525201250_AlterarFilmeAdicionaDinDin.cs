using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEFCoreConsole.Migrations
{
    public partial class AlterarFilmeAdicionaDinDin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DinDin",
                table: "Filmes",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DinDin",
                table: "Filmes");
        }
    }
}
