using Microsoft.EntityFrameworkCore.Migrations;

namespace MST.IDP.Admin.EntityFramework.SqlServer.Migrations.Identity
{
    public partial class ForcedPasswordChangeFlag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ForcedPasswordChange",
                table: "Users",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForcedPasswordChange",
                table: "Users");
        }
    }
}
