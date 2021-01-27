using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieMatch_Blazor.Server.Migrations
{
    public partial class AddedUserCodeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserCode",
                table: "Users",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCode",
                table: "Users");
        }
    }
}
