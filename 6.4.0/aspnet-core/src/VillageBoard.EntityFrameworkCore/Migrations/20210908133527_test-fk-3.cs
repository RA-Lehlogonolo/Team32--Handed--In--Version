using Microsoft.EntityFrameworkCore.Migrations;

namespace VillageBoard.Migrations
{
    public partial class testfk3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_Announcement_Types_Announcement_TypeId",
                table: "Announcements");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_Announcement_TypeId",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "Announcement_TypeId",
                table: "Announcements");

            migrationBuilder.RenameColumn(
                name: "AnnoucementID",
                table: "Announcements",
                newName: "Announcement_Type_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_Announcement_Type_ID",
                table: "Announcements",
                column: "Announcement_Type_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_Announcement_Types_Announcement_Type_ID",
                table: "Announcements",
                column: "Announcement_Type_ID",
                principalTable: "Announcement_Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_Announcement_Types_Announcement_Type_ID",
                table: "Announcements");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_Announcement_Type_ID",
                table: "Announcements");

            migrationBuilder.RenameColumn(
                name: "Announcement_Type_ID",
                table: "Announcements",
                newName: "AnnoucementID");

            migrationBuilder.AddColumn<int>(
                name: "Announcement_TypeId",
                table: "Announcements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_Announcement_TypeId",
                table: "Announcements",
                column: "Announcement_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_Announcement_Types_Announcement_TypeId",
                table: "Announcements",
                column: "Announcement_TypeId",
                principalTable: "Announcement_Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
