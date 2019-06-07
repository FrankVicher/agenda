using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace agenda.Migrations
{
    public partial class AddMailTypeToMails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mail",
                columns: table => new
                {
                    MailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MailAddress = table.Column<string>(maxLength: 254, nullable: false),
                    MailTypeId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mail", x => x.MailId);
                    table.ForeignKey(
                        name: "FK_Mail_MailTypes_MailTypeId",
                        column: x => x.MailTypeId,
                        principalTable: "MailTypes",
                        principalColumn: "MailTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mail_MailTypeId",
                table: "Mail",
                column: "MailTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mail");
        }
    }
}
