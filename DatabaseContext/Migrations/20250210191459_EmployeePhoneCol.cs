using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseContextTier.Migrations
{
    /// <inheritdoc />
    public partial class EmployeePhoneCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeePhone",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeePhone",
                table: "Employees");
        }
    }
}
