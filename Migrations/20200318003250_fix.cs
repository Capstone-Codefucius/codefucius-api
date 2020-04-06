using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace codefucius_api.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "UUID",
                table: "Reviews");

            migrationBuilder.AlterColumn<char>(
                name: "AuthorID",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "Reviews",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Reviews");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorID",
                table: "Reviews",
                type: "text",
                nullable: true,
                oldClrType: typeof(char));

            migrationBuilder.AddColumn<string>(
                name: "UUID",
                table: "Reviews",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "UUID");
        }
    }
}
