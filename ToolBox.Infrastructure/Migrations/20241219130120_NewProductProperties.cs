using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolBox.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewProductProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersItem_Orders_OrderId",
                table: "OrdersItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersItem_Products_ProductId",
                table: "OrdersItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersItem",
                table: "OrdersItem");

            migrationBuilder.RenameTable(
                name: "OrdersItem",
                newName: "OrderItems");

            migrationBuilder.RenameIndex(
                name: "IX_OrdersItem_ProductId",
                table: "OrderItems",
                newName: "IX_OrderItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdersItem_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Products",
                type: "varbinary(max)",
                nullable: true,
                comment: "Product image",
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldComment: "Product image");

            migrationBuilder.AddColumn<string>(
                name: "Characteristic",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "Product characteristic");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Products",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                comment: "Product size");

            migrationBuilder.AddColumn<bool>(
                name: "IsSent",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Order is sent to user or not");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Characteristic",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsSent",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrdersItem");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrdersItem",
                newName: "IX_OrdersItem_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrdersItem",
                newName: "IX_OrdersItem_OrderId");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Products",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                comment: "Product image",
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true,
                oldComment: "Product image");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersItem",
                table: "OrdersItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersItem_Orders_OrderId",
                table: "OrdersItem",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersItem_Products_ProductId",
                table: "OrdersItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
