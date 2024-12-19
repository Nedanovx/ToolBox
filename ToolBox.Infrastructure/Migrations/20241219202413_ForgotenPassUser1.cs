using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolBox.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ForgotenPassUser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa29e419-64eb-4195-b16f-f23481bdae04", null, "05034273-d414-4306-b882-ed6f155f290a" });

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
        }
    }
}
