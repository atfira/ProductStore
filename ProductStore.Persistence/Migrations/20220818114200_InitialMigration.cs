using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductStore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desciption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("efbce6fb-3a20-487a-8983-10de14206ad7"), "Detectors and Sensors" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Desciption", "ImageUrl", "Name" },
                values: new object[] { new Guid("0b832726-8ed7-46ef-8fbc-39c5904d7f5d"), new Guid("efbce6fb-3a20-487a-8983-10de14206ad7"), "At the first signs of leaks, freezes, or excess humidity, the Wi-Fi Water Leak & Freeze Detector can alert your smartphone.\r\nNotification includes mobile & audible alerts – messages can alert you or your family/friends wherever you are, while audible alerts sound when you are at home.\r\nConnects to standard Home Wi-Fi directly – no need for an extra hub.\r\nTemperature & humidity sensing – Detect low temperatures that can lead to frozen pipes, and humidity that could damage valuables.", "https://images-na.ssl-images-amazon.com/images/I/51xitGzq7pL.__AC_SX300_SY300_QL70_FMwebp_.jpg", "Resideo RCHW3610WF1001/N Wi-Fi Water Leak Detector" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
