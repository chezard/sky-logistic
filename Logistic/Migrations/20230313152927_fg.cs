using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class fg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da2968a5-3ba7-4089-a20d-854a2fd7eb8e", "AQAAAAEAACcQAAAAEO8DSe5etu1fkN1PGtPwwNPweNmGJYSloWJUg/IDlZ2/yizfLH9T+GBre258G/F6qA==", "ed80c42b-d38e-4dce-8481-cccc3168a5a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c6be959-d287-406d-9022-668d69f2e5c5", "AQAAAAEAACcQAAAAEC5HsgdiTtjpITfZ7OfiKloqG30shW7V3XUsNJ0XPp8rFaHV+/Lb2ILi6ZfWXZuZ8w==", "906f3a4b-74c8-4542-9d65-d9927b587e4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "198f05ac-cbdd-4371-b0e2-7db28067132c", "AQAAAAEAACcQAAAAECY3dFfKBqRnIzw6HmJdYEXvjc59XDRxurdDnkNLGPdqxv4AeEn3YPTSB48VvvYwew==", "179cf9f2-dcb4-4970-ba97-af2a565e4e2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "882ff465-1087-4472-89e4-053384b1dba6", "AQAAAAEAACcQAAAAEKLQw/GDav3aq+CRnIG1erQ7ts/rnl3RSjXWIUUNGl7VqP3YJTwH+DIq16FNSb/7/A==", "e6b48698-9c5d-4fb7-9199-ba1b9bb659f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "132d89c0-2db2-4d9d-881d-522114634d2e", "AQAAAAEAACcQAAAAEL7xFM8B2Nm4KXaX3QPQ35H/aHP7BfiqPBhtb0kfdyR/1XlM3wLuRc3SujA574A4qg==", "3abc178b-c48e-49b4-ad9b-d140280a84d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9bd91d9-aadb-4faf-ad9b-2d3c0b8785f1", "AQAAAAEAACcQAAAAEMKRahLLLuGQdoQ657Y2JoodcY2btBLJl5mi2Mb49hnUqALyUXyqjOsPgOTHdN5XqA==", "cc1f5c36-959f-40d9-b737-da789913143a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76307c4d-723e-496c-bf62-3333dea88c16", "AQAAAAEAACcQAAAAEEVL/zkzoS1+WPJJdjydia8W24pCEFncsH6VdC2Ss2nbIk1wq5a6r9VEhnJvkMvEdQ==", "e4b140f3-9311-4743-b01f-bba03da21a14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e676e49d-28e4-470d-a05b-fbbb48626ec7", "AQAAAAEAACcQAAAAEBVdfEQZzUNcL5V1AnosSkfh468y/xoojI96p2ieLiF8LMSpNKFmFB6nwHx/Nw0Trg==", "565aa38e-e5a8-4719-8367-7ee7e7b2bd4a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "201ee823-9155-41ff-8349-69527e7705b2", "AQAAAAEAACcQAAAAEIG4ATahcARsDtq8dFErF0IQDcUl2FKtoEh9TUZ7K8dol+CTy3FBKcmVtg5CJEMY8g==", "53f8d78b-37ae-40a4-b323-0a1b1506a529" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "165ec2ff-579b-497e-ada1-c45f0a208f4b", "AQAAAAEAACcQAAAAEKRriQ5YKpgGz5GGslCLo1rGtW6Cc5PuZkKGW0YCctd1A+VJxNqSl/r4pRNZotMYzA==", "e0c5b514-357c-47ee-9631-a1b0f09c8b67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23487f3e-0ec9-46c9-8d43-983176eefe9e", "AQAAAAEAACcQAAAAEClm/1MQTty49w4hvwaW2AecL6AXPjFzKiZH+YKO845L4FW7lTnE9zVhqWBkjcuoiA==", "15b8589d-93e2-4ee2-98a3-db1341825dc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6024cbc3-fbc1-457d-be1c-430ad6b30974", "AQAAAAEAACcQAAAAEA+bDPti9lqdx3WFaNW+97yohSP2FPjU+uFzqm/DLz+5wZO+EXUiZFAYdoHM0BkLbg==", "87a2dbd2-e9e5-4f4b-89fa-27ea2aa9d8e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbbb8ac4-6dd0-4d24-930d-911f494be4d8", "AQAAAAEAACcQAAAAEPuU0kBFkTuUm/f7+3Be0PU6MF+Om6LbXWB1+fBOPFDYUvRjtrgNo4PKwb1xIfNi8Q==", "a79caf12-44c1-4522-83d4-b5e5ce529e7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0cdf55b-06d2-4b87-9a46-6a036c515e18", "AQAAAAEAACcQAAAAEHtbw+mD9NhWuM9nifpSOIu2AX6JScVFNa23HZSTY4ebCe/8rhruKlRXDtjhSrDXDw==", "d8f20299-c594-4fce-973b-abe4a944c4f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "931cf98c-b27e-4c7f-a5b0-c72272845b83", "AQAAAAEAACcQAAAAEJGsqTvzGcdlOB4X+w/54VG+d937ysJ0LY/Zk0pUwA8roBpnalQN9aIIAHfoA2Xpsg==", "bf5b6840-2b4c-4c1d-a8ae-dcf4d45e37e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3b32f31-1b34-4fb9-8727-62e39ae1588f", "AQAAAAEAACcQAAAAEHhpBxF2NLYHG3stDpy0iqjCmjuuO8jLGDUHxzK+utKUFFd2eA/nY8nqL3poJObjGA==", "6d5e337c-f5e3-431b-b2a3-461905cfadf9" });
        }
    }
}
