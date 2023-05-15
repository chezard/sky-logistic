using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class correspondetBankInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CorrespondentBankId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d623ef0-cb5d-4d3b-8c66-51e9c312d96b", "AQAAAAEAACcQAAAAEIvKnP/I/XuZ69kpOunq0UtV/ctSzoKVx+sLjEruV2ejF0MFBd+u7fdCtapn2etpFQ==", "c5366f47-12e3-4df5-99fa-cf3779587516" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c7ed58b-662a-4749-b43f-564d38c84d07", "AQAAAAEAACcQAAAAEGCFkJ4X+j9/xM9Fmp/fTN2loHtum4RrO0bzK8b2px1vpLQ+tcW72a/BUFOivkbH4A==", "ee079643-4970-4d57-92bc-b27c6c6c60d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2653a0a-b2a4-4b2e-a4e5-678c8ae8b34b", "AQAAAAEAACcQAAAAENDjhGclQw3z6j9n4aUUXOifIPWG2B6aulYgj5vP3/zds+IGeUQUIDWLnA5Y4YTsPA==", "de9666ca-583b-4981-8976-de1a1fe8f2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a76043b7-e16e-4156-84b7-a8de0f0c710b", "AQAAAAEAACcQAAAAEJjm4eEPd/F8WZ0fO2/tbSUWStNXhbCoX7W8fAGmDVgpQ9vR1XLs+vQM8E9V9PfrbQ==", "17a177df-734f-4a37-ad0e-c5ce56da7ee3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2fbec4e-6cfc-47b9-9171-273c134dbf94", "AQAAAAEAACcQAAAAEAIGnDnzMafbGV+w0Gve/iab2Yc6Q05jvOk385S7VCLwV/TytFL4brkd6UDHJ6cSJw==", "d6fabf12-444f-4fd0-8230-f447785d8e1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7485c24f-c232-471e-b4ba-4fced4a6c5b8", "AQAAAAEAACcQAAAAEAJ82/yJW9Hj61T8ibYNQge+FQLizhCG8RpVHTP2DXL0x6iD6H5JMvlVDYK1gHmTrQ==", "f92e33c3-109a-4a9c-8943-93b8373dc2f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23f7edf4-2e33-4efb-a48f-d5e3491ad3f4", "AQAAAAEAACcQAAAAEIMn+HbujozGVh5H3HBucxM0Lc2EwgMtapTBqqLSH8Rb+bumLimVSZFJMJRkDBpvzQ==", "b7b1c233-8ff2-40c8-8f19-ee260a3d6000" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ef475fd-bd0a-4234-920e-fc1cd1fa169e", "AQAAAAEAACcQAAAAEBBywA/Yi3PxNYcToXPbL9RVeq5rADjzjxSUfZ39qXEftUjdPD7XviDfMH/JYJ8NiA==", "cf9b28ac-033c-49bd-92ec-77a59fe05de6" });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CorrespondentBankId",
                table: "Invoices",
                column: "CorrespondentBankId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_CorrespondentBanks_CorrespondentBankId",
                table: "Invoices",
                column: "CorrespondentBankId",
                principalTable: "CorrespondentBanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_CorrespondentBanks_CorrespondentBankId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_CorrespondentBankId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CorrespondentBankId",
                table: "Invoices");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e149285-ab4b-4fad-a100-040a429715bd", "AQAAAAEAACcQAAAAEF9fkNfu4faH5jLpi1EigRqFxeQk3IVSHLIp/wNwM9KJ9VlZDeY+9rcnt+TRZz7c2Q==", "8feaaa9a-4f92-476e-b2bb-3f40b12e2828" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2cd853b-d23e-4f3c-884f-543c90f6e3f5", "AQAAAAEAACcQAAAAEOkYn+o5bBUXFCFvHMg1fFizJbb/4hY4SV61JUGZ8QzDeAAd4m9zEhGxoKj9RZwJ2Q==", "d9293771-6897-497a-b449-2ed32c37e093" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48b1237e-cb3f-419a-b3bb-6d149b3775f6", "AQAAAAEAACcQAAAAEJkcwIV0RqCnIJe6Z256pD6lQBjd82SHV5CnZVk6Y0wHa7Ir7i8iVXe+N/A170pWsg==", "46890ddc-2ae5-46f2-bdfb-85f17d1ef7ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40662d2b-6111-4b79-9b5f-f037d7d8f9ec", "AQAAAAEAACcQAAAAEDHWifuO/DaRM8iGseEL/bGeUY7QnOkisid2UasagzlXT33ktxDDs1KD9kjML5UH5g==", "a0d04378-33a1-48fc-a42f-5d2496412915" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8a75ffd-b744-4446-861c-327c566b982f", "AQAAAAEAACcQAAAAEJxRK3/+m2ixr+Y5ziRTVhG9yhy2WwQ4rNLIvdaCck68liQqhEoNuU3PeNDbX1vWZw==", "77efce20-9d33-455e-9b75-1eeb2cf6ad97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaf93265-8295-46b6-9e10-00e0f9fa7fc1", "AQAAAAEAACcQAAAAEDcdkEjiTCMbltt2wKV9MB1dwxWpjiplSf5zl1KiRmHC5zSLvnu0Jm3zFCapTzf4aQ==", "1cee5b02-a636-47a2-83a8-8dfe95517c0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "704abaaf-54bf-462e-80d1-2199e0f0a3d7", "AQAAAAEAACcQAAAAEDAXBWJQukbx+mYOZER+0caChiD540RPclmXh/RLguFKgLzM1SO/kTuV/+gqhMzj4g==", "7a9d4033-d69c-421b-a576-3486924de363" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10127001-2243-43b5-b106-d4187d841ce8", "AQAAAAEAACcQAAAAEBlCfdp6MmBtpjccZ1BvKmBW1McSBqf/UZgBXxvcUMrLTw3aMOkLjhT/cE1qeXKsTw==", "f99f02a1-5b5b-442b-b9b2-af2d4750549d" });
        }
    }
}
