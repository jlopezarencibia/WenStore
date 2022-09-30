using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WenStore.Data.Migrations
{
    public partial class IsDeletedForProductAndCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "CategoryId",
                table: "STORE.Products",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "STORE.Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "BackgroundColor",
                table: "STORE.Categories",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundImageRelativePath",
                table: "STORE.Categories",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "STORE.Categories",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "STORE.AmazonProducts",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "STORE.Products");

            migrationBuilder.DropColumn(
                name: "BackgroundColor",
                table: "STORE.Categories");

            migrationBuilder.DropColumn(
                name: "BackgroundImageRelativePath",
                table: "STORE.Categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "STORE.Categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "STORE.AmazonProducts");

            migrationBuilder.AlterColumn<double>(
                name: "CategoryId",
                table: "STORE.Products",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");
        }
    }
}
