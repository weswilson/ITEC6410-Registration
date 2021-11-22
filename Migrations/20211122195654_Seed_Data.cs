using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.Migrations
{
    public partial class Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CourseNumber", "Description", "Name" },
                values: new object[] { "1251", "This is the first course in a three-course sequence designed primarily to provide mathematics and science majors with necessary mathematical understanding and skills. Topics include limits, continuity, differentiation of algebraic and trigonometric functions, applications of the derivative, definite and indefinite integrals, the Fundamental Theorem of Calculus, and applications of the integral.", "Calculus I" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { "2252", 1, "This is the second course in a three-course sequence designed primarily to provide mathematics and natural science majors with necessary mathematical understanding and skills. Topics include differentiation of logarithmic, exponential, and inverse trigonometric functions, techniques of integration, L'Hopital's rule, improper integrals, numerical methods, infinite series, and polar coordinates.", "Calculus II" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { "2253", 1, "This is the third course in a three-course sequence designed primarily to provide mathematics and natural science majors with necessary mathematical understanding and skills. Topics include vector spaces and analytic geometry in two and three-space, calculus of vector-valued functions, calculus of functions of several variables, and vector analysis.", "Calculus III" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 4, "2260", 1, "This is a matrix-oriented introduction to linear algebra through the study of systems of linear equations, determinants, Euclidean vector spaces, linear transformations, eigenvalues and eigenvectors, and related topics.", "Introduction to Linear Algebra" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 5, "2120", 1, "This course is an introduction to discrete mathematics. Selected topics may include sets, logic, proofs, counting, number theory, graph theory, trees, or algorithms.", "Discrete Mathematics" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 6, "2270", 1, "A study of ordinary differential equations with emphasis on linear differential equations. Topics include numerical methods, applications, systems of equations, and Laplace transformations. It is highly recommended that students take MATH 2253 and MATH 2260 prior to this course.", "Differential Equations" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 7, "1101", 2, "This is a composition course focusing on skills required for effective writing in a variety of contexts, with emphasis on exposition, analysis, and argumentation, and also including introductory use of a variety of research skills. Satisfactory placement test score or successful completion of Learning Support English and Reading are required prior to admission to this course.", "English Composition I" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 8, "1102", 2, "This is a composition course that develops writing skills beyond the level of proficiency required by ENGL 1101, that emphasizes interpretation and evaluation based on an introduction to fiction, drama, and poetry, and that incorporates a variety of more advanced research methods. An oral communication component may also be required.", "English Composition II" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 9, "2111", 2, "This is a survey of important works of world literature from the beginning through the 17th century.", "World Literature I" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 10, "2112", 2, "This is a survey of important works of world literature from the mid--seventeenth century to the present.", "World Literature II" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 11, "2215", 3, "This course uses short projects to introduce the student to the major information technologies of hardware, systems software, networking, web development, software and applications development, systems analysis, digital media, and database. Security and ethical issues as they affect the use of technologies are also discussed.", "Introduction to Information Technology" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 12, "2260", 3, "This course is an introduction to computer programming, logic, design and implementation. Topics include software design, documentation, coding methods, data types, data structures, functions, subroutines and program control structures.", "Introduction to Computer Programming" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 13, "2270", 3, "This course is an introduction to computer programming, logic, design and implementation. Topics include software design, documentation, coding methods, data types, data structures, functions, subroutines and program control structures.", "Application Development" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 14, "2320", 3, "This course covers the architecture, function, and configuration of computer hardware and networks, along with basic operating system software function. The students are introduced to network and communications concepts including operational issues surrounding network planning, configuration, monitoring, trouble shooting, and management.", "Network Essentials" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { 15, "2380", 3, "This course introduces concepts and practices associated with Web site development. Focus is on site and page design, page layout techniques, styling methods, coding practices, selection of typography, graphics, and multimedia, accessibility issues, site publishing, testing and maintenance, and site marketing.", "Web Development" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CourseNumber", "Description", "Name" },
                values: new object[] { "1000", "", "Math Fundamentals" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { "1000", 2, "", "Introduction to English" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CourseNumber", "DepartmentId", "Description", "Name" },
                values: new object[] { "1000", 3, "", "Introduction to Information Technology" });
        }
    }
}
