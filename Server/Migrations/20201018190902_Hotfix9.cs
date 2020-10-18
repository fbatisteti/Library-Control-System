using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Server.Migrations
{
    public partial class Hotfix9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Members_CustodyMemberId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CustodyMemberId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CustodyMemberId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_MemberId",
                table: "Books",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Members_MemberId",
                table: "Books",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Members_MemberId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_MemberId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "CustodyMemberId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CustodyMemberId",
                table: "Books",
                column: "CustodyMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Members_CustodyMemberId",
                table: "Books",
                column: "CustodyMemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
