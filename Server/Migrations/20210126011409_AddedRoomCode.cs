using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieMatch_Blazor.Server.Migrations
{
    public partial class AddedRoomCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoomCode",
                table: "MatchRooms",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomCode",
                table: "MatchRooms");
        }
    }
}
