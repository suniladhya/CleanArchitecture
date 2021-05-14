using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArch.Infra.Data.Migrations
{
    public partial class CourseDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, "Study about Social Science", "/images/art-ball-shaped-circle-414860.jpg", "Social Science" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[] { 2, "Study about Moral behavior in Society", "/images/blue-bubble-crystal-clear-132477.jpg", "Moral Science" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[] { 3, "Study about behavior in Society", "/images/book-education-graphing-paper-167682.jpg", "Behavior Science" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
