using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WenStore.Data.Migrations
{
    public partial class AddinitialEntitiesWithoutRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "STORE.AmazonProducts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    Deal = table.Column<bool>(type: "INTEGER", nullable: false),
                    ImageRelativePath = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.AmazonProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STORE.Carts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STORE.Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STORE.Comments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STORE.ContactsInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhoneNumber1 = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "TEXT", nullable: false),
                    Address1 = table.Column<string>(type: "TEXT", nullable: false),
                    Address2 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.ContactsInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STORE.Saves",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.Saves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STORE.SocialUrls",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.SocialUrls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STORE.Rates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    CommentId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.Rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_STORE.Rates_STORE.Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "STORE.Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "STORE.Jobs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Salary = table.Column<string>(type: "TEXT", nullable: false),
                    Frequency = table.Column<string>(type: "TEXT", nullable: false),
                    ContactInformationId = table.Column<int>(type: "INTEGER", nullable: false),
                    SavedId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_STORE.Jobs_STORE.ContactsInformation_ContactInformationId",
                        column: x => x.ContactInformationId,
                        principalTable: "STORE.ContactsInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_STORE.Jobs_STORE.Saves_SavedId",
                        column: x => x.SavedId,
                        principalTable: "STORE.Saves",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "STORE.OpenForWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    PreferredHours = table.Column<string>(type: "TEXT", nullable: false),
                    WorkAuthorization = table.Column<string>(type: "TEXT", nullable: false),
                    PreferredPaymentType = table.Column<string>(type: "TEXT", nullable: false),
                    PreferredDays = table.Column<string>(type: "TEXT", nullable: false),
                    SavedId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.OpenForWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_STORE.OpenForWorks_STORE.Saves_SavedId",
                        column: x => x.SavedId,
                        principalTable: "STORE.Saves",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "STORE.Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<long>(type: "INTEGER", nullable: false),
                    Price = table.Column<float>(type: "REAL", nullable: false),
                    HasDelivery = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasPickUp = table.Column<bool>(type: "INTEGER", nullable: false),
                    PickUpLocation = table.Column<string>(type: "TEXT", nullable: false),
                    DeliversTo = table.Column<string>(type: "TEXT", nullable: false),
                    ImageRelativePath = table.Column<string>(type: "TEXT", nullable: false),
                    CartId = table.Column<long>(type: "INTEGER", nullable: true),
                    CartId1 = table.Column<long>(type: "INTEGER", nullable: true),
                    SavedId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_STORE.Products_STORE.Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "STORE.Carts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_STORE.Products_STORE.Carts_CartId1",
                        column: x => x.CartId1,
                        principalTable: "STORE.Carts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_STORE.Products_STORE.Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "STORE.Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_STORE.Products_STORE.Saves_SavedId",
                        column: x => x.SavedId,
                        principalTable: "STORE.Saves",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "STORE.Services",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    SocialUrlId = table.Column<long>(type: "INTEGER", nullable: false),
                    SavedId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_STORE.Services_STORE.Saves_SavedId",
                        column: x => x.SavedId,
                        principalTable: "STORE.Saves",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_STORE.Services_STORE.SocialUrls_SocialUrlId",
                        column: x => x.SocialUrlId,
                        principalTable: "STORE.SocialUrls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "STORE.Skills",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Score = table.Column<string>(type: "TEXT", nullable: false),
                    OpenForWorkId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORE.Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_STORE.Skills_STORE.OpenForWorks_OpenForWorkId",
                        column: x => x.OpenForWorkId,
                        principalTable: "STORE.OpenForWorks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Jobs_ContactInformationId",
                table: "STORE.Jobs",
                column: "ContactInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Jobs_SavedId",
                table: "STORE.Jobs",
                column: "SavedId");

            migrationBuilder.CreateIndex(
                name: "IX_STORE.OpenForWorks_SavedId",
                table: "STORE.OpenForWorks",
                column: "SavedId");

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Products_CartId",
                table: "STORE.Products",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Products_CartId1",
                table: "STORE.Products",
                column: "CartId1");

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Products_CategoryId",
                table: "STORE.Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Products_SavedId",
                table: "STORE.Products",
                column: "SavedId");

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Rates_CommentId",
                table: "STORE.Rates",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Services_SavedId",
                table: "STORE.Services",
                column: "SavedId");

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Services_SocialUrlId",
                table: "STORE.Services",
                column: "SocialUrlId");

            migrationBuilder.CreateIndex(
                name: "IX_STORE.Skills_OpenForWorkId",
                table: "STORE.Skills",
                column: "OpenForWorkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "STORE.AmazonProducts");

            migrationBuilder.DropTable(
                name: "STORE.Jobs");

            migrationBuilder.DropTable(
                name: "STORE.Products");

            migrationBuilder.DropTable(
                name: "STORE.Rates");

            migrationBuilder.DropTable(
                name: "STORE.Services");

            migrationBuilder.DropTable(
                name: "STORE.Skills");

            migrationBuilder.DropTable(
                name: "STORE.ContactsInformation");

            migrationBuilder.DropTable(
                name: "STORE.Carts");

            migrationBuilder.DropTable(
                name: "STORE.Categories");

            migrationBuilder.DropTable(
                name: "STORE.Comments");

            migrationBuilder.DropTable(
                name: "STORE.SocialUrls");

            migrationBuilder.DropTable(
                name: "STORE.OpenForWorks");

            migrationBuilder.DropTable(
                name: "STORE.Saves");
        }
    }
}
