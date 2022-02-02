using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication4.Migrations
{
    public partial class ManytoMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectTeacher");
        }
    }
}
