using Microsoft.EntityFrameworkCore.Migrations;

namespace Swordland.EFDataAccess.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BetId",
                table: "Challengers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Challengers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Challengers",
                newName: "StageName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StageName",
                table: "Challengers",
                newName: "LastName");

            migrationBuilder.AddColumn<int>(
                name: "BetId",
                table: "Challengers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Challengers",
                nullable: true);
        }
    }
}
