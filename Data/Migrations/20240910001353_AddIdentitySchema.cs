using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavourlinesWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentitySchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerOrders_Users_UserId",
                table: "CustomerOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_CustomerOrders_UserId",
                table: "CustomerOrders");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "CustomerOrders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrders_UserId1",
                table: "CustomerOrders",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerOrders_AspNetUsers_UserId1",
                table: "CustomerOrders",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerOrders_AspNetUsers_UserId1",
                table: "CustomerOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_CustomerOrders_UserId1",
                table: "CustomerOrders");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "CustomerOrders");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrders_UserId",
                table: "CustomerOrders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerOrders_Users_UserId",
                table: "CustomerOrders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
