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
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
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
                    { 1, "Description for product 1", "Product 1", 249m },
                    { 73, "Description for product 73", "Product 73", 292m },
                    { 72, "Description for product 72", "Product 72", 334m },
                    { 71, "Description for product 71", "Product 71", 181m },
                    { 70, "Description for product 70", "Product 70", 984m },
                    { 69, "Description for product 69", "Product 69", 403m },
                    { 68, "Description for product 68", "Product 68", 556m },
                    { 67, "Description for product 67", "Product 67", 978m },
                    { 66, "Description for product 66", "Product 66", 679m },
                    { 65, "Description for product 65", "Product 65", 814m },
                    { 64, "Description for product 64", "Product 64", 600m },
                    { 63, "Description for product 63", "Product 63", 782m },
                    { 62, "Description for product 62", "Product 62", 230m },
                    { 61, "Description for product 61", "Product 61", 967m },
                    { 60, "Description for product 60", "Product 60", 256m },
                    { 59, "Description for product 59", "Product 59", 176m },
                    { 58, "Description for product 58", "Product 58", 416m },
                    { 57, "Description for product 57", "Product 57", 601m },
                    { 56, "Description for product 56", "Product 56", 590m },
                    { 55, "Description for product 55", "Product 55", 189m },
                    { 54, "Description for product 54", "Product 54", 585m },
                    { 53, "Description for product 53", "Product 53", 805m },
                    { 74, "Description for product 74", "Product 74", 108m },
                    { 52, "Description for product 52", "Product 52", 539m },
                    { 75, "Description for product 75", "Product 75", 133m },
                    { 77, "Description for product 77", "Product 77", 823m },
                    { 98, "Description for product 98", "Product 98", 335m },
                    { 97, "Description for product 97", "Product 97", 555m },
                    { 96, "Description for product 96", "Product 96", 797m },
                    { 95, "Description for product 95", "Product 95", 274m },
                    { 94, "Description for product 94", "Product 94", 599m },
                    { 93, "Description for product 93", "Product 93", 296m },
                    { 92, "Description for product 92", "Product 92", 160m },
                    { 91, "Description for product 91", "Product 91", 144m },
                    { 90, "Description for product 90", "Product 90", 110m },
                    { 89, "Description for product 89", "Product 89", 394m },
                    { 88, "Description for product 88", "Product 88", 519m },
                    { 87, "Description for product 87", "Product 87", 560m },
                    { 86, "Description for product 86", "Product 86", 178m },
                    { 85, "Description for product 85", "Product 85", 563m },
                    { 84, "Description for product 84", "Product 84", 408m },
                    { 83, "Description for product 83", "Product 83", 605m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "Description for product 82", "Product 82", 546m },
                    { 81, "Description for product 81", "Product 81", 408m },
                    { 80, "Description for product 80", "Product 80", 773m },
                    { 79, "Description for product 79", "Product 79", 959m },
                    { 78, "Description for product 78", "Product 78", 813m },
                    { 76, "Description for product 76", "Product 76", 550m },
                    { 51, "Description for product 51", "Product 51", 697m },
                    { 50, "Description for product 50", "Product 50", 586m },
                    { 49, "Description for product 49", "Product 49", 311m },
                    { 22, "Description for product 22", "Product 22", 658m },
                    { 21, "Description for product 21", "Product 21", 788m },
                    { 20, "Description for product 20", "Product 20", 961m },
                    { 19, "Description for product 19", "Product 19", 250m },
                    { 18, "Description for product 18", "Product 18", 949m },
                    { 17, "Description for product 17", "Product 17", 606m },
                    { 16, "Description for product 16", "Product 16", 557m },
                    { 15, "Description for product 15", "Product 15", 631m },
                    { 14, "Description for product 14", "Product 14", 903m },
                    { 13, "Description for product 13", "Product 13", 939m },
                    { 12, "Description for product 12", "Product 12", 983m },
                    { 11, "Description for product 11", "Product 11", 944m },
                    { 10, "Description for product 10", "Product 10", 432m },
                    { 9, "Description for product 9", "Product 9", 760m },
                    { 8, "Description for product 8", "Product 8", 677m },
                    { 7, "Description for product 7", "Product 7", 948m },
                    { 6, "Description for product 6", "Product 6", 262m },
                    { 5, "Description for product 5", "Product 5", 861m },
                    { 4, "Description for product 4", "Product 4", 207m },
                    { 3, "Description for product 3", "Product 3", 209m },
                    { 2, "Description for product 2", "Product 2", 495m },
                    { 23, "Description for product 23", "Product 23", 893m },
                    { 24, "Description for product 24", "Product 24", 793m },
                    { 25, "Description for product 25", "Product 25", 131m },
                    { 26, "Description for product 26", "Product 26", 704m },
                    { 48, "Description for product 48", "Product 48", 749m },
                    { 47, "Description for product 47", "Product 47", 396m },
                    { 46, "Description for product 46", "Product 46", 357m },
                    { 45, "Description for product 45", "Product 45", 834m },
                    { 44, "Description for product 44", "Product 44", 180m },
                    { 43, "Description for product 43", "Product 43", 835m },
                    { 42, "Description for product 42", "Product 42", 338m },
                    { 41, "Description for product 41", "Product 41", 928m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 40, "Description for product 40", "Product 40", 242m },
                    { 39, "Description for product 39", "Product 39", 756m },
                    { 99, "Description for product 99", "Product 99", 365m },
                    { 38, "Description for product 38", "Product 38", 372m },
                    { 36, "Description for product 36", "Product 36", 646m },
                    { 35, "Description for product 35", "Product 35", 600m },
                    { 34, "Description for product 34", "Product 34", 483m },
                    { 33, "Description for product 33", "Product 33", 104m },
                    { 32, "Description for product 32", "Product 32", 365m },
                    { 31, "Description for product 31", "Product 31", 617m },
                    { 30, "Description for product 30", "Product 30", 260m },
                    { 29, "Description for product 29", "Product 29", 895m },
                    { 28, "Description for product 28", "Product 28", 817m },
                    { 27, "Description for product 27", "Product 27", 295m },
                    { 37, "Description for product 37", "Product 37", 476m },
                    { 100, "Description for product 100", "Product 100", 254m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 12 },
                    { 73, 73, 4 },
                    { 72, 72, 3 },
                    { 71, 71, 0 },
                    { 70, 70, 15 },
                    { 69, 69, 7 },
                    { 68, 68, 18 },
                    { 67, 67, 4 },
                    { 66, 66, 3 },
                    { 65, 65, 0 },
                    { 64, 64, 5 },
                    { 63, 63, 7 },
                    { 62, 62, 3 },
                    { 61, 61, 16 },
                    { 60, 60, 2 },
                    { 59, 59, 1 },
                    { 58, 58, 18 },
                    { 57, 57, 1 },
                    { 56, 56, 4 },
                    { 55, 55, 2 },
                    { 54, 54, 5 },
                    { 53, 53, 15 },
                    { 74, 74, 8 },
                    { 52, 52, 10 },
                    { 75, 75, 0 },
                    { 77, 77, 10 },
                    { 98, 98, 11 },
                    { 97, 97, 3 },
                    { 96, 96, 12 },
                    { 95, 95, 0 },
                    { 94, 94, 3 },
                    { 93, 93, 9 },
                    { 92, 92, 1 },
                    { 91, 91, 10 },
                    { 90, 90, 8 },
                    { 89, 89, 14 },
                    { 88, 88, 7 },
                    { 87, 87, 17 },
                    { 86, 86, 3 },
                    { 85, 85, 12 },
                    { 84, 84, 1 },
                    { 83, 83, 14 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 82, 82, 16 },
                    { 81, 81, 19 },
                    { 80, 80, 7 },
                    { 79, 79, 3 },
                    { 78, 78, 13 },
                    { 76, 76, 7 },
                    { 51, 51, 14 },
                    { 50, 50, 9 },
                    { 49, 49, 7 },
                    { 22, 22, 7 },
                    { 21, 21, 18 },
                    { 20, 20, 16 },
                    { 19, 19, 5 },
                    { 18, 18, 11 },
                    { 17, 17, 14 },
                    { 16, 16, 0 },
                    { 15, 15, 7 },
                    { 14, 14, 1 },
                    { 13, 13, 15 },
                    { 12, 12, 17 },
                    { 11, 11, 15 },
                    { 10, 10, 14 },
                    { 9, 9, 13 },
                    { 8, 8, 17 },
                    { 7, 7, 6 },
                    { 6, 6, 10 },
                    { 5, 5, 1 },
                    { 4, 4, 11 },
                    { 3, 3, 11 },
                    { 2, 2, 8 },
                    { 23, 23, 6 },
                    { 24, 24, 13 },
                    { 25, 25, 10 },
                    { 26, 26, 18 },
                    { 48, 48, 16 },
                    { 47, 47, 19 },
                    { 46, 46, 2 },
                    { 45, 45, 9 },
                    { 44, 44, 13 },
                    { 43, 43, 17 },
                    { 42, 42, 10 },
                    { 41, 41, 15 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 40, 40, 16 },
                    { 39, 39, 6 },
                    { 99, 99, 12 },
                    { 38, 38, 11 },
                    { 36, 36, 11 },
                    { 35, 35, 13 },
                    { 34, 34, 17 },
                    { 33, 33, 12 },
                    { 32, 32, 12 },
                    { 31, 31, 13 },
                    { 30, 30, 7 },
                    { 29, 29, 10 },
                    { 28, 28, 2 },
                    { 27, 27, 13 },
                    { 37, 37, 19 },
                    { 100, 100, 5 }
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
