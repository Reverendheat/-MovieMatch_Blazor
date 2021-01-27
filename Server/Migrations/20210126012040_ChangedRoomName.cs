using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieMatch_Blazor.Server.Migrations
{
    public partial class ChangedRoomName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_MatchRooms_RoomId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MatchRooms",
                table: "MatchRooms");

            migrationBuilder.RenameTable(
                name: "MatchRooms",
                newName: "Rooms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Rooms_RoomId",
                table: "Users",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Rooms_RoomId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "MatchRooms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatchRooms",
                table: "MatchRooms",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_MatchRooms_RoomId",
                table: "Users",
                column: "RoomId",
                principalTable: "MatchRooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
