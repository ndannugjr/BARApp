using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BAR.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAnswerSheet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnswerSheet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivityHeaderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivityDescriptionId = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivityQuestionId = table.Column<int>(type: "INTEGER", nullable: true),
                    ActivityVoiceNonVoiceDetailId = table.Column<int>(type: "INTEGER", nullable: true),
                    AnsweredDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    QuestionType = table.Column<string>(type: "TEXT", nullable: false),
                    Answer = table.Column<string>(type: "TEXT", nullable: false),
                    StudentAnswer = table.Column<string>(type: "TEXT", nullable: false),
                    IsCorrect = table.Column<bool>(type: "INTEGER", nullable: false),
                    TeacherVerdict = table.Column<bool>(type: "INTEGER", nullable: true),
                    TeacherVerdictDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerSheet", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerSheet");
        }
    }
}
