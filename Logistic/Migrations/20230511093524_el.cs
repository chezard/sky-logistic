using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class el : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                table: "TransportDocumentTables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriverPhone",
                table: "TransportDocumentTables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TruckPlate",
                table: "TransportDocumentTables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "580c9990-2dee-4547-81aa-5274cfd64e78", "AQAAAAEAACcQAAAAEHdAJ9sUr/sWC3ak++h/9rnkI+Z2Bzetjc61b06qYHWGE8rtxg2BB6UkfeNR8BamTQ==", "a51436a7-23a4-43ac-92dd-d99e0d2d39d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c551d8d8-90c7-4ccc-ad59-795b5136f9e3", "AQAAAAEAACcQAAAAEGIjBFvrD3MlvPRooJs3+rEDFLrH707sCZkNeo940mGi+/fP5n6N7rKqdlB9sxUh8g==", "47f64873-c320-4524-beb6-d185e019ce65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa4cb686-9745-4f29-944a-2e8c360b8ade", "AQAAAAEAACcQAAAAEOG5yKoo7lJrFGKgIG5AaUpFrm65Qdqs3wc5S15m4CYHRtcDTRs21sncr0KnUoqmNQ==", "2f004eaa-4484-4188-b0e5-484203dbbc11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19f55fd1-845f-48de-ba47-a1efd264010b", "AQAAAAEAACcQAAAAEDMjz830pNglviYqePQHMpe8L/choynuSdQ3nc982YbbExuphv7wF9dhDUgab4jg5w==", "dc8251dc-d4c0-4024-8280-3de65bacf417" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b3f7dd8-1bd9-46f5-886e-7435b03ac4aa", "AQAAAAEAACcQAAAAEEpNvHoCND8BJ8vgGN20aQDI1ai/JzwM5ohFElpTQHDyj5NuVW5qPQG4kCdws+8dEA==", "45cb681d-8b26-4d0c-aa1d-6ac1c971afa9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a795e587-a226-4971-83ba-693b6adff6b1", "AQAAAAEAACcQAAAAEGCYCpt6yMC6wYrbaDINdA64EjU5NpMLjrfzgPvcLo4PFAN2FeZB+krmWXTvG1FE1g==", "0984618a-c413-4e90-bb46-0bc2e0c7ac7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "886b7274-ecf5-428c-a699-15d740ea61b0", "AQAAAAEAACcQAAAAEK4VWA4Vsdg6QhMbFGkW0nDr+KcOqaqfjVJxaHi26wNVpkD+h2yhwA5xgzoZn5Yr+w==", "e19f53ca-8a84-4f81-aab0-d5051e101775" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5138c930-ce02-4322-bb5a-10212822256e", "AQAAAAEAACcQAAAAEMmXlGEOF9nRAwdIRM2vGgaU4jLLaBBjqgg+MtHuVimlSA5yIG6lWuzUy3F9+oscxw==", "28e3225f-e203-4cd4-8c2d-9031e6037ddb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverName",
                table: "TransportDocumentTables");

            migrationBuilder.DropColumn(
                name: "DriverPhone",
                table: "TransportDocumentTables");

            migrationBuilder.DropColumn(
                name: "TruckPlate",
                table: "TransportDocumentTables");

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
    }
}
