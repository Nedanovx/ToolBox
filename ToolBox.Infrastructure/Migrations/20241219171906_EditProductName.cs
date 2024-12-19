using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolBox.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditProductName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd13f6c-918d-4e39-bf80-5874a9c96b08",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01b90177-07e0-46cc-81b9-719071084432", "AQAAAAIAAYagAAAAEH/8t06+IHlI1yV0jyaYfqPIrdbHYt7yXiiNXzwPNE4O+GFv0Q+keeTeIO0nrwkK9g==", "ae135339-8edf-4f37-b006-adc3a1aa9699" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6331660a-cf01-4033-8642-8774887bc271",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa29e419-64eb-4195-b16f-f23481bdae04", "05034273-d414-4306-b882-ed6f155f290a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79b8a2fa-0fd5-4d3a-ab98-4d7093728c14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "813ac088-28cd-492a-bfe9-805fe88143ae", "AQAAAAIAAYagAAAAEMcz5hcY4zLFkTY2MQhVef7MwSJuyLKC0nVkDca8dLg1/FfHl4P2RS+tK8lVLu2MTA==", "3fd92b97-b38d-461c-bd23-6fefa6425821" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 12, 19, 19, 19, 5, 596, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 12, 19, 19, 19, 5, 596, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProductName",
                value: "Звездогаечен ключ, 21 mm");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ProductName",
                value: "Удължен вездогаечен ключ, 10 mm");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd13f6c-918d-4e39-bf80-5874a9c96b08",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d859e1a-3e2f-4973-9598-197de84d2b4e", "AQAAAAIAAYagAAAAELVNAXSh8PqrvUD0Wca4xP6YOi9gaAIiqElm+izalkWVN8JRLCMECQSzIBPiaYVU4w==", "76946b17-1efa-4e9f-8afe-9b44c8927188" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6331660a-cf01-4033-8642-8774887bc271",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0f8cc6e2-b5e5-479f-ad9e-486a1d25bbba", "d6c274f1-0c36-45a1-8ce0-7507a66eb4bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79b8a2fa-0fd5-4d3a-ab98-4d7093728c14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8625548a-e54e-4514-bdf2-66c95f76a258", "AQAAAAIAAYagAAAAEEenM0bNHpAXR7+Jf7o57IKx/p7hcwnKNG0SRF5CVO2dbKXYrVFpBsB2jQV5BRe/vw==", "f6b6b965-165b-46e4-93ac-24a4c45c1864" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 12, 19, 16, 18, 7, 137, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 12, 19, 16, 18, 7, 137, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProductName",
                value: "Звездогаечен ключ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ProductName",
                value: "Звездогаечен ключ");
        }
    }
}
