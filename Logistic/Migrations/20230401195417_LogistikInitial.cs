using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class LogistikInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbd170f5-0da1-4fa3-9659-71c390087293", "AQAAAAEAACcQAAAAELWI++EIYt1Dqma7HQsXZr4NZRzoPnwB9PTdzx0YJcQlx0K9ntTXh9q1lKJsp3f2jQ==", "6db6b0cd-e7fc-4a61-b2bb-98910631c7da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18f282ec-1dbf-425c-9925-eb6ea78f424e", "AQAAAAEAACcQAAAAEJTprh51gDDLTm32+EGiXmXe74EQQIEFoTWGmgqmk4QAqgidlJhnOJE04ZTJJfJ7Pw==", "abea1a9f-d0fb-482f-9c38-801dc235bb18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f6714e9-63b6-488c-8a76-17c71488f243", "AQAAAAEAACcQAAAAEH0Ps5ttSPLBXiAZFdXxBpy16w2ALrAmIAGOSb1ooD9rrotc8pyIhbodUTVWJXmqUA==", "dab7da3c-d6ec-4c83-add1-4fd410c6b5e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00b61671-20d9-42ef-b301-60a16d505794", "AQAAAAEAACcQAAAAECKHVBS67sFzVhCh0CFORmMN3aiftuwT5XGyaksH3tJQcTCqGgJYuDKu9spJj3+6sA==", "24f22f6b-1149-455c-be1c-1850b0962bf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "543809e8-1570-418f-bc6e-4243bbc01610", "AQAAAAEAACcQAAAAEHozHxAubd3cHyS0q8DR9ZUln9iXhqvHcU+UIf9rh/xP/PZhVN3+VrW8KSNAvkkqaQ==", "3b6f5704-fae2-4320-9f78-4eb69fd9509d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa87aee3-0b57-4765-8528-78d6f76ef801", "AQAAAAEAACcQAAAAEKBeY1e3b0vEv9pir/zyzE4RGBL+VprCwsJ0NRANliZqPlRWmWyVn25ZPsyoH4v8NA==", "e0f2ac0b-c227-49a7-9f33-f1f9554937df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8600caf-f55a-407c-ad90-8d2f1644953c", "AQAAAAEAACcQAAAAEMhqo1DgYQLLmTyuHCt+5y1Rm+8BMAMLD7Tk5wufME0lDu/vCw4VMczwvmfr+5zQCg==", "e590d3cc-d0be-42af-ac21-226b2aaff72f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4127e466-d9e7-44f3-be03-3e2b79f52811", "AQAAAAEAACcQAAAAEIDtuh1VRMG4vDVZ+5Kyh29Usn25IFFTfGfl4BZ/b/6qZD+xd7NCxcFyNm+zlWzP5w==", "6f94daee-406e-4da6-a74b-122da7b567b4" });
        }
    }
}
