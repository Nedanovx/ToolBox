using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToolBox.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd13f6c-918d-4e39-bf80-5874a9c96b08",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbcfdf29-f3cf-48b3-9172-0da2dfb8c303", "AQAAAAIAAYagAAAAEGFmMpHSgV6oduuLr4tE8RU/9gjiKZ1DGinMD0+s74w542nJblxquckmPTDmbR37FA==", "ac207519-b908-4278-ab76-3786799daa98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6331660a-cf01-4033-8642-8774887bc271",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f826438f-780d-44c8-b1ed-491c529a643f", "AQAAAAIAAYagAAAAEKEQOILZzap3PUR0Q5aZ66i8NY7Kr2wSkEsPl6VD40jCqF+pGgflEz7TdnWH2o56vA==", "5793edf9-9353-463e-a5fa-da49100b30cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79b8a2fa-0fd5-4d3a-ab98-4d7093728c14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6abc08e-c590-42aa-adff-93c3b4e98b99", "AQAAAAIAAYagAAAAEFTjojuLqeb3TaxxgyIY7zsDCZyKhdvPf/AADvZiie4F6uK8mChoWceBBXdl3f3VSA==", "39279564-556b-4468-a7d3-e91908d12814" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "6331660a-cf01-4033-8642-8774887bc271" },
                    { 2, "0dd13f6c-918d-4e39-bf80-5874a9c96b08" }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 12, 30, 16, 10, 25, 826, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 12, 30, 16, 10, 25, 826, DateTimeKind.Local).AddTicks(9593));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd13f6c-918d-4e39-bf80-5874a9c96b08",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb93e999-20da-4153-a90a-3449b8b4243b", "AQAAAAIAAYagAAAAEBLH6nnV5UUel1oLO8hndM8RXzDNUwg/bPjskZqV69JetlGuOU399p1m1LzHUXJ1pA==", "094911ce-f23a-40b0-88bd-b19d40f90d8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6331660a-cf01-4033-8642-8774887bc271",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "355f4bfb-7586-482f-872e-d8d552712f5d", "AQAAAAIAAYagAAAAEEV71man+AWtf6jN64dtHTQFE6EYbTw6fhMw2B8iLAW6KkN6vpRtctyH20+IPVZ/WA==", "6032b589-f8c2-4992-8655-d84946ce269f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79b8a2fa-0fd5-4d3a-ab98-4d7093728c14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc73efd2-06b8-4434-b9a2-5d6c24a10eb3", "AQAAAAIAAYagAAAAEBQ3hjDWN3wezVDigFcJybHc4yDq8gM3rDhExoskZOVoqC1dHUYZHqguSMO6Nm6qZw==", "49f2aec8-8f9e-4aac-8d98-e3781019d641" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 12, 30, 13, 3, 43, 195, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 12, 30, 13, 3, 43, 195, DateTimeKind.Local).AddTicks(6072));
        }
    }
}
