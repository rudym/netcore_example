using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace VehWebApp.Migrations
{
    public partial class VehiclesEntityInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(nullable: false),
                    Code = table.Column<string>(type: "varchar(200)", nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", nullable: true),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    used_car = table.Column<bool>(nullable: false),
                    Kilometres = table.Column<int>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Vehicle");
        }
    }
}
