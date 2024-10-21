using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Urgent_2k_Finance.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_AspNetUsers_ApplicationUserId",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BankAccounts");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "BankAccounts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "76b94a64-1bdd-4a2d-90be-80f9a89fba64", new DateTime(2024, 10, 21, 8, 24, 25, 308, DateTimeKind.Utc).AddTicks(358), "92ad6558-6b17-4e98-8aa1-64f4f5af9ed9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "132d1d21-789a-4227-bc1b-1cb6bfef31fc", new DateTime(2024, 10, 21, 8, 24, 25, 308, DateTimeKind.Utc).AddTicks(390), "37f982ec-11f3-47fc-8e2f-5a8171450a36" });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "ApplicationUserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "AccountId",
                keyValue: 2,
                column: "ApplicationUserId",
                value: "2");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "AccountId",
                keyValue: 3,
                column: "ApplicationUserId",
                value: "1");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_AspNetUsers_ApplicationUserId",
                table: "BankAccounts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_AspNetUsers_ApplicationUserId",
                table: "BankAccounts");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "BankAccounts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BankAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "1474f645-e7a1-4a93-bb03-563ad58eb921", new DateTime(2024, 10, 19, 11, 45, 24, 547, DateTimeKind.Utc).AddTicks(6871), "8eef0fb7-961c-4c92-84df-a36a39c34922" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "211b4ff8-8024-4b2f-87be-bd03fcce3ade", new DateTime(2024, 10, 19, 11, 45, 24, 547, DateTimeKind.Utc).AddTicks(6899), "26f45ceb-c6ec-4bb6-b6de-bb1963f599c5" });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "AccountId",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "UserId" },
                values: new object[] { null, "1" });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "AccountId",
                keyValue: 2,
                columns: new[] { "ApplicationUserId", "UserId" },
                values: new object[] { null, "2" });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "AccountId",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "UserId" },
                values: new object[] { null, "1" });

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_AspNetUsers_ApplicationUserId",
                table: "BankAccounts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
