using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class RemoveManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportDocuments_Personals_ManagerId",
                table: "TransportDocuments");

            migrationBuilder.DropIndex(
                name: "IX_TransportDocuments_ManagerId",
                table: "TransportDocuments");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "TransportDocuments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a744d464-394e-4fc9-8b6e-fbaf37704786", "AQAAAAEAACcQAAAAEGd/+AQx4wTb3RYm44MzOM5dOTTgOKl2q3DU6VfJcjMmpMjhqnDlZR9oHy48ezSwZA==", "fdb2f47a-9c8d-4f7b-b035-24efcdd44d5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6504a818-b551-478b-8759-2642c87666e4", "AQAAAAEAACcQAAAAENFR2V7UAivJ+ubjZ7cuoWgtdypPOLSLhsQyQ2/LHXI/EsMyhL717UUwvt4r4LWfig==", "1ee7ad53-6c2c-4421-a44d-68a45b04b059" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01b90ac5-be37-41f0-8798-97cc4f64150e", "AQAAAAEAACcQAAAAEGbE1xdifLpB51VTzhFbl+VmmKRnKD4DjfU99CYMkVzn6+VeDoJvVSV3jRPhFJgb+A==", "29245989-0e9f-4ac2-a1ee-b4ec1a90ede1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "647aa4b8-ee8c-4220-94e9-40ae6ad811a6", "AQAAAAEAACcQAAAAEK+ctLSqKaZtOXwy5b8AJ8kmzSBXzWv9kRqAyceVFAJnUZeCCPYCB9ajxLNC6WUl8A==", "484b2ae6-a3bb-4f16-8d1d-e11a011e1479" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35c5b08d-8e1e-40c1-9ff0-7ced44d8f3ce", "AQAAAAEAACcQAAAAEEWpUCZu5clh3TonZ3PV0TNl0T62E1i+eMqHAEnVS9HowfsrmL3hHH94U0dRsigxcA==", "f29b9a64-5a8c-4886-a7af-f6c26a69c9c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27abf53d-4f7a-4d4d-92c0-f95e2cf164a1", "AQAAAAEAACcQAAAAEBYKBKwy4fKfDDfKGdh7sPgzVihDMWcmYj4mhmDGammA2e7rlUtocqSghjDeRKEa2Q==", "d5800364-9e88-4423-903a-62be9a6620e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0866139d-f3c1-48ef-8785-b3ba573a707c", "AQAAAAEAACcQAAAAEA2v9unwK5+nzzehU1wMSUYdFspUBYEjY+IWWtrJt+xgyny89nq1Gxl8Dte8V/1npg==", "6c27a66e-9b57-480a-83c5-9fc6e622fe22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "655bc1c6-145a-4191-8b30-26cf3a17b5e6", "AQAAAAEAACcQAAAAEMLvGRCMJlvVrAhZf/6duCYNhdYBB8CjCWtZboXcqVHPintk/X5F7dzjP1r4JGIhrg==", "780714b4-18be-4dd2-bdb7-5ac625fa266e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "TransportDocuments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_TransportDocuments_ManagerId",
                table: "TransportDocuments",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportDocuments_Personals_ManagerId",
                table: "TransportDocuments",
                column: "ManagerId",
                principalTable: "Personals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
