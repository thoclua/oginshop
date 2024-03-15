using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oginshop_doan4.Data.Migrations
{
    public partial class tbRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "GetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "GetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "GetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GetRoles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetRoles", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GetUsers_RoleId",
                table: "GetUsers",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_GetUsers_GetRoles_RoleId",
                table: "GetUsers",
                column: "RoleId",
                principalTable: "GetRoles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GetUsers_GetRoles_RoleId",
                table: "GetUsers");

            migrationBuilder.DropTable(
                name: "GetRoles");

            migrationBuilder.DropIndex(
                name: "IX_GetUsers_RoleId",
                table: "GetUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "GetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "GetUsers");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "GetUsers");
        }
    }
}
