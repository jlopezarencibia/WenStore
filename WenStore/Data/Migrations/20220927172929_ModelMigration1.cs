using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WenStore.Data.Migrations
{
    public partial class ModelMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STORE.Products_STORE.Carts_CartId1",
                table: "STORE.Products");

            migrationBuilder.DropForeignKey(
                name: "FK_STORE.Products_STORE.Categories_CategoryId",
                table: "STORE.Products");

            migrationBuilder.DropIndex(
                name: "IX_STORE.Products_CartId1",
                table: "STORE.Products");

            migrationBuilder.DropIndex(
                name: "IX_STORE.Products_CategoryId",
                table: "STORE.Products");

            migrationBuilder.DropColumn(
                name: "CartId1",
                table: "STORE.Products");

            migrationBuilder.AlterColumn<double>(
                name: "CategoryId",
                table: "STORE.Products",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "STORE.Carts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "CartId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Products_Name",
                table: "STORE.Products",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CartId",
                table: "AspNetUsers",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_STORE.Carts_CartId",
                table: "AspNetUsers",
                column: "CartId",
                principalTable: "STORE.Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_STORE.Carts_CartId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_STORE.Products_Name",
                table: "STORE.Products");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CartId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "STORE.Carts");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<long>(
                name: "CategoryId",
                table: "STORE.Products",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddColumn<long>(
                name: "CartId1",
                table: "STORE.Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Products_CartId1",
                table: "STORE.Products",
                column: "CartId1");

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Products_CategoryId",
                table: "STORE.Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_STORE.Products_STORE.Carts_CartId1",
                table: "STORE.Products",
                column: "CartId1",
                principalTable: "STORE.Carts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_STORE.Products_STORE.Categories_CategoryId",
                table: "STORE.Products",
                column: "CategoryId",
                principalTable: "STORE.Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
