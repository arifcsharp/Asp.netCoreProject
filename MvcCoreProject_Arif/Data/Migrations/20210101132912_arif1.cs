using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCoreProject_Arif.Data.Migrations
{
    public partial class arif1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeName = table.Column<string>(maxLength: 100, nullable: false),
                    Qualification = table.Column<string>(maxLength: 100, nullable: false),
                    Experience = table.Column<int>(maxLength: 100, nullable: false),
                    JoiningDate = table.Column<DateTime>(nullable: false),
                    ResignDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(maxLength: 255, nullable: false),
                    ProfilePicture = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
