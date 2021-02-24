using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCoreProject_Arif.Data.Migrations
{
    public partial class mg3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fatherName",
                table: "AccountHolders",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fatherName",
                table: "AccountHolders");
        }
    }
}
