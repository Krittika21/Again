using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TestDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TestDate = table.Column<DateTime>(nullable: false),
                    TestTypeID = table.Column<int>(nullable: true),
                    NoOfParticipants = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TestDetails_TestType_TestTypeID",
                        column: x => x.TestTypeID,
                        principalTable: "TestType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AthletesDetails",
                columns: table => new
                {
                    AthleteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    STTime = table.Column<DateTime>(nullable: false),
                    CTDistance = table.Column<double>(nullable: false),
                    FitnessRating = table.Column<string>(nullable: true),
                    TestDetailsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AthletesDetails", x => x.AthleteId);
                    table.ForeignKey(
                        name: "FK_AthletesDetails_TestDetails_TestDetailsID",
                        column: x => x.TestDetailsID,
                        principalTable: "TestDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AthletesDetails_TestDetailsID",
                table: "AthletesDetails",
                column: "TestDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_TestDetails_TestTypeID",
                table: "TestDetails",
                column: "TestTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AthletesDetails");

            migrationBuilder.DropTable(
                name: "TestDetails");

            migrationBuilder.DropTable(
                name: "TestType");
        }
    }
}
