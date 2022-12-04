using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthSever.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateUserDb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "486d1a6c-a70c-4298-8d59-83395b2d7467");

            migrationBuilder.AddColumn<int>(
                name: "Credit",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b7dea97-02fc-4434-81f6-7ec25f2f5237", null, "user", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6b7dea97-02fc-4434-81f6-7ec25f2f5237");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "486d1a6c-a70c-4298-8d59-83395b2d7467", null, "user", null });
        }
    }
}
