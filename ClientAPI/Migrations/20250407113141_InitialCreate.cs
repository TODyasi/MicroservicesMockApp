using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClientAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientIDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "ClientAddress", "ClientCity", "ClientEmailAddress", "ClientFirstName", "ClientGender", "ClientIDNumber", "ClientLastName", "ClientPhoneNumber" },
                values: new object[,]
                {
                    { new Guid("a1f1c1b1-d1e1-4f11-b1c1-001100110011"), "123 Main Road", "Cape Town", "ayanda.mokoena@example.com", "Ayanda", "Female", "9001014800087", "Mokoena", "0821234567" },
                    { new Guid("a2f2c2b2-d2e2-4f22-b2c2-002200220022"), "45 Long Street", "Cape Town", "thabo.nkosi@example.com", "Thabo", "Male", "8802035800089", "Nkosi", "0732345678" },
                    { new Guid("a3f3c3b3-d3e3-4f33-b3c3-003300330033"), "89 Victoria Road", "Cape Town", "naledi.dlamini@example.com", "Naledi", "Female", "9503214800081", "Dlamini", "0613456789" },
                    { new Guid("a4f4c4b4-d4e4-4f44-b4c4-004400440044"), "22 Nelson Street", "Cape Town", "sibusiso.zulu@example.com", "Sibusiso", "Male", "9205145800084", "Zulu", "0744567890" },
                    { new Guid("a5f5c5b5-d5e5-4f55-b5c5-005500550055"), "55 Beach Road", "Cape Town", "zanele.khumalo@example.com", "Zanele", "Female", "8707084800086", "Khumalo", "0835678901" },
                    { new Guid("a6f6c6b6-d6e6-4f66-b6c6-006600660066"), "14 Mountain View", "Cape Town", "mandla.mbatha@example.com", "Mandla", "Male", "9109025800080", "Mbatha", "0726789012" },
                    { new Guid("a7f7c7b7-d7e7-4f77-b7c7-007700770077"), "67 Rose Street", "Cape Town", "lerato.pule@example.com", "Lerato", "Female", "9601044800083", "Pule", "0617890123" },
                    { new Guid("a8f8c8b8-d8e8-4f88-b8c8-008800880088"), "90 Hilltop Drive", "Cape Town", "sipho.ngcobo@example.com", "Sipho", "Male", "9303025800085", "Ngcobo", "0848901234" },
                    { new Guid("a9f9c9b9-d9e9-4f99-b9c9-009900990099"), "101 Sunset Avenue", "Cape Town", "boitumelo.mahlangu@example.com", "Boitumelo", "Female", "9406154800088", "Mahlangu", "0609012345" },
                    { new Guid("aa00c0b0-d0e0-4f00-b0c0-000000000000"), "33 Palm Street", "Cape Town", "kagiso.radebe@example.com", "Kagiso", "Male", "8911205800082", "Radebe", "0710123456" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
