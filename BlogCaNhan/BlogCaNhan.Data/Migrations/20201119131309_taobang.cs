using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCaNhan.Data.Migrations
{
    public partial class taobang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "theLoais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theLoais", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_theLoais_url",
                table: "theLoais",
                column: "url",
                unique: true,
                filter: "[url] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "theLoais");
        }
    }
}
