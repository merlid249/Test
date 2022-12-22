using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftExpresTestMVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emertimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Njesia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatasKdences = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cmimi = table.Column<double>(type: "float", nullable: false),
                    Lloji = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KaTvsh = table.Column<bool>(type: "bit", nullable: false),
                    Tipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barkod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatures", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fatures");
        }
    }
}
