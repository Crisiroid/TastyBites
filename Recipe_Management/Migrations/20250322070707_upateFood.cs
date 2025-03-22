using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipe_Management.Migrations
{
    /// <inheritdoc />
    public partial class upateFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Foods_FoodId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_FoodId",
                table: "Items");

            migrationBuilder.AddColumn<string>(
                name: "RequiredItems",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequiredItems",
                table: "Foods");

            migrationBuilder.CreateIndex(
                name: "IX_Items_FoodId",
                table: "Items",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Foods_FoodId",
                table: "Items",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
