using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class BankNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CorrespondentBankGroupId",
                table: "CorrespondentBanks",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CorrespondentBankGroupId",
                table: "CorrespondentBanks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BankGroupId",
                table: "CorrespondentBanks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f94e105b-be13-4e8e-a715-60303d96b512", "AQAAAAEAACcQAAAAEDFoZDBp+siVkl9UjV3Wz+naUFWokV0Sv8p/cG7klqU+E44eEHUYJNhbpByBtdgJSA==", "f881a82d-76c9-4f38-8927-83575ba9cce4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2705ceb-c78d-45ea-b608-53399c02a505", "AQAAAAEAACcQAAAAEKOF/kZXrh9B/fe0Om80TQ3DkIB7IZkuZ8bzJLnbHJ2o/kcNvi56kjXZr8xfyfWF8Q==", "fd901608-5811-44a7-8cc3-45bcc8677547" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05034a8a-ea31-42be-887f-38efad1ae1c6", "AQAAAAEAACcQAAAAENVgwfD4W5D3yf4sc6NuObpcH/UvuDcixa1N7YlDhgwzIxENhExnK/oV9fa3wRhyfg==", "9bbd278c-4385-4962-a0d3-279a91c532cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dacf87da-67d4-43c9-b0aa-d41aaa5f0e28", "AQAAAAEAACcQAAAAEBcDc85MqCAhhatWestOn5NM25l4j7jRblcF6gihome7r7kQCcUfwgCk7QGRdcapAg==", "d855eeb0-ef7d-43cd-9ef2-b1299dc6025e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9444b823-0f05-4f4b-96d3-aeab9ad73b5f", "AQAAAAEAACcQAAAAECcbH6a3DRGRz54ucLsS8sGqtWC9YYze9xouFQJyT3TPtrQQPaghovbc5BCUibcbOg==", "f6357b1b-f40a-4d86-8b15-35150a6bedd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1271757-8522-4a96-8fb5-a7c4a7fde3b9", "AQAAAAEAACcQAAAAEDzU/Sq93aCyLQ2uOeL1aXmh8yuOXv2Yc36WylDuz7iBeAYMDO6UHJwSAcCxkBuRdw==", "6232f055-a20f-43c7-9fde-2b15b7ac86a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9314e438-177a-47e1-9c5f-6391e3a981e0", "AQAAAAEAACcQAAAAEPqt8PTMt2IVQkU1aChuAfR6Ea8OzdX7Gzh0Q58DwAW1pKBArsMi+pEiotAbK75JHw==", "2f5cae7b-c358-4ae4-a86e-48389e404106" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02a83ed2-2aba-4ce9-95e7-fb453bb86c48", "AQAAAAEAACcQAAAAEIQNtChgMJOKPz8l4HxcslyK+U4lMzp6x2xQLMz7WL2QiKre/FshQrpoT4qCyFzVzg==", "6e801267-7c8b-4a21-8b66-231edb5fd627" });
        }
    }
}
