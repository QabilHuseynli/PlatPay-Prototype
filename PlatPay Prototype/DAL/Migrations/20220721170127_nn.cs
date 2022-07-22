using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PlatPay_Prototype.DAL.Migrations
{
    public partial class nn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirsName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Pin = table.Column<string>(type: "text", nullable: false),
                    CardId = table.Column<string>(type: "text", nullable: false),
                    Cvv = table.Column<string>(type: "text", nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Balance = table.Column<double>(type: "double precision", nullable: false),
                    CreadtedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Edvs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EdvAmount = table.Column<double>(type: "double precision", nullable: false),
                    BankCardId = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edvs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Edvs_BankCards_BankCardId",
                        column: x => x.BankCardId,
                        principalTable: "BankCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Edvs_BankCardId",
                table: "Edvs",
                column: "BankCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Edvs");

            migrationBuilder.DropTable(
                name: "BankCards");
        }
    }
}
