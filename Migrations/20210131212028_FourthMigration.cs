using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "movies",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(160) CHARACTER SET utf8mb4",
                oldMaxLength: 160,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "movies",
                type: "varchar(160) CHARACTER SET utf8mb4",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
