using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'6ed2c364-c78c-4a71-80e2-1a76290438ef', N'admin@flairstech.ocm', N'ADMIN@FLAIRSTECH.OCM', N'admin@flairstech.ocm', N'ADMIN@FLAIRSTECH.OCM', N'admin@flairstech.ocm', N'AQAAAAIAAYagAAAAEFtmtzC+hAn9V8fQdZL00VJa1Bf7CXtn7GDOhehHh6wkV7zY6Nuh5o5g55QfkKQ9hA==', N'QVL2K2OZ7THHZXTYO6GHDHOVFGU5PAP7', N'd5ed42b8-925f-4720-8aca-06a5b2af6d0a', N'012366', 0, 0, NULL, 1, 0, N'Admin', N'Admin', N'default.png')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id = N'6ed2c364-c78c-4a71-80e2-1a76290438ef'");
        }
    }
}
