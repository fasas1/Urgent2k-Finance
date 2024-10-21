using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Urgent_2k_Finance.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTheApplicationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BVN",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "97284789-e5b6-415e-881d-72b1bb5dcfbd", "19064c6c-4d82-464a-ba47-58f577f1440e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "649503dc-fe4a-42b2-989a-4c800231abb5", "da89516b-5954-428f-8ac0-f5226bae85ec" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BVN",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Address", "BVN", "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "23 Iyanapaja Lagos", "12345678901", "76b94a64-1bdd-4a2d-90be-80f9a89fba64", new DateTime(2024, 10, 21, 8, 24, 25, 308, DateTimeKind.Utc).AddTicks(358), "92ad6558-6b17-4e98-8aa1-64f4f5af9ed9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Address", "BVN", "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "456 Elm St Ketu, Lagos", "10987654321", "132d1d21-789a-4227-bc1b-1cb6bfef31fc", new DateTime(2024, 10, 21, 8, 24, 25, 308, DateTimeKind.Utc).AddTicks(390), "37f982ec-11f3-47fc-8e2f-5a8171450a36" });
        }
    }
}
