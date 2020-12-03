using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Claro.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mobile",
                columns: table => new
                {
                    Code = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "varchar(200)", nullable: true),
                    Brand = table.Column<string>(type: "varchar(200)", nullable: true),
                    Date = table.Column<string>(type: "varchar(10)", nullable: true),
                    Photo = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobile", x => x.Code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mobile");
        }
    }
}
