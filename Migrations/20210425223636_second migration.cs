using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjecttManager.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "projectId",
                table: "Projects",
                newName: "ProjectId");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Utilisateurs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Utilisateurs");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Projects",
                newName: "projectId");
        }
    }
}
