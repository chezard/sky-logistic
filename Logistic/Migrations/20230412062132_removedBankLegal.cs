using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class removedBankLegal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ad8e459f-5a34-40c7-9e36-34e1d12931ed", "AQAAAAEAACcQAAAAEFjVkamCXScBrL/lbWc36LZSsXidaEdr+nUUrcV4R0vf1JpM7Sws3Cq8v1oT4l8+Hw==", "89c020b2-9ce1-4038-8f65-4b47764d4f4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72f14663-e69e-4406-9621-c3ae20513981", "AQAAAAEAACcQAAAAEGczvJPt52FGgC+oKszAdKo3jqhtxRYvwJf7g5lWc56Z3QN7tcyE4p7EUV084FleUA==", "8197e8a6-0d35-4f69-8e8c-b7069e544fc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1227541-fbf0-4862-a7bf-571ea15e5205", "AQAAAAEAACcQAAAAEMJGhD7AlDzdpO+pPeLN9NlXJmDRnsc0Si+OFGKN9MHjb4hlTMxG4W8lx2DXxOGyYA==", "d4f48d61-4968-4d10-acbd-d3ea08a6c4f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee553e18-a166-4964-88e3-4796d203ca33", "AQAAAAEAACcQAAAAEIi3NMp4rXH6f5VIPZtn8yDqjcdhidVJpdI67hBRHmxbXAv5l5U9Ujtrxv47GEEmrg==", "923eb25b-728f-449a-895d-e60adaabd898" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "299c4f83-f160-48b6-903e-5c363eb3c9b0", "AQAAAAEAACcQAAAAEC4h6NXaKA4/Z0g9SHWo1QT0U//TNs09n6+hhMVPzvxkh7IuUG6q+Uufxg+v/4WaKQ==", "3775614d-9c7c-413d-9ee2-22f0b8b2312d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e84cf4d-240b-49fa-9209-aeb16370c079", "AQAAAAEAACcQAAAAEIlDEw+E4bJycZJT4jeIHvzqOhyMIO27FKFgFo3j7/EcdI/en4Cdg30JNVM9n4snMQ==", "1caf7e26-ee2f-46e0-ba39-d92b8f859e77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a813d535-5809-43bb-ab54-5ab0840ba3c0", "AQAAAAEAACcQAAAAEO0r/2mTYnseuI+I66Pkt/2ONAizNNa2mlFC/OKgJKbv3GMJNgeHd1WSyStUErgUtA==", "a77c4dbf-ba8f-4c6c-a389-2b2091a2344d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e98bae0-fde2-49ef-b588-f2e01be44516", "AQAAAAEAACcQAAAAEGJmrK9lLKlskJWDgKa2bCmatPe3soX+JqPnOne0IwN4mWGdVsLsHPRolnLQFF+c4A==", "1f4ae193-54fa-4faf-8b8c-1dd56ef125ba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
