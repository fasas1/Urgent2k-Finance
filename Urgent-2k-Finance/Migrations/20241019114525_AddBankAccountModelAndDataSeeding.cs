using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Urgent_2k_Finance.Migrations
{
    /// <inheritdoc />
    public partial class AddBankAccountModelAndDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_BankAccounts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BVN", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "KYCStatus", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "23 Iyanapaja Lagos", "12345678901", "1474f645-e7a1-4a93-bb03-563ad58eb921", new DateTime(2024, 10, 19, 11, 45, 24, 547, DateTimeKind.Utc).AddTicks(6871), new DateTime(1993, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ade1@example.com", false, "Ademola Adeola", "Verified", false, null, null, null, null, null, false, "8eef0fb7-961c-4c92-84df-a36a39c34922", false, "ade1@gmail.com" },
                    { "2", 0, "456 Elm St Ketu, Lagos", "10987654321", "211b4ff8-8024-4b2f-87be-bd03fcce3ade", new DateTime(2024, 10, 19, 11, 45, 24, 547, DateTimeKind.Utc).AddTicks(6899), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "audu@gmail.com", false, "Ibrahim Audu", "Pending", false, null, null, null, null, null, false, "26f45ceb-c6ec-4bb6-b6de-bb1963f599c5", false, "audu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "AccountId", "AccountNumber", "AccountType", "ApplicationUserId", "Balance", "UserId" },
                values: new object[,]
                {
                    { 1, "1234567890", "Savings", null, 5000m, "1" },
                    { 2, "1429083782", "Savings", null, 2000m, "2" },
                    { 3, "1228778914", "Current", null, 10000m, "1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_ApplicationUserId",
                table: "BankAccounts",
                column: "ApplicationUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
