using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace XG.Data.Migrations
{
    public partial class TeamEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competitions_Seasons_SeasonId",
                schema: "XG",
                table: "Competitions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seasons",
                schema: "XG",
                table: "Seasons");

            migrationBuilder.RenameTable(
                name: "Seasons",
                schema: "XG",
                newName: "Season");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Season",
                schema: "XG",
                table: "Season",
                column: "SeasonId");

            migrationBuilder.CreateTable(
                name: "Teams",
                schema: "XG",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Competitions_Season_SeasonId",
                schema: "XG",
                table: "Competitions",
                column: "SeasonId",
                principalSchema: "XG",
                principalTable: "Season",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competitions_Season_SeasonId",
                schema: "XG",
                table: "Competitions");

            migrationBuilder.DropTable(
                name: "Teams",
                schema: "XG");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Season",
                schema: "XG",
                table: "Season");

            migrationBuilder.RenameTable(
                name: "Season",
                schema: "XG",
                newName: "Seasons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seasons",
                schema: "XG",
                table: "Seasons",
                column: "SeasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Competitions_Seasons_SeasonId",
                schema: "XG",
                table: "Competitions",
                column: "SeasonId",
                principalSchema: "XG",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
