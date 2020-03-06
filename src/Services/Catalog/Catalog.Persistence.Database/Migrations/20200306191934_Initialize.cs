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
                    { 1, "Description for product 1", "Product 1", 231m },
                    { 73, "Description for product 73", "Product 73", 160m },
                    { 72, "Description for product 72", "Product 72", 737m },
                    { 71, "Description for product 71", "Product 71", 623m },
                    { 70, "Description for product 70", "Product 70", 664m },
                    { 69, "Description for product 69", "Product 69", 411m },
                    { 68, "Description for product 68", "Product 68", 300m },
                    { 67, "Description for product 67", "Product 67", 842m },
                    { 66, "Description for product 66", "Product 66", 342m },
                    { 65, "Description for product 65", "Product 65", 531m },
                    { 64, "Description for product 64", "Product 64", 798m },
                    { 63, "Description for product 63", "Product 63", 708m },
                    { 62, "Description for product 62", "Product 62", 473m },
                    { 61, "Description for product 61", "Product 61", 610m },
                    { 60, "Description for product 60", "Product 60", 183m },
                    { 59, "Description for product 59", "Product 59", 854m },
                    { 58, "Description for product 58", "Product 58", 259m },
                    { 57, "Description for product 57", "Product 57", 721m },
                    { 56, "Description for product 56", "Product 56", 476m },
                    { 55, "Description for product 55", "Product 55", 898m },
                    { 54, "Description for product 54", "Product 54", 716m },
                    { 53, "Description for product 53", "Product 53", 430m },
                    { 74, "Description for product 74", "Product 74", 186m },
                    { 52, "Description for product 52", "Product 52", 117m },
                    { 75, "Description for product 75", "Product 75", 283m },
                    { 77, "Description for product 77", "Product 77", 639m },
                    { 98, "Description for product 98", "Product 98", 416m },
                    { 97, "Description for product 97", "Product 97", 101m },
                    { 96, "Description for product 96", "Product 96", 517m },
                    { 95, "Description for product 95", "Product 95", 197m },
                    { 94, "Description for product 94", "Product 94", 168m },
                    { 93, "Description for product 93", "Product 93", 286m },
                    { 92, "Description for product 92", "Product 92", 596m },
                    { 91, "Description for product 91", "Product 91", 507m },
                    { 90, "Description for product 90", "Product 90", 868m },
                    { 89, "Description for product 89", "Product 89", 764m },
                    { 88, "Description for product 88", "Product 88", 867m },
                    { 87, "Description for product 87", "Product 87", 550m },
                    { 86, "Description for product 86", "Product 86", 996m },
                    { 85, "Description for product 85", "Product 85", 926m },
                    { 84, "Description for product 84", "Product 84", 175m },
                    { 83, "Description for product 83", "Product 83", 597m },
                    { 82, "Description for product 82", "Product 82", 427m },
                    { 81, "Description for product 81", "Product 81", 256m },
                    { 80, "Description for product 80", "Product 80", 657m },
                    { 79, "Description for product 79", "Product 79", 186m },
                    { 78, "Description for product 78", "Product 78", 950m },
                    { 76, "Description for product 76", "Product 76", 843m },
                    { 51, "Description for product 51", "Product 51", 637m },
                    { 50, "Description for product 50", "Product 50", 993m },
                    { 49, "Description for product 49", "Product 49", 677m },
                    { 22, "Description for product 22", "Product 22", 754m },
                    { 21, "Description for product 21", "Product 21", 553m },
                    { 20, "Description for product 20", "Product 20", 174m },
                    { 19, "Description for product 19", "Product 19", 795m },
                    { 18, "Description for product 18", "Product 18", 311m },
                    { 17, "Description for product 17", "Product 17", 778m },
                    { 16, "Description for product 16", "Product 16", 378m },
                    { 15, "Description for product 15", "Product 15", 793m },
                    { 14, "Description for product 14", "Product 14", 656m },
                    { 13, "Description for product 13", "Product 13", 862m },
                    { 12, "Description for product 12", "Product 12", 427m },
                    { 11, "Description for product 11", "Product 11", 223m },
                    { 10, "Description for product 10", "Product 10", 545m },
                    { 9, "Description for product 9", "Product 9", 362m },
                    { 8, "Description for product 8", "Product 8", 777m },
                    { 7, "Description for product 7", "Product 7", 647m },
                    { 6, "Description for product 6", "Product 6", 331m },
                    { 5, "Description for product 5", "Product 5", 897m },
                    { 4, "Description for product 4", "Product 4", 358m },
                    { 3, "Description for product 3", "Product 3", 132m },
                    { 2, "Description for product 2", "Product 2", 966m },
                    { 23, "Description for product 23", "Product 23", 344m },
                    { 24, "Description for product 24", "Product 24", 872m },
                    { 25, "Description for product 25", "Product 25", 504m },
                    { 26, "Description for product 26", "Product 26", 813m },
                    { 48, "Description for product 48", "Product 48", 392m },
                    { 47, "Description for product 47", "Product 47", 657m },
                    { 46, "Description for product 46", "Product 46", 846m },
                    { 45, "Description for product 45", "Product 45", 785m },
                    { 44, "Description for product 44", "Product 44", 393m },
                    { 43, "Description for product 43", "Product 43", 215m },
                    { 42, "Description for product 42", "Product 42", 710m },
                    { 41, "Description for product 41", "Product 41", 891m },
                    { 40, "Description for product 40", "Product 40", 708m },
                    { 39, "Description for product 39", "Product 39", 251m },
                    { 99, "Description for product 99", "Product 99", 861m },
                    { 38, "Description for product 38", "Product 38", 141m },
                    { 36, "Description for product 36", "Product 36", 228m },
                    { 35, "Description for product 35", "Product 35", 344m },
                    { 34, "Description for product 34", "Product 34", 662m },
                    { 33, "Description for product 33", "Product 33", 584m },
                    { 32, "Description for product 32", "Product 32", 881m },
                    { 31, "Description for product 31", "Product 31", 113m },
                    { 30, "Description for product 30", "Product 30", 563m },
                    { 29, "Description for product 29", "Product 29", 169m },
                    { 28, "Description for product 28", "Product 28", 274m },
                    { 27, "Description for product 27", "Product 27", 720m },
                    { 37, "Description for product 37", "Product 37", 755m },
                    { 100, "Description for product 100", "Product 100", 542m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 19 },
                    { 73, 73, 79 },
                    { 72, 72, 60 },
                    { 71, 71, 10 },
                    { 70, 70, 53 },
                    { 69, 69, 53 },
                    { 68, 68, 61 },
                    { 67, 67, 69 },
                    { 66, 66, 43 },
                    { 65, 65, 73 },
                    { 64, 64, 30 },
                    { 63, 63, 28 },
                    { 62, 62, 23 },
                    { 61, 61, 30 },
                    { 60, 60, 98 },
                    { 59, 59, 20 },
                    { 58, 58, 17 },
                    { 57, 57, 41 },
                    { 56, 56, 68 },
                    { 55, 55, 9 },
                    { 54, 54, 11 },
                    { 53, 53, 98 },
                    { 74, 74, 12 },
                    { 52, 52, 4 },
                    { 75, 75, 20 },
                    { 77, 77, 11 },
                    { 98, 98, 8 },
                    { 97, 97, 40 },
                    { 96, 96, 38 },
                    { 95, 95, 80 },
                    { 94, 94, 43 },
                    { 93, 93, 22 },
                    { 92, 92, 80 },
                    { 91, 91, 44 },
                    { 90, 90, 38 },
                    { 89, 89, 72 },
                    { 88, 88, 28 },
                    { 87, 87, 7 },
                    { 86, 86, 3 },
                    { 85, 85, 60 },
                    { 84, 84, 58 },
                    { 83, 83, 15 },
                    { 82, 82, 12 },
                    { 81, 81, 51 },
                    { 80, 80, 88 },
                    { 79, 79, 93 },
                    { 78, 78, 62 },
                    { 76, 76, 79 },
                    { 51, 51, 41 },
                    { 50, 50, 25 },
                    { 49, 49, 87 },
                    { 22, 22, 50 },
                    { 21, 21, 48 },
                    { 20, 20, 82 },
                    { 19, 19, 23 },
                    { 18, 18, 21 },
                    { 17, 17, 4 },
                    { 16, 16, 8 },
                    { 15, 15, 40 },
                    { 14, 14, 60 },
                    { 13, 13, 43 },
                    { 12, 12, 9 },
                    { 11, 11, 50 },
                    { 10, 10, 81 },
                    { 9, 9, 31 },
                    { 8, 8, 11 },
                    { 7, 7, 26 },
                    { 6, 6, 86 },
                    { 5, 5, 73 },
                    { 4, 4, 98 },
                    { 3, 3, 6 },
                    { 2, 2, 55 },
                    { 23, 23, 13 },
                    { 24, 24, 89 },
                    { 25, 25, 77 },
                    { 26, 26, 75 },
                    { 48, 48, 44 },
                    { 47, 47, 23 },
                    { 46, 46, 88 },
                    { 45, 45, 95 },
                    { 44, 44, 50 },
                    { 43, 43, 38 },
                    { 42, 42, 68 },
                    { 41, 41, 61 },
                    { 40, 40, 11 },
                    { 39, 39, 41 },
                    { 99, 99, 77 },
                    { 38, 38, 43 },
                    { 36, 36, 86 },
                    { 35, 35, 6 },
                    { 34, 34, 82 },
                    { 33, 33, 39 },
                    { 32, 32, 6 },
                    { 31, 31, 8 },
                    { 30, 30, 1 },
                    { 29, 29, 83 },
                    { 28, 28, 3 },
                    { 27, 27, 56 },
                    { 37, 37, 97 },
                    { 100, 100, 51 }
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
