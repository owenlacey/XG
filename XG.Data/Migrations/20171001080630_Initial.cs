using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace XG.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "XG");

            migrationBuilder.CreateTable(
                name: "Competitions",
                schema: "XG",
                columns: table => new
                {
                    CompetitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.CompetitionId);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                schema: "XG",
                columns: table => new
                {
                    MatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchId);
                });

            migrationBuilder.CreateTable(
                name: "Season",
                schema: "XG",
                columns: table => new
                {
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.SeasonId);
                });

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

            migrationBuilder.CreateTable(
                name: "CompetitionInstances",
                schema: "XG",
                columns: table => new
                {
                    CompetitionInstanceId = table.Column<int>(type: "int", nullable: false),
                    CompetitionId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionInstances", x => x.CompetitionInstanceId);
                    table.ForeignKey(
                        name: "FK_CompetitionInstances_Competitions_CompetitionInstanceId",
                        column: x => x.CompetitionInstanceId,
                        principalSchema: "XG",
                        principalTable: "Competitions",
                        principalColumn: "CompetitionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionInstances_Season_CompetitionInstanceId",
                        column: x => x.CompetitionInstanceId,
                        principalSchema: "XG",
                        principalTable: "Season",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamParticipations",
                schema: "XG",
                columns: table => new
                {
                    CompetitionParticipationId = table.Column<int>(type: "int", nullable: false),
                    CompetitionInstanceId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamParticipations", x => x.CompetitionParticipationId);
                    table.ForeignKey(
                        name: "FK_TeamParticipations_CompetitionInstances_CompetitionParticipationId",
                        column: x => x.CompetitionParticipationId,
                        principalSchema: "XG",
                        principalTable: "CompetitionInstances",
                        principalColumn: "CompetitionInstanceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamParticipations_Teams_CompetitionParticipationId",
                        column: x => x.CompetitionParticipationId,
                        principalSchema: "XG",
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches",
                schema: "XG");

            migrationBuilder.DropTable(
                name: "TeamParticipations",
                schema: "XG");

            migrationBuilder.DropTable(
                name: "CompetitionInstances",
                schema: "XG");

            migrationBuilder.DropTable(
                name: "Teams",
                schema: "XG");

            migrationBuilder.DropTable(
                name: "Competitions",
                schema: "XG");

            migrationBuilder.DropTable(
                name: "Season",
                schema: "XG");
        }
    }
}
