using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthSever.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateUserDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3a14ed68-7810-4bff-8621-bb099136884a");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ec11cde-9252-4ab2-b2a0-3e474233acc3", null, "user", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2ec11cde-9252-4ab2-b2a0-3e474233acc3");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a14ed68-7810-4bff-8621-bb099136884a", null, "user", null });
        }
    }
}
