using Microsoft.EntityFrameworkCore.Migrations;

namespace EmploymentVerification.Migrations
{
    public partial class newData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyName", "VerificationCode" },
                values: new object[] { "Infosys", "Infy123" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyName", "VerificationCode" },
                values: new object[] { "Wipro", "Wip789" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyName", "VerificationCode" },
                values: new object[] { "TechCorp", "ABC123" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyName", "VerificationCode" },
                values: new object[] { "InnovateX", "XYZ789" });
        }
    }
}
