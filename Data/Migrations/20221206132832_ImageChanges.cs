using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ImageChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "https://www.pngall.com/wp-content/uploads/5/Samsung-TV-PNG-Image-HD.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "https://www.pngall.com/wp-content/uploads/5/Samsung-TV-PNG-Image-HD.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "https://www.pngall.com/wp-content/uploads/5/Samsung-TV-PNG-Image-HD.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "https://www.pngall.com/wp-content/uploads/5/Samsung-TV-PNG-Image-HD.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "https://samsungshop.com.ua/res/cache/images/7d/15/7d153c06cf8aeafa0307b002847130ad/ad6844aa1e4caa49c317ac5114ec9346.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "https://samsungshop.com.ua/res/cache/images/1d/90/1d90f289e972b72228c32289202be042/e8d9a3ca400b66bf8c8c692f14da64a2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "https://samsungshop.com.ua/res/cache/images/40/19/401937ab040b932e4f2c1e9337ddd3c0/15a98e0cd6a396d4bca1ca2dc6617e43.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "https://samsungshop.com.ua/res/cache/images/1c/4f/1c4f73fd470d63249f4a0763dff03d89/4262c548db10324900e61c6853ce44f8.jpg");
        }
    }
}
