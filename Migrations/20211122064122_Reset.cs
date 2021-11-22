using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.Migrations
{
    public partial class Reset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Prefix = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CourseNumber = table.Column<string>(type: "TEXT", nullable: false),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Course_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId");
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_Staff_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId");
                });

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesCourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentsStudentId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesCourseId, x.StudentsStudentId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Course_CoursesCourseId",
                        column: x => x.CoursesCourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Student_StudentsStudentId",
                        column: x => x.StudentsStudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Name", "Prefix" },
                values: new object[] { 1, "Math", "MATH" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Name", "Prefix" },
                values: new object[] { 2, "English", "ENGL" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Name", "Prefix" },
                values: new object[] { 3, "Information Technology", "ITEC" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Name" },
                values: new object[] { 1, "Eve" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Name" },
                values: new object[] { 2, "Frank" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 1, "1000", 1, "", "Math Fundamentals" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 2, "1000", 2, "", "Introduction to English" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 3, "1000", 3, "", "Introduction to Information Technology" });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "DepartmentId", "Name" },
                values: new object[] { 1, 3, "Alice" });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "DepartmentId", "Name" },
                values: new object[] { 2, 2, "Bob" });

            migrationBuilder.CreateIndex(
                name: "IX_Course_DepartmentId",
                table: "Course",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsStudentId",
                table: "CourseStudent",
                column: "StudentsStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_DepartmentId",
                table: "Staff",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
