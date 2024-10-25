using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Urgent_2k_Finance.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ae3d483-208b-492c-be76-ae08a7db14bb", "16b301d0-470e-4df2-8e56-9914ef12dbe5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d6366b6-725e-4f4e-a4ed-06ab54548725", "cc7a6203-d687-45d0-bd60-5de3b66c74a2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
