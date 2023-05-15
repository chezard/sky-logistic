using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class columnRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CorrespondentBankId",
                table: "CustomerLegalPeople",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CorrespondentBankId",
                table: "CustomerLegalPeople",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f08eafb1-ccfc-4d4d-b336-8ba7e9459518", "AQAAAAEAACcQAAAAEDkuNsyRavpmF4ynqVqs9gmMbPtC4M/P67sZrpkAYCfzQD4dX98BnPm7iempKWubew==", "ad76506b-899d-4d50-839a-303242b621e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "274a2233-6f1c-4104-8754-2bd706af353f", "AQAAAAEAACcQAAAAEKhVEZ3W10m2PTl6JcEhW8o47/9eivqTHinPvEzZJnDuE5kSyuefHmTuUkB7Wwlp9A==", "4a128ae3-0531-4ab0-b6b2-998e5130dbc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d63bb3cf-4c91-4208-976a-643eb4ea2e67", "AQAAAAEAACcQAAAAEJQXP5SD6C6lTbeHbHqFEUyb8WsJJs4oAuDmJsGRtZH0TNRwFlu6XLFod204L9N1oQ==", "5e257bbe-d95c-49e8-b98a-928a57122b5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5723f961-701b-4cc9-b06c-07fb6004894e", "AQAAAAEAACcQAAAAEMyQYetu8N0LMCW4pLZ3nGpgGMbg2Qw81fwMzucfHDOqHprmK2gSYjsZvh08PhaRPw==", "c6e6aa7b-3344-4545-ae1b-43158ee5ae4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d97a5672-5a3d-49de-871f-3434e329bc13", "AQAAAAEAACcQAAAAEOalrqjNQq/XYDuGsVPYoAL0chIm0WqD1VUBc0CsIuEJ+gUaAjZ9RFfZBy54oT8/NQ==", "b80d7525-a38c-4fb7-887b-22f5a02892bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60490d33-84c7-40fd-a436-e8257d2d4fc8", "AQAAAAEAACcQAAAAENfOZtYrKfIRFm0jkC8dG1PxWAPwq0z9ABxkOBDdi6tX/9kWhg6KN2La+a8dG2FFDA==", "a05da8c4-575e-4788-9185-4b58edc41b4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b92463a-027e-4455-9623-5aafb8299df9", "AQAAAAEAACcQAAAAELvZ7HjRw69asp10lD2P3Hi7yOV5e1NJ7HII3iMxXIGg/y7qViBd1fRxM6M1qzNwPQ==", "7df4f47d-48bc-4b57-9abf-4cd757460c7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2318da7f-6ee7-4aa5-98a7-796fa7a9812a", "AQAAAAEAACcQAAAAEM0nS7fIIsajStgp8FyPXY71hqpozqZD7bAytVYjWxeu1ywqT6iMoSKAM5WXg+uiMA==", "ecea9df9-dee2-4ba8-90d7-cf31af448a0b" });
        }
    }
}
