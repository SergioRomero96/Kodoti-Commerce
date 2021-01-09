using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 393m },
                    { 73, "Description for product 73", "Product 73", 453m },
                    { 72, "Description for product 72", "Product 72", 979m },
                    { 71, "Description for product 71", "Product 71", 547m },
                    { 70, "Description for product 70", "Product 70", 763m },
                    { 69, "Description for product 69", "Product 69", 122m },
                    { 68, "Description for product 68", "Product 68", 747m },
                    { 67, "Description for product 67", "Product 67", 676m },
                    { 66, "Description for product 66", "Product 66", 815m },
                    { 65, "Description for product 65", "Product 65", 569m },
                    { 64, "Description for product 64", "Product 64", 886m },
                    { 63, "Description for product 63", "Product 63", 131m },
                    { 62, "Description for product 62", "Product 62", 375m },
                    { 61, "Description for product 61", "Product 61", 213m },
                    { 60, "Description for product 60", "Product 60", 507m },
                    { 59, "Description for product 59", "Product 59", 388m },
                    { 58, "Description for product 58", "Product 58", 204m },
                    { 57, "Description for product 57", "Product 57", 539m },
                    { 56, "Description for product 56", "Product 56", 604m },
                    { 55, "Description for product 55", "Product 55", 635m },
                    { 54, "Description for product 54", "Product 54", 451m },
                    { 53, "Description for product 53", "Product 53", 180m },
                    { 74, "Description for product 74", "Product 74", 462m },
                    { 52, "Description for product 52", "Product 52", 485m },
                    { 75, "Description for product 75", "Product 75", 716m },
                    { 77, "Description for product 77", "Product 77", 852m },
                    { 98, "Description for product 98", "Product 98", 150m },
                    { 97, "Description for product 97", "Product 97", 363m },
                    { 96, "Description for product 96", "Product 96", 660m },
                    { 95, "Description for product 95", "Product 95", 852m },
                    { 94, "Description for product 94", "Product 94", 721m },
                    { 93, "Description for product 93", "Product 93", 541m },
                    { 92, "Description for product 92", "Product 92", 438m },
                    { 91, "Description for product 91", "Product 91", 808m },
                    { 90, "Description for product 90", "Product 90", 640m },
                    { 89, "Description for product 89", "Product 89", 339m },
                    { 88, "Description for product 88", "Product 88", 825m },
                    { 87, "Description for product 87", "Product 87", 975m },
                    { 86, "Description for product 86", "Product 86", 176m },
                    { 85, "Description for product 85", "Product 85", 507m },
                    { 84, "Description for product 84", "Product 84", 468m },
                    { 83, "Description for product 83", "Product 83", 357m },
                    { 82, "Description for product 82", "Product 82", 269m },
                    { 81, "Description for product 81", "Product 81", 477m },
                    { 80, "Description for product 80", "Product 80", 295m },
                    { 79, "Description for product 79", "Product 79", 440m },
                    { 78, "Description for product 78", "Product 78", 572m },
                    { 76, "Description for product 76", "Product 76", 432m },
                    { 51, "Description for product 51", "Product 51", 576m },
                    { 50, "Description for product 50", "Product 50", 524m },
                    { 49, "Description for product 49", "Product 49", 760m },
                    { 22, "Description for product 22", "Product 22", 789m },
                    { 21, "Description for product 21", "Product 21", 727m },
                    { 20, "Description for product 20", "Product 20", 652m },
                    { 19, "Description for product 19", "Product 19", 428m },
                    { 18, "Description for product 18", "Product 18", 583m },
                    { 17, "Description for product 17", "Product 17", 809m },
                    { 16, "Description for product 16", "Product 16", 990m },
                    { 15, "Description for product 15", "Product 15", 111m },
                    { 14, "Description for product 14", "Product 14", 267m },
                    { 13, "Description for product 13", "Product 13", 622m },
                    { 12, "Description for product 12", "Product 12", 854m },
                    { 11, "Description for product 11", "Product 11", 870m },
                    { 10, "Description for product 10", "Product 10", 131m },
                    { 9, "Description for product 9", "Product 9", 871m },
                    { 8, "Description for product 8", "Product 8", 924m },
                    { 7, "Description for product 7", "Product 7", 394m },
                    { 6, "Description for product 6", "Product 6", 634m },
                    { 5, "Description for product 5", "Product 5", 192m },
                    { 4, "Description for product 4", "Product 4", 220m },
                    { 3, "Description for product 3", "Product 3", 359m },
                    { 2, "Description for product 2", "Product 2", 100m },
                    { 23, "Description for product 23", "Product 23", 560m },
                    { 24, "Description for product 24", "Product 24", 255m },
                    { 25, "Description for product 25", "Product 25", 832m },
                    { 26, "Description for product 26", "Product 26", 684m },
                    { 48, "Description for product 48", "Product 48", 350m },
                    { 47, "Description for product 47", "Product 47", 306m },
                    { 46, "Description for product 46", "Product 46", 636m },
                    { 45, "Description for product 45", "Product 45", 814m },
                    { 44, "Description for product 44", "Product 44", 988m },
                    { 43, "Description for product 43", "Product 43", 936m },
                    { 42, "Description for product 42", "Product 42", 394m },
                    { 41, "Description for product 41", "Product 41", 936m },
                    { 40, "Description for product 40", "Product 40", 966m },
                    { 39, "Description for product 39", "Product 39", 229m },
                    { 99, "Description for product 99", "Product 99", 519m },
                    { 38, "Description for product 38", "Product 38", 829m },
                    { 36, "Description for product 36", "Product 36", 348m },
                    { 35, "Description for product 35", "Product 35", 244m },
                    { 34, "Description for product 34", "Product 34", 874m },
                    { 33, "Description for product 33", "Product 33", 277m },
                    { 32, "Description for product 32", "Product 32", 155m },
                    { 31, "Description for product 31", "Product 31", 562m },
                    { 30, "Description for product 30", "Product 30", 984m },
                    { 29, "Description for product 29", "Product 29", 893m },
                    { 28, "Description for product 28", "Product 28", 118m },
                    { 27, "Description for product 27", "Product 27", 520m },
                    { 37, "Description for product 37", "Product 37", 543m },
                    { 100, "Description for product 100", "Product 100", 999m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 18 },
                    { 73, 73, 53 },
                    { 72, 72, 32 },
                    { 71, 71, 69 },
                    { 70, 70, 5 },
                    { 69, 69, 76 },
                    { 68, 68, 81 },
                    { 67, 67, 52 },
                    { 66, 66, 16 },
                    { 65, 65, 83 },
                    { 64, 64, 33 },
                    { 63, 63, 59 },
                    { 62, 62, 72 },
                    { 61, 61, 68 },
                    { 60, 60, 30 },
                    { 59, 59, 16 },
                    { 58, 58, 98 },
                    { 57, 57, 92 },
                    { 56, 56, 95 },
                    { 55, 55, 94 },
                    { 54, 54, 38 },
                    { 53, 53, 81 },
                    { 74, 74, 27 },
                    { 52, 52, 31 },
                    { 75, 75, 85 },
                    { 77, 77, 1 },
                    { 98, 98, 87 },
                    { 97, 97, 67 },
                    { 96, 96, 29 },
                    { 95, 95, 44 },
                    { 94, 94, 65 },
                    { 93, 93, 59 },
                    { 92, 92, 20 },
                    { 91, 91, 91 },
                    { 90, 90, 6 },
                    { 89, 89, 61 },
                    { 88, 88, 31 },
                    { 87, 87, 71 },
                    { 86, 86, 7 },
                    { 85, 85, 59 },
                    { 84, 84, 57 },
                    { 83, 83, 87 },
                    { 82, 82, 26 },
                    { 81, 81, 77 },
                    { 80, 80, 81 },
                    { 79, 79, 20 },
                    { 78, 78, 1 },
                    { 76, 76, 73 },
                    { 51, 51, 60 },
                    { 50, 50, 2 },
                    { 49, 49, 90 },
                    { 22, 22, 22 },
                    { 21, 21, 99 },
                    { 20, 20, 87 },
                    { 19, 19, 40 },
                    { 18, 18, 49 },
                    { 17, 17, 8 },
                    { 16, 16, 89 },
                    { 15, 15, 89 },
                    { 14, 14, 78 },
                    { 13, 13, 37 },
                    { 12, 12, 21 },
                    { 11, 11, 69 },
                    { 10, 10, 22 },
                    { 9, 9, 53 },
                    { 8, 8, 19 },
                    { 7, 7, 49 },
                    { 6, 6, 72 },
                    { 5, 5, 66 },
                    { 4, 4, 24 },
                    { 3, 3, 72 },
                    { 2, 2, 80 },
                    { 23, 23, 88 },
                    { 24, 24, 73 },
                    { 25, 25, 8 },
                    { 26, 26, 36 },
                    { 48, 48, 76 },
                    { 47, 47, 59 },
                    { 46, 46, 27 },
                    { 45, 45, 52 },
                    { 44, 44, 86 },
                    { 43, 43, 21 },
                    { 42, 42, 26 },
                    { 41, 41, 1 },
                    { 40, 40, 12 },
                    { 39, 39, 95 },
                    { 99, 99, 2 },
                    { 38, 38, 75 },
                    { 36, 36, 83 },
                    { 35, 35, 2 },
                    { 34, 34, 56 },
                    { 33, 33, 69 },
                    { 32, 32, 53 },
                    { 31, 31, 38 },
                    { 30, 30, 20 },
                    { 29, 29, 60 },
                    { 28, 28, 77 },
                    { 27, 27, 3 },
                    { 37, 37, 19 },
                    { 100, 100, 36 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
