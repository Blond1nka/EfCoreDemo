using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreDemo.Migrations
{
    public partial class itemtagFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopItemItemTags",
                columns: table => new
                {
                    ShopItemId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    ItemTagId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopItemItemTags", x => new { x.ShopItemId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ShopItemItemTags_ItemTag_ItemTagId",
                        column: x => x.ItemTagId,
                        principalTable: "ItemTag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShopItemItemTags_ShopItems_ShopItemId",
                        column: x => x.ShopItemId,
                        principalTable: "ShopItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopItemItemTags_ItemTagId",
                table: "ShopItemItemTags",
                column: "ItemTagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopItemItemTags");

            migrationBuilder.DropTable(
                name: "ItemTag");
        }
    }
}
