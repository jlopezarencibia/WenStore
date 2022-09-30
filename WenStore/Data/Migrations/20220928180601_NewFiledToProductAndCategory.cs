using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WenStore.Data.Migrations
{
    public partial class NewFiledToProductAndCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "DealPrice",
                table: "STORE.Products",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "STORE.Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DealPrice",
                table: "STORE.Products");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "STORE.Products");
        }
    }
}
