using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class transportDocumentCustomerLegalPersonId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerLegalPersonId",
                table: "TransportDocumentTables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c315d721-3568-4a58-8ae1-ce99b301fe88", "AQAAAAEAACcQAAAAEP2EQ0VxHN65+1uZzeoZvNA9t7tneUSBFq0W7hVxc/+ZF1ddLcFYvXWa/IGLA1N1xw==", "ba774703-07f1-4073-9f52-25ef62183482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a51e87d9-751a-4c96-9d98-a352e4ee417f", "AQAAAAEAACcQAAAAEK0lP3rGs51NybuJ3H06my2BmxeBY+S+3OfstrnuLhOS/8IW8wWMp0bMfBwRAlquuQ==", "d1ad94d7-7671-4c38-88f3-659bac3a953f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ded33d92-9cb9-4c22-8516-d7d96c754fec", "AQAAAAEAACcQAAAAEFoGXiz5l11dUsJjZO+nl+sv3lMCOY1nnVSfphe/KQ7xf7/49/RUD53/w0l/GJ2VRQ==", "e24b5001-bb40-4743-af22-ea7556f9b968" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59d88348-b58b-4a24-8c4e-8e99154f1523", "AQAAAAEAACcQAAAAEMpsztLY/5XUthPEY5SW847Se5LF4XsYBRAIx9+vx5mTPPBQxE2fEgBl6hwlZ/tsCg==", "76a6e991-55c9-4830-8da7-4639db542251" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "041f7b6b-36b4-4834-b4fa-138c5b53499d", "AQAAAAEAACcQAAAAEC5dLo14bV78tLZwxXnTucat4REvPg3+306kFkxubxD20Ukz2Kn9Q8eSZqzkFfaY4Q==", "51358ecc-73fe-4b34-ae0c-fd7077200c4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb98c8f7-5918-4537-88df-cf0c4c13036e", "AQAAAAEAACcQAAAAEKC8jMJgPQ0iI/a+u+R64yzc1vekGLMX1Wiizx8ucbK7SCvQEQGfwhOfXiyhv29Tyw==", "a8cc0f38-3a88-46ba-86e6-08951f6d22f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fb263a1-31d6-4a2d-a8e9-9996757b4b75", "AQAAAAEAACcQAAAAEOm91AzI6hIYl1CmWgcet2knWyweebly1aj+z4DNmTSJUm5IPvyZ2fbixBaXAP9eJQ==", "29c587a5-809b-49ab-ae55-d4c430cc42a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6faa09c0-c233-4c5f-9ef1-766410dfc58b", "AQAAAAEAACcQAAAAEF7Z8YQPIQO6ZAaDpqzaUJ+XCTkZiRc5mRVJGDB0I1UaPkUTxQH7YJzeNBxYPYsvxg==", "b4b51ba4-7f5f-4288-8734-57a3a352e9c3" });

            migrationBuilder.CreateIndex(
                name: "IX_TransportDocumentTables_CustomerLegalPersonId",
                table: "TransportDocumentTables",
                column: "CustomerLegalPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportDocumentTables_CustomerLegalPeople_CustomerLegalPersonId",
                table: "TransportDocumentTables",
                column: "CustomerLegalPersonId",
                principalTable: "CustomerLegalPeople",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportDocumentTables_CustomerLegalPeople_CustomerLegalPersonId",
                table: "TransportDocumentTables");

            migrationBuilder.DropIndex(
                name: "IX_TransportDocumentTables_CustomerLegalPersonId",
                table: "TransportDocumentTables");

            migrationBuilder.DropColumn(
                name: "CustomerLegalPersonId",
                table: "TransportDocumentTables");

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
    }
}
