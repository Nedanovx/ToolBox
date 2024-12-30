using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolBox.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditCartItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "CartItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalWeight",
                table: "CartItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "TotalWeight",
                table: "CartItems");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd13f6c-918d-4e39-bf80-5874a9c96b08",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb201ded-62b8-4d00-9b85-1ee0ea0e6327", "AQAAAAIAAYagAAAAEJf6ZCro76MaKCKXOI99mtgxtS+29QkodcOeCuOhREwy8Uqwo/hwygyZHp3UPmXi6w==", "87f8ada1-9850-4407-b2e8-044bcecf338b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6331660a-cf01-4033-8642-8774887bc271",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a348b32b-3864-49ca-9a90-cf11712585d0", "AQAAAAIAAYagAAAAED2BgHM7n+pXcvaebOm8W9ZZrv1a0PDtxpAGChd2sPjiws/D4L06F4pdEV6PilRQPg==", "42e17a6e-1194-47f4-abc9-6e25e93fd9f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79b8a2fa-0fd5-4d3a-ab98-4d7093728c14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41f0a70f-6bc5-4e46-b89d-c6cffb96e8ff", "AQAAAAIAAYagAAAAENVwcczsaG61ZdHHfTMYZTAmSi3exDsS6o/ZJ+mfUDWP/myMLq8b1Q/wtcq+DbyjpQ==", "31c6411d-09c2-42cc-90a7-c6af474c780e" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 12, 19, 22, 24, 11, 984, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 12, 19, 22, 24, 11, 984, DateTimeKind.Local).AddTicks(6885));
        }
    }
}
