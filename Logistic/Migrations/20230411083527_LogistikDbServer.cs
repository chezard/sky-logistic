using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class LogistikDbServer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60a10557-2408-4dd7-b584-ce436e4d6fb6", "AQAAAAEAACcQAAAAEPHEnT4ginNDOjVB33JDtld57ns+KEogSQFo+ca94N8K2b/Hk4NcDAqtvaQqNfq03g==", "e84e94e6-bbf9-4164-bbf3-25e91be20ed6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2aefc2f-dd16-403f-8e1f-1158e34e2de3", "AQAAAAEAACcQAAAAEDptYg2O9U9X0r1y2gVpMwSZ7v/rAoiBUshIZ+1YYcx5RfAtpt9B5h9YfN3rRUrxDw==", "aec2760b-bb14-451b-b226-4adb0ce6ac99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b364f15-c7a2-4614-9bdd-8eb391f342ca", "AQAAAAEAACcQAAAAEJoHI9PGhmO11ZYT1jKbNiExbaOqgGZt53n1MfEdDa2EzlfOT1Qf2198eKfBd4answ==", "6edb5bed-54d5-479a-9d63-388c30e3c436" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9f75ed5-e4ea-47b2-97d3-842cdd6a492a", "AQAAAAEAACcQAAAAEG1ilRf98YA5jfdpL0BiOYdXqFdEsxQCs+tLjsYMUi22PE0QxF87mD8Ay1H7j/Zm7Q==", "901d2cf8-51ac-45b1-83ad-e142063c1ff2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04e2b562-4004-4e33-a565-176a3607fe24", "AQAAAAEAACcQAAAAEEJxkNCZbUf1ynuTVYY8lTf/KcYs3FO3sJZHw4SVrXqTeEb4UDYI0JwnqgDPG2wg3g==", "20cac38b-0c26-4723-b1db-bbb986c77696" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a1e4af1-50c6-41cb-a671-85680a65d6ef", "AQAAAAEAACcQAAAAEKUdcZBoVPaZ/+Y0DzB53MzrGryMmfe80MSD4KRbBwcNTY9ZtUDef32e9NMp27HAjQ==", "a47b4923-ed05-437f-a0dc-252d7e1586e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53e39442-1017-4899-90d7-3dc4ac7690cd", "AQAAAAEAACcQAAAAEPCzZn0ZoboNHBhpPtMbV4+y9vU0asa8Kess0DUMK6KvErltPHlKgNlid/AgY0elIg==", "738a6fee-f47a-4403-bfbe-20201188358b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd1a2acc-3154-492d-bc67-ebf13bdbe5a7", "AQAAAAEAACcQAAAAEEIaLGHJ7xQH3qEM57La29ALE8ln6R1Oz5FzasvAYdLch7qeon/KyiJeFpMWpiCkgw==", "231c6874-cc40-4cbf-adc1-64071d9adf1a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
