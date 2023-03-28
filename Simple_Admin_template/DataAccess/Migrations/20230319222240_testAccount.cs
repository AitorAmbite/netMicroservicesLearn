using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class testAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1633530d-7028-408c-a66b-444ff1890fbb", 0, "7a3eb0a8-5dc7-4087-83aa-a0521c607b23", "aitorAdmin@test.com", true, false, null, "AITORADMIN@TEST.COM", "AITORADMIN@TEST.COM", "AQAAAAEAACcQAAAAEMZQXPF/diSw0IDOJBg94BCHVWwjkd25SN9R4+Ihj/ty4pf7CalhV7aWcXAQTJrgRA==", null, false, "ad92071a-a3dd-419a-978f-5b0de1f8974b", false, "aitorAdmin@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1633530d-7028-408c-a66b-444ff1890fbb");
        }
    }
}
