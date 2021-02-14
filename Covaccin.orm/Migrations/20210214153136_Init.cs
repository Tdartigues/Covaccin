using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Covaccin.orm.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Prenom = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Sexe = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EstResident_pasPersonnel = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeVaccins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vaccin = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeVaccins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Injections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPersonne = table.Column<int>(type: "INTEGER", nullable: false),
                    IdType = table.Column<int>(type: "INTEGER", nullable: false),
                    Prenom = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Marque = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    IdLot = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonneId = table.Column<int>(type: "INTEGER", nullable: true),
                    TypeVaccinId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Injections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Injections_Personnes_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Injections_TypeVaccins_TypeVaccinId",
                        column: x => x.TypeVaccinId,
                        principalTable: "TypeVaccins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Injections_PersonneId",
                table: "Injections",
                column: "PersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Injections_TypeVaccinId",
                table: "Injections",
                column: "TypeVaccinId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Injections");

            migrationBuilder.DropTable(
                name: "Personnes");

            migrationBuilder.DropTable(
                name: "TypeVaccins");
        }
    }
}
