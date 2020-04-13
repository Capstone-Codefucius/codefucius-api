using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace codefucius_api.Migrations
{
    public partial class feedback3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ReviewID = table.Column<Guid>(nullable: false),
                    ReviewerName = table.Column<Guid>(nullable: false),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    LearnedSomething = table.Column<string>(nullable: true),
                    CouldAskQuestions = table.Column<string>(nullable: true),
                    QuestionsWereAnswered = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedback");
        }
    }
}
