using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class CustomerAndEnterpriseCorrespondentBankDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c51bd57-d0a8-4857-b156-5610c2f6c218", "AQAAAAEAACcQAAAAEL12i8vk2vJbzeUuPj++iIDNTPDBK9qmpYCWrgX03u5ERCUTDATjB316eSXb0bYGYQ==", "68439f97-b832-48ee-aa7f-239da13195ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e69ffcb-4e0c-4986-8aa7-a5858ba6b04f", "AQAAAAEAACcQAAAAEG+NRiZXoM+JNiFf2CbjLPAXkrG0ILe38MIWwjq+x5BBqhwUTm0SCmi9lYeEFFsa1A==", "f384ded1-4383-487f-bcea-c21e23e9e3fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "279dc0b5-f115-469b-b8d0-311c3306e679", "AQAAAAEAACcQAAAAEIfFrrLDmP0q2fYecZj4z+RVHpPVBIRjGVqPjYmADVx668oGNpBgVccu8lrgYNOSPw==", "764eeab7-3e75-44cb-a925-bc9ae6f73a9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eee3240f-4a2c-4917-a539-c2481c4e0d0f", "AQAAAAEAACcQAAAAEIu46iK1kodr5KPdHHucTqMbPzErfBGsunlQQni2IAWQhQHAON5uQijcfgi3t5Dnvw==", "20fe84ff-050a-4fc9-b050-a4925566a0fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bfd3b37-a080-4310-83bc-8b44efe5a08e", "AQAAAAEAACcQAAAAEH8+41tbpZsBNjCJ7s8JQIfQ/tSZgRch+ddAh0hG6agNfXM0x4SqzFB0bh4dC7Mzgg==", "67a51c88-9f32-4eeb-9edf-f62c8a6fa0f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98a3c17f-1d0a-4eb9-848e-2e07be5062da", "AQAAAAEAACcQAAAAEGUwT6587khUPsmdYhlEcEwVqwm/1lLMpo4YhtChLFz89v+rshMvDHqB4wHXgvRACg==", "aeb41adf-ec8a-4569-8b3c-24c58a4b17d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91d7535a-1133-4880-8402-31d08734eb81", "AQAAAAEAACcQAAAAEMZx8ZEn55m0wj6SAOBsYl7PEpHuqQkG/ak1xlcbv983loXvcxwNmXd3JBT4Q8FdFw==", "168af20b-b369-437a-8485-a70cd36596a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48faafb1-f012-4068-9961-7e0153a93cbf", "AQAAAAEAACcQAAAAEJUyNZE8OWwfgLE+md1tn40eTowXRt8Rg7drtTWRpd/RyA/n6irsGxDaiV3tyBo3gA==", "155c876f-2b60-463a-bd1c-f0525929338a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e24ffe8-8b4c-49d7-8a35-3aec8f0aa1fd", "AQAAAAEAACcQAAAAELA97QlypD3AuuEIgv816sbLLqpnsks/5dOp71+bXqGIOlz7spRc0ofPW3gxOKskMw==", "69057a94-be5c-47af-8284-3b9032020e5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a5b6259-1af8-41ad-86e5-ad446673b6b4", "AQAAAAEAACcQAAAAEBV1iwW/9Fu/ZkWyN1kzuCGR+KJTzJ0xiXqdPsags7mvAE12AutWhfY57A7wqQdWgQ==", "e8191338-1cc0-4d50-99fe-8a9524d3bae6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2b9cc7a-76cb-4186-b248-86982a0cc0f9", "AQAAAAEAACcQAAAAENrmlJHl0PwR/h3EA6nu5gnSKytHPJ4TzmMI7yP4nT3WfDclRTJE7XmRnWw6XB13hQ==", "90a8faa4-44da-456e-97bc-04a01039be35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12e05ccf-eb34-4316-a6ca-2297c3ca0b3d", "AQAAAAEAACcQAAAAEAyvm7YRko+0wgWRdSPHO7dZPZ6HrU5GU5jKvS+cz7xJK/lCAEAxbGepAazqDo0fuw==", "b3abc8b4-9570-4a7c-8fc2-8a472d9782b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36cbab2e-af45-4607-a6c1-47067d149c7b", "AQAAAAEAACcQAAAAEAKNZhveJ9VQU6ebaaC3NuLTeZteK8EI8q0QyWsJbZD8okvoos3ul2enq6kYRlyk7g==", "120595e7-67ad-4ba8-b5f7-84e5c621737f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c01c634-d01f-47b2-b1a7-1cadcfae548c", "AQAAAAEAACcQAAAAEEqXGe8whuYP7ZDA0ic12EtZL8e0l8HySCcMrQKG/1xK0jicrquzap+xhk7b6it/Hg==", "6516df6a-69a0-45ac-baac-3cc7f4cffc04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cffd0fc-23ce-47a2-bcc9-db35a8d53081", "AQAAAAEAACcQAAAAEOBztfjO6YXactj+lP3FbhEEJhkisbV8lmuwZxJwsY00oi6AEb5XgZc27hWhWLee7Q==", "2c849867-3cb8-492f-9772-006b0295312f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e800f53b-3c9e-452b-b3fd-cac2efd18939", "AQAAAAEAACcQAAAAEFK2lrNrK1tz8iiGoX3ydlZhaGICKv6/VPTAhtZ6P9zY8q5tcf02syUIL3gTqCIvWA==", "4f870b03-997d-4279-83e8-6df748b918b6" });
        }
    }
}
