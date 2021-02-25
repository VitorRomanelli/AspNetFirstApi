using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "movies",
                maxLength: 1200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500) CHARACTER SET utf8mb4",
                oldMaxLength: 500,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "movies",
                type: "varchar(500) CHARACTER SET utf8mb4",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1200,
                oldNullable: true);
        }
    }
}
