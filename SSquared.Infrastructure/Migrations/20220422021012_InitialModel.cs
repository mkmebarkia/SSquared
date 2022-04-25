using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSquared.Infrastructure.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    ManagerID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRole",
                columns: table => new
                {
                    EmployeesEmployeeID = table.Column<int>(type: "INTEGER", nullable: false),
                    RolesRoleID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRole", x => new { x.EmployeesEmployeeID, x.RolesRoleID });
                    table.ForeignKey(
                        name: "FK_EmployeeRole_Employees_EmployeesEmployeeID",
                        column: x => x.EmployeesEmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeRole_Roles_RolesRoleID",
                        column: x => x.RolesRoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "LastName", "ManagerID" },
                values: new object[] { 1, "Jeffrey", "Wells", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "LastName", "ManagerID" },
                values: new object[] { 2, "Victor", "Atkins", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "LastName", "ManagerID" },
                values: new object[] { 3, "Kelli", "Hamilton", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "LastName", "ManagerID" },
                values: new object[] { 4, "Adam", "Braun", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "LastName", "ManagerID" },
                values: new object[] { 5, "Lois", "Martinez", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "LastName", "ManagerID" },
                values: new object[] { 6, "Brian", "Cruz", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "LastName", "ManagerID" },
                values: new object[] { 7, "Michael", "Lind", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "LastName", "ManagerID" },
                values: new object[] { 8, "Kristen", "Floyd", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "LastName", "ManagerID" },
                values: new object[] { 9, "Eric", "Bay", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "LastName", "ManagerID" },
                values: new object[] { 10, "Brandon", "Young", null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Name" },
                values: new object[] { 1, "Director" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Name" },
                values: new object[] { 2, "Support" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Name" },
                values: new object[] { 3, "IT" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Name" },
                values: new object[] { 4, "Accounting" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Name" },
                values: new object[] { 5, "Analyst" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Name" },
                values: new object[] { 6, "Sales" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRole_RolesRoleID",
                table: "EmployeeRole",
                column: "RolesRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerID",
                table: "Employees",
                column: "ManagerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeRole");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
