using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Infrastructure.Migrations
{
    public partial class fixChangesidentityreaddingIDcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Changes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Changes",
                table: "Changes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Changes_BookId",
                table: "Changes",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Changes_Books_BookId",
                table: "Changes",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Changes_Books_BookId",
                table: "Changes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Changes",
                table: "Changes");

            migrationBuilder.DropIndex(
                name: "IX_Changes_BookId",
                table: "Changes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Changes");
        }
    }
}
