using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArch.Infra.Data.Migrations
{
    public partial class seedDataToCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, "Study about Social Science", null, "Social Science" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[] { 2, "Study about Moral behavior in Society", null, "Moral Science" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[] { 3, "Study about behavior in Society", null, "Behavior Science" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
