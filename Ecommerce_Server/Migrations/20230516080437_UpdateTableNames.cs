using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce_Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategory_ProductMainCategory_ProductMainCategoryid",
                table: "ProductSubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSubCategory",
                table: "ProductSubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductMainCategory",
                table: "ProductMainCategory");

            migrationBuilder.RenameTable(
                name: "ProductSubCategory",
                newName: "product_sub_cat");

            migrationBuilder.RenameTable(
                name: "ProductMainCategory",
                newName: "product_main_cat");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategory_ProductMainCategoryid",
                table: "product_sub_cat",
                newName: "IX_product_sub_cat_ProductMainCategoryid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product_sub_cat",
                table: "product_sub_cat",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product_main_cat",
                table: "product_main_cat",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_sub_cat_product_main_cat_ProductMainCategoryid",
                table: "product_sub_cat",
                column: "ProductMainCategoryid",
                principalTable: "product_main_cat",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_sub_cat_product_main_cat_ProductMainCategoryid",
                table: "product_sub_cat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product_sub_cat",
                table: "product_sub_cat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product_main_cat",
                table: "product_main_cat");

            migrationBuilder.RenameTable(
                name: "product_sub_cat",
                newName: "ProductSubCategory");

            migrationBuilder.RenameTable(
                name: "product_main_cat",
                newName: "ProductMainCategory");

            migrationBuilder.RenameIndex(
                name: "IX_product_sub_cat_ProductMainCategoryid",
                table: "ProductSubCategory",
                newName: "IX_ProductSubCategory_ProductMainCategoryid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSubCategory",
                table: "ProductSubCategory",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductMainCategory",
                table: "ProductMainCategory",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategory_ProductMainCategory_ProductMainCategoryid",
                table: "ProductSubCategory",
                column: "ProductMainCategoryid",
                principalTable: "ProductMainCategory",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
