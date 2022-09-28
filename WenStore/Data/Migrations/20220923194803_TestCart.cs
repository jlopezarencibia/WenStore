using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WenStore.Data.Migrations
{
    public partial class TestCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    JobId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryJobId = table.Column<long>(type: "INTEGER", nullable: false),
                    Price = table.Column<float>(type: "REAL", nullable: false),
                    HasDelivery = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasPickUp = table.Column<bool>(type: "INTEGER", nullable: false),
                    PickUpLocation = table.Column<string>(type: "TEXT", nullable: false),
                    DeliversTo = table.Column<string>(type: "TEXT", nullable: false),
                    ImageRelativePath = table.Column<string>(type: "TEXT", nullable: false),
                    CartId = table.Column<long>(type: "INTEGER", nullable: true),
                    CartId1 = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "CartId");
                    table.ForeignKey(
                        name: "FK_Product_Carts_CartId1",
                        column: x => x.CartId1,
                        principalTable: "Carts",
                        principalColumn: "CartId");
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryJobId",
                        column: x => x.CategoryJobId,
                        principalTable: "Category",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CartId",
                table: "Product",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CartId1",
                table: "Product",
                column: "CartId1");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryJobId",
                table: "Product",
                column: "CategoryJobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
