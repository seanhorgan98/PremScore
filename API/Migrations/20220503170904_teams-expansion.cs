using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class teamsexpansion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Points",
                table: "Teams",
                newName: "TotalWon");

            migrationBuilder.AddColumn<int>(
                name: "LeaguePosition",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeasonDrawn",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeasonGoalDifference",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeasonGoalsAgainst",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeasonGoalsFor",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeasonLost",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeasonPlayed",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeasonPoints",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeasonWon",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalDrawn",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalGoalDifference",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalGoalsAgainst",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalGoalsFor",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalLost",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPlayed",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPoints",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeaguePosition",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SeasonDrawn",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SeasonGoalDifference",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SeasonGoalsAgainst",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SeasonGoalsFor",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SeasonLost",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SeasonPlayed",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SeasonPoints",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SeasonWon",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TotalDrawn",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TotalGoalDifference",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TotalGoalsAgainst",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TotalGoalsFor",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TotalLost",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TotalPlayed",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TotalPoints",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "TotalWon",
                table: "Teams",
                newName: "Points");
        }
    }
}
