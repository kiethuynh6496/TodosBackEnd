using Microsoft.EntityFrameworkCore.Migrations;

namespace TodosBackEnd.Migrations
{
    public partial class _2todos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "todos",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Nhiệm vụ 1" });

            migrationBuilder.InsertData(
                table: "todos",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Nhiệm vụ 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "todos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
