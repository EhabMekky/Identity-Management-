using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'5116bd9c-b113-469d-8e9a-27e45f8d7f67', N'Zeinab@test.com', N'ZEINAB@TEST.COM', N'Zeinab@test.com', N'ZEINAB@TEST.COM', N'Zeinab@test.com', N'AQAAAAIAAYagAAAAEJuOCM/CubZMqAG6Yrq8TL6mh8giTx2VwmfaRfxppcWQOLUXxBeXvkRg4SENvjg7DA==', N'5VTMILNJYMNI7HOFIWCIP3F4OWVAOWIL', N'7e3bf10d-68b2-4e02-8811-ac2728fb87f6', N'12344566', 1, 0, NULL, 1, 0, N'Zeinab', N'Ehab', N'default.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id = N'5116bd9c-b113-469d-8e9a-27e45f8d7f67'");
        }
    }
}
