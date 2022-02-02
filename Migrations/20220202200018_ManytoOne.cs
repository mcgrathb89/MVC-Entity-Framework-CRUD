using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication4.Migrations
{
    public partial class ManytoOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectTeacher");

            migrationBuilder.AddColumn<int>(
                name: "SubjectSubjetId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SubjectSubjetId",
                table: "Teachers",
                column: "SubjectSubjetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Subjects_SubjectSubjetId",
                table: "Teachers",
                column: "SubjectSubjetId",
                principalTable: "Subjects",
                principalColumn: "SubjetId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Subjects_SubjectSubjetId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_SubjectSubjetId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SubjectSubjetId",
                table: "Teachers");

            migrationBuilder.CreateTable(
                name: "SubjectTeacher",
                columns: table => new
                {
                    SubjectTeachersTeacherId = table.Column<int>(type: "int", nullable: false),
                    TeacherSubjectsSubjetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTeacher", x => new { x.SubjectTeachersTeacherId, x.TeacherSubjectsSubjetId });
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_Subjects_TeacherSubjectsSubjetId",
                        column: x => x.TeacherSubjectsSubjetId,
                        principalTable: "Subjects",
                        principalColumn: "SubjetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_Teachers_SubjectTeachersTeacherId",
                        column: x => x.SubjectTeachersTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTeacher_TeacherSubjectsSubjetId",
                table: "SubjectTeacher",
                column: "TeacherSubjectsSubjetId");
        }
    }
}
