using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedRoles : Migration
    {
        //add as const later on
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Roles (Id, [Name], NormalizedName, ConcurrencyStamp) VALUES ('1', 'Admin', 'ADMIN', '1')");
            migrationBuilder.Sql("INSERT INTO Roles (Id, [Name], NormalizedName, ConcurrencyStamp) VALUES ('2', 'Manager', 'MANAGER', '2')");
            migrationBuilder.Sql("INSERT INTO Roles (Id, [Name], NormalizedName, ConcurrencyStamp) VALUES ('3', 'User', 'USER', '3')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Roles WHERE Id IN ('1', '2', '3')");
        }
    }
}
