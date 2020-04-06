using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace codefucius_api.Migrations
{
    public partial class fixed_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorID",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(char),
                oldType: "character(1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "AuthorID",
                table: "Reviews",
                type: "character(1)",
                nullable: false,
                oldClrType: typeof(Guid));
        }
    }
}
