using Microsoft.EntityFrameworkCore.Migrations;

namespace ShirtsShop.Server.Migrations
{
    public partial class Seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shirts_Sizes_SizeId",
                table: "Shirts");

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "Shirts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "XS" },
                    { 2, "S" },
                    { 3, "XM" },
                    { 4, "M" },
                    { 5, "L" },
                    { 6, "XL" },
                    { 7, "XXL" },
                    { 8, "XXXL" },
                    { 9, "XXXXL" }
                });

            migrationBuilder.InsertData(
                table: "Shirts",
                columns: new[] { "Id", "Color", "SizeId", "Text" },
                values: new object[] { 1, "Black", 2, "Long" });

            migrationBuilder.InsertData(
                table: "Shirts",
                columns: new[] { "Id", "Color", "SizeId", "Text" },
                values: new object[] { 2, "White", 4, "Live" });

            migrationBuilder.AddForeignKey(
                name: "FK_Shirts_Sizes_SizeId",
                table: "Shirts",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shirts_Sizes_SizeId",
                table: "Shirts");

            migrationBuilder.DeleteData(
                table: "Shirts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shirts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "Shirts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Shirts_Sizes_SizeId",
                table: "Shirts",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
