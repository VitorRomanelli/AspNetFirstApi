using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "path",
                table: "Image");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Image",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Image");

            migrationBuilder.AddColumn<string>(
                name: "path",
                table: "Image",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
