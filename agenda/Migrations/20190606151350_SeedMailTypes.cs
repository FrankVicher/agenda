using Microsoft.EntityFrameworkCore.Migrations;

namespace agenda.Migrations
{
    public partial class SeedMailTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MailTypes",
                columns: new[] { "MailTypeId", "IsActive", "Name" },
                values: new object[] { 1, true, "Trabajo" });

            migrationBuilder.InsertData(
                table: "MailTypes",
                columns: new[] { "MailTypeId", "IsActive", "Name" },
                values: new object[] { 2, true, "Personal" });

            migrationBuilder.InsertData(
                table: "MailTypes",
                columns: new[] { "MailTypeId", "IsActive", "Name" },
                values: new object[] { 3, true, "Otro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MailTypes",
                keyColumn: "MailTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MailTypes",
                keyColumn: "MailTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MailTypes",
                keyColumn: "MailTypeId",
                keyValue: 3);
        }
    }
}
