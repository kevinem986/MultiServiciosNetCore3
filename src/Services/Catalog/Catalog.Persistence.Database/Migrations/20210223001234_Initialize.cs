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
                    { 1, "Description for product 1", "Product 1", 801m },
                    { 73, "Description for product 73", "Product 73", 596m },
                    { 72, "Description for product 72", "Product 72", 551m },
                    { 71, "Description for product 71", "Product 71", 600m },
                    { 70, "Description for product 70", "Product 70", 574m },
                    { 69, "Description for product 69", "Product 69", 506m },
                    { 68, "Description for product 68", "Product 68", 467m },
                    { 67, "Description for product 67", "Product 67", 900m },
                    { 66, "Description for product 66", "Product 66", 679m },
                    { 65, "Description for product 65", "Product 65", 396m },
                    { 64, "Description for product 64", "Product 64", 658m },
                    { 63, "Description for product 63", "Product 63", 832m },
                    { 62, "Description for product 62", "Product 62", 487m },
                    { 61, "Description for product 61", "Product 61", 360m },
                    { 60, "Description for product 60", "Product 60", 502m },
                    { 59, "Description for product 59", "Product 59", 962m },
                    { 58, "Description for product 58", "Product 58", 101m },
                    { 57, "Description for product 57", "Product 57", 733m },
                    { 56, "Description for product 56", "Product 56", 483m },
                    { 55, "Description for product 55", "Product 55", 357m },
                    { 54, "Description for product 54", "Product 54", 738m },
                    { 53, "Description for product 53", "Product 53", 418m },
                    { 74, "Description for product 74", "Product 74", 490m },
                    { 52, "Description for product 52", "Product 52", 921m },
                    { 75, "Description for product 75", "Product 75", 857m },
                    { 77, "Description for product 77", "Product 77", 404m },
                    { 98, "Description for product 98", "Product 98", 456m },
                    { 97, "Description for product 97", "Product 97", 184m },
                    { 96, "Description for product 96", "Product 96", 489m },
                    { 95, "Description for product 95", "Product 95", 101m },
                    { 94, "Description for product 94", "Product 94", 486m },
                    { 93, "Description for product 93", "Product 93", 879m },
                    { 92, "Description for product 92", "Product 92", 790m },
                    { 91, "Description for product 91", "Product 91", 367m },
                    { 90, "Description for product 90", "Product 90", 462m },
                    { 89, "Description for product 89", "Product 89", 113m },
                    { 88, "Description for product 88", "Product 88", 567m },
                    { 87, "Description for product 87", "Product 87", 821m },
                    { 86, "Description for product 86", "Product 86", 394m },
                    { 85, "Description for product 85", "Product 85", 974m },
                    { 84, "Description for product 84", "Product 84", 385m },
                    { 83, "Description for product 83", "Product 83", 413m },
                    { 82, "Description for product 82", "Product 82", 771m },
                    { 81, "Description for product 81", "Product 81", 958m },
                    { 80, "Description for product 80", "Product 80", 323m },
                    { 79, "Description for product 79", "Product 79", 839m },
                    { 78, "Description for product 78", "Product 78", 508m },
                    { 76, "Description for product 76", "Product 76", 495m },
                    { 51, "Description for product 51", "Product 51", 799m },
                    { 50, "Description for product 50", "Product 50", 827m },
                    { 49, "Description for product 49", "Product 49", 476m },
                    { 22, "Description for product 22", "Product 22", 418m },
                    { 21, "Description for product 21", "Product 21", 412m },
                    { 20, "Description for product 20", "Product 20", 734m },
                    { 19, "Description for product 19", "Product 19", 752m },
                    { 18, "Description for product 18", "Product 18", 484m },
                    { 17, "Description for product 17", "Product 17", 393m },
                    { 16, "Description for product 16", "Product 16", 393m },
                    { 15, "Description for product 15", "Product 15", 575m },
                    { 14, "Description for product 14", "Product 14", 351m },
                    { 13, "Description for product 13", "Product 13", 738m },
                    { 12, "Description for product 12", "Product 12", 206m },
                    { 11, "Description for product 11", "Product 11", 819m },
                    { 10, "Description for product 10", "Product 10", 612m },
                    { 9, "Description for product 9", "Product 9", 431m },
                    { 8, "Description for product 8", "Product 8", 945m },
                    { 7, "Description for product 7", "Product 7", 278m },
                    { 6, "Description for product 6", "Product 6", 292m },
                    { 5, "Description for product 5", "Product 5", 290m },
                    { 4, "Description for product 4", "Product 4", 374m },
                    { 3, "Description for product 3", "Product 3", 727m },
                    { 2, "Description for product 2", "Product 2", 988m },
                    { 23, "Description for product 23", "Product 23", 354m },
                    { 24, "Description for product 24", "Product 24", 726m },
                    { 25, "Description for product 25", "Product 25", 412m },
                    { 26, "Description for product 26", "Product 26", 787m },
                    { 48, "Description for product 48", "Product 48", 260m },
                    { 47, "Description for product 47", "Product 47", 829m },
                    { 46, "Description for product 46", "Product 46", 189m },
                    { 45, "Description for product 45", "Product 45", 886m },
                    { 44, "Description for product 44", "Product 44", 845m },
                    { 43, "Description for product 43", "Product 43", 114m },
                    { 42, "Description for product 42", "Product 42", 916m },
                    { 41, "Description for product 41", "Product 41", 877m },
                    { 40, "Description for product 40", "Product 40", 361m },
                    { 39, "Description for product 39", "Product 39", 888m },
                    { 99, "Description for product 99", "Product 99", 548m },
                    { 38, "Description for product 38", "Product 38", 841m },
                    { 36, "Description for product 36", "Product 36", 101m },
                    { 35, "Description for product 35", "Product 35", 845m },
                    { 34, "Description for product 34", "Product 34", 371m },
                    { 33, "Description for product 33", "Product 33", 306m },
                    { 32, "Description for product 32", "Product 32", 240m },
                    { 31, "Description for product 31", "Product 31", 315m },
                    { 30, "Description for product 30", "Product 30", 773m },
                    { 29, "Description for product 29", "Product 29", 213m },
                    { 28, "Description for product 28", "Product 28", 790m },
                    { 27, "Description for product 27", "Product 27", 931m },
                    { 37, "Description for product 37", "Product 37", 792m },
                    { 100, "Description for product 100", "Product 100", 307m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 15 },
                    { 73, 73, 11 },
                    { 72, 72, 15 },
                    { 71, 71, 5 },
                    { 70, 70, 13 },
                    { 69, 69, 19 },
                    { 68, 68, 6 },
                    { 67, 67, 2 },
                    { 66, 66, 3 },
                    { 65, 65, 18 },
                    { 64, 64, 16 },
                    { 63, 63, 9 },
                    { 62, 62, 11 },
                    { 61, 61, 18 },
                    { 60, 60, 0 },
                    { 59, 59, 8 },
                    { 58, 58, 2 },
                    { 57, 57, 4 },
                    { 56, 56, 16 },
                    { 55, 55, 19 },
                    { 54, 54, 15 },
                    { 53, 53, 14 },
                    { 74, 74, 14 },
                    { 52, 52, 6 },
                    { 75, 75, 11 },
                    { 77, 77, 8 },
                    { 98, 98, 13 },
                    { 97, 97, 6 },
                    { 96, 96, 1 },
                    { 95, 95, 4 },
                    { 94, 94, 15 },
                    { 93, 93, 12 },
                    { 92, 92, 15 },
                    { 91, 91, 12 },
                    { 90, 90, 15 },
                    { 89, 89, 6 },
                    { 88, 88, 17 },
                    { 87, 87, 10 },
                    { 86, 86, 9 },
                    { 85, 85, 6 },
                    { 84, 84, 2 },
                    { 83, 83, 17 },
                    { 82, 82, 14 },
                    { 81, 81, 6 },
                    { 80, 80, 0 },
                    { 79, 79, 17 },
                    { 78, 78, 19 },
                    { 76, 76, 1 },
                    { 51, 51, 18 },
                    { 50, 50, 16 },
                    { 49, 49, 4 },
                    { 22, 22, 18 },
                    { 21, 21, 16 },
                    { 20, 20, 3 },
                    { 19, 19, 18 },
                    { 18, 18, 7 },
                    { 17, 17, 16 },
                    { 16, 16, 4 },
                    { 15, 15, 9 },
                    { 14, 14, 11 },
                    { 13, 13, 12 },
                    { 12, 12, 15 },
                    { 11, 11, 7 },
                    { 10, 10, 14 },
                    { 9, 9, 1 },
                    { 8, 8, 8 },
                    { 7, 7, 13 },
                    { 6, 6, 19 },
                    { 5, 5, 1 },
                    { 4, 4, 15 },
                    { 3, 3, 19 },
                    { 2, 2, 19 },
                    { 23, 23, 14 },
                    { 24, 24, 16 },
                    { 25, 25, 7 },
                    { 26, 26, 1 },
                    { 48, 48, 6 },
                    { 47, 47, 14 },
                    { 46, 46, 6 },
                    { 45, 45, 18 },
                    { 44, 44, 15 },
                    { 43, 43, 10 },
                    { 42, 42, 15 },
                    { 41, 41, 12 },
                    { 40, 40, 3 },
                    { 39, 39, 15 },
                    { 99, 99, 16 },
                    { 38, 38, 1 },
                    { 36, 36, 16 },
                    { 35, 35, 12 },
                    { 34, 34, 5 },
                    { 33, 33, 12 },
                    { 32, 32, 4 },
                    { 31, 31, 16 },
                    { 30, 30, 4 },
                    { 29, 29, 19 },
                    { 28, 28, 2 },
                    { 27, 27, 0 },
                    { 37, 37, 18 },
                    { 100, 100, 15 }
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

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductInStockId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductInStockId");
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
