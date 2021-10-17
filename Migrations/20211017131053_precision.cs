using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreDemo.Migrations
{
    public partial class precision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "ShopItems",
                type: "decimal(20,2)",
                precision: 20,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "ShopItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,2)",
                oldPrecision: 20,
                oldScale: 2);
        }
    }
}
