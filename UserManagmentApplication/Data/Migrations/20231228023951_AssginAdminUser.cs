using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class AssginAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(" INSERT INTO [security].[UserRoles] (UserId,RoleId) SELECT 'c82ffcbe-1de7-4833-b219-c802b89cc856', Id FROM [dbo].[Roles]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId = 'c82ffcbe-1de7-4833-b219-c802b89cc856'");
        }
    }
}
