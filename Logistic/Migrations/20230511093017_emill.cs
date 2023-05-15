using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class emill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Personals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "792bb980-462a-4bd2-ac87-49226ab2cf27", "AQAAAAEAACcQAAAAEBr4i8uesGwukEKzFsGoxOfHTUMrl9eD3Rp0jvJfGfon0cTURV0czL7FtJELeAdEEg==", "ea4af250-5c68-4a83-90e6-07458830bb12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0b46502-ab03-4c23-8410-f6b90c08a822", "AQAAAAEAACcQAAAAEAXRJo5OSogXxZGj04Uj5CoYx1nxwz05gDqCtMxz+X9eq4BPWkedbmgjG16iMOwccA==", "7ae6752d-d00b-4dc6-bb8e-513b4e80f79a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f1a01aa-85df-4629-ac89-0983687521b3", "AQAAAAEAACcQAAAAEHb+K0SeUNiMJeuRGmdaQIZ1XLkOWbvIcYZtg59HCzImy7EOYPS4Jt8Im10caK1paA==", "b8ffc4d9-bf92-4220-a5c4-ec60cd13beec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75444359-4b91-41eb-9f33-ff53931b60ac", "AQAAAAEAACcQAAAAEErGH/Ob2/9BMkb8bKhEODAronbyg8civ9Kk2Z678fhZdugzosSMmdYvhsWgri3DUw==", "96b97b07-156a-4305-af9b-31ca081537d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ae2afc4-1be8-4ee6-a41a-d51fa4b1c348", "AQAAAAEAACcQAAAAEA0EgmRDmmAIBUPEwO8JTTg7ExbtESF5tFYpD/urBjsoOZwJPrxO5QUBHRlmkBRqXg==", "8bf5be99-5871-438b-bc73-2eb85403d1c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e8e1ad8-a645-46a5-a070-87bd23d62a37", "AQAAAAEAACcQAAAAEPr7WvwxQJiU7M4pvCSta2Kwds3quZd/4w/qh2ysWzhfdbkYgRtwGL6w6dM8DBTJ+Q==", "ca611fd8-d857-4c8d-9ee0-05859bcc304f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a231a124-5233-41fa-8dd4-5f539f935edf", "AQAAAAEAACcQAAAAEIzEiGdpYeGgWrK47DF1Nnwq7Q3ZCSSZXKGE2c2oaDlNG5EnavrrX0DPpYgFgtSHDQ==", "12ea9c4a-8fd6-443c-aa04-0b996ecd8530" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16af4d54-a6ef-4ed6-9cac-29aac8742bca", "AQAAAAEAACcQAAAAEOiJncsMg1+NU3xdegelIdizQzkoBcUbHqMNKwk+ZO7AXXyfTiAL88fGTEC9Bs3lAw==", "7da45308-d30c-438e-b73e-a98eec57d2b4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Personals",
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
    }
}
