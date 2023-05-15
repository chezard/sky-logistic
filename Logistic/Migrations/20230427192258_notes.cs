using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class notes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CustomerLegalPeople",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c7eca0e-5baa-4352-8cd1-263ef9ef2aa9", "AQAAAAEAACcQAAAAEFTFqxCk8ZbLpoo13HaP2Qnz/iAndOlrcGR311p/o4zOJjr/sCDao7dnFTEazzQbrQ==", "41003945-fdc9-4a68-b817-1acecf2eff57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1102852-c6b1-46f6-82b4-1003c904e3f0", "AQAAAAEAACcQAAAAEJrGNeec+Eyz9lrzbiXTUP1t8ocO51Z+diMUF+XfRXRVXiZbi5KtRQ0pEDWRBXyPxA==", "9e8ea306-6a11-4c80-8ac9-283ab683715c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6070bcd3-a70d-4127-90a7-e612a4386728", "AQAAAAEAACcQAAAAEPcmAzvlbQ0iLgLH7c95lTcJKic55nNMY2Js8Ek3w5zSW5JuU1405yaiuW8NUfT0tg==", "78763623-50f6-4d37-b57b-b1609951f503" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8e8dde8-4a7f-47d7-8306-23c0cd01c48f", "AQAAAAEAACcQAAAAEN61YXEZYhS1Ro4MbD14FBhq8TPt6mNVYdb8zlO3EEPER44o4ANG7+5BXhpsd7k8PQ==", "b8dd6cf1-4fc4-470a-a0a0-8d3c9f21cec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ede42a2-6616-4286-842a-4f3a07fced8d", "AQAAAAEAACcQAAAAEFsbldcX/i+pmdzmGklroxA28LeBaLsmIK91JiuieeA/JmWuEtxr3l+pfKafX2DOKQ==", "33fe8ece-2bf7-41d2-94ba-27872299b515" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "112e2b8d-5d12-4d86-add0-10717496400b", "AQAAAAEAACcQAAAAEIwhL4GoFSH+3UFdq46uvxo3oSB8XR/1lx9dEzIm2ASEQVuiIRxCR/sPXX2XgnxdWw==", "8cf51eef-364c-47ff-8d2e-a455f565ec7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fc77e2b-6cf2-457b-b3f7-273481e30cd2", "AQAAAAEAACcQAAAAEEADyFdDyOF5O562778iFz8G8w6tLhI79k/V5xVB0fKkpX2BEzGv5vrKOUCQQOc9bQ==", "7fd9f9d3-c22e-4980-80e6-209e16d92593" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "197c3d04-8412-4065-b5bd-4987fff81fbf", "AQAAAAEAACcQAAAAEOGWpf0pQKhDNSQnr/c7eMjAV5CpbfsKwxoau9RMIjgXY6x2pySUGhT8gVaESP9D8w==", "c57c7d52-0c7e-49f2-9b2d-cadc0cce8937" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CustomerLegalPeople");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c7b2594-d270-4557-832a-a951d09ca551", "AQAAAAEAACcQAAAAECqqVijs7KODzvtJ3kF1Ydn2GiQMzDhAMrKIKGi/z+qCG4FJuuaCxl6CNKyW/j5Gbg==", "797fca4a-ab97-43d8-96da-d086f7ba2a05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1877969-bfee-44f5-bd6e-57119b7bb9f2", "AQAAAAEAACcQAAAAEDhSFa77GDaPcmSRLei1y29GyG+jt4RrWvpZ3H1HJWXQSFOjrpbfe/hFZO8MiZElYQ==", "603d7802-b58c-4496-8983-ad065fae2ed8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e147acb9-6f2b-43cc-b96d-55371b39756e", "AQAAAAEAACcQAAAAEN6Lyxe7le3Pw9Yyd0hpULSgb+qHnXuk81mDT+6WCDGpyRjztgbA2oyV8YEt/Q+voQ==", "866e756d-246e-4fe0-a576-7259f06dcaa0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3bb70fd-5044-4b29-aeb5-9e43e5ffacdd", "AQAAAAEAACcQAAAAEGuhSP4quRyukOJvrQv811D/4YvS/LICpApd+bd7rmuJpZYTIE/L7mvF5Xjw+uy6Kg==", "c2c11553-2747-4135-85aa-f27cc9c1baa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "249c40c0-d8e7-4cf0-b9a7-251636772ba2", "AQAAAAEAACcQAAAAEAAqZyoDIHbeneKo30LZY1EqX1TLbIlWuEKIHGKEBpjW8ew2Z83s2ph6mUqundAHsg==", "e823419f-34cd-41ed-9cb3-9dd1a52f07ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b77dcf02-7163-4ad2-8c0f-8e31410ae453", "AQAAAAEAACcQAAAAECoGMr1j3I9ja6B1MNSlrT+4d6YCJZYOph2PkKUHTw0u4lqejadvOYxzrwU0Lgp5ig==", "ee2b5a8a-f68d-4aea-b6dc-c2378828c223" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fec5b1d-ec3c-4460-ae78-376c0075a5a6", "AQAAAAEAACcQAAAAELvlrBJ8dJkfotncIyptxYpIyasallJlEzrab7prsHKndbaucCnLrPk1k/DiyZ0EYA==", "c7c5260b-8c6e-4714-83b1-8b20b94cee91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57ba93ad-f875-43d4-941d-9f37facb498b", "AQAAAAEAACcQAAAAEFxnJl14masURCPXoxjCtUeiK191APn/W5FC3Sve8png343GckYR8TmcemVUabY3jg==", "4fceeabf-66a8-4165-a738-0b2b539862cd" });
        }
    }
}
