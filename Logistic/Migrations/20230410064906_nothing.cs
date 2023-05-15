using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class nothing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "correspondetnBanksCustomer",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "correspondetnBanksExpeditor",
                table: "Invoices");

            migrationBuilder.AlterColumn<int>(
                name: "CorrespondentBankId",
                table: "Invoices",
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
                values: new object[] { "bd8a4b07-d19d-4b93-a6fd-7c15e9f610bf", "AQAAAAEAACcQAAAAELEX9feQ/5Nl2n2sgsjcBqwUDsO7JfJ/ZlGKEQSklKznym9VA43l5wpJnnEGyYcbqg==", "30b57cce-5dff-44c9-b0d3-5efb9827d17d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe0a767a-3ce8-4d96-af6f-c76961d00e23", "AQAAAAEAACcQAAAAEAZ3edOfRZ/t5rJtCLgJ0B8cXnW1s0bLtNkap7wJ7LuSAxC5+clFwK8D2n3dWyRhCw==", "2ca7b98f-3d8d-449f-9af9-5363d6b2ec50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75ef3192-3b61-4683-976a-50c127445abe", "AQAAAAEAACcQAAAAECUTq29NybehIjTvT2JZu3jjQ1FO/ywSBAOrpBH1qaOQRrLa9Ugz/httHAUC81IPOA==", "8c7df5fe-9efb-409e-98ef-bf4cb1b2d214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a613d38-c214-413f-acd7-6324812187e3", "AQAAAAEAACcQAAAAEJO3FJ5syttRGGbUq/DHhtfwAcvyRRzEvMG7WCOcPWc+TaNcDcV1qBs6CEbjzAyulw==", "dc205732-4b01-4a92-987f-4b5a1c0e4ff3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18ea954c-9fda-4e03-8f1d-73292b64bb64", "AQAAAAEAACcQAAAAEFmP3Gkhxaab+Awt/CGgLMr6/3G1S6h1f3ScJNpqVV5qPyxktdQ4SGEUsiOxY01pyg==", "16f1e686-5e8c-45cc-b8a5-bd671ead15d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25898de0-034c-40b1-bb07-19d20ee1d678", "AQAAAAEAACcQAAAAEFyZt8yQhr8CA5hYW0zu+XRvx06l0mXiRuNwQAS7hHjZFL1lx2PLfiW15lYP45rY+Q==", "a5d1814a-83ff-4b70-a4c5-6c24e51cb977" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f618dd9-7dca-460b-9bd5-872fcbeae85f", "AQAAAAEAACcQAAAAEImzsv5WZxbOrO8IKyeQCvvOqfwTBOQ41VrCM/vVI9BPpUPQXtYie+veDFik/xdb9A==", "594c0e37-fe67-4520-a7c4-26b34e151d4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d9c9dea-a571-4a3e-a1e6-60833d5e739b", "AQAAAAEAACcQAAAAENRfMvi4w0MW8FjhaxYMFxdrK99YlP+as1pWfj4yeXUUAzJYy8jszGC9b2/Ul+HE8g==", "826a7e6c-fe2e-40a9-ac1b-5bdc17ee68a9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CorrespondentBankId",
                table: "Invoices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "correspondetnBanksCustomer",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "correspondetnBanksExpeditor",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d78f9c49-86bf-4208-a8b7-b8a72f4833a5", "AQAAAAEAACcQAAAAEPC4PWa3F/qMEciRvTOLasEVWxdFbq9EMQeXvEzUu4rxbsx7yCWTy2TtHFYvEjnALg==", "83799043-b0ef-463a-ae09-e184686744dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a4b5d93-233d-4720-a5aa-214d628776f3", "AQAAAAEAACcQAAAAEHk/vAN733SAz3dWavHLCdVb4Ocrcr12jpvc1yycXN7Y5zumxbTioVVosNPcBxPOHA==", "2d9a7de0-2a96-4c6b-a34e-7ab3e1c5324f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba2e56f5-5115-40b6-999d-c7c4626e10ff", "AQAAAAEAACcQAAAAEP27+Kk3ZnmwZxb5MGv+/TJ0QI9T1ytrNDR1lD0FLEn7nuw6P1idYcl3r0NpC5fwOA==", "e5f3e71e-6e1e-40c7-8f79-f0af542b337b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9248025-3838-4528-ad6b-cea81b68bb85", "AQAAAAEAACcQAAAAEOLJ5FekDafmNWAGbfS1XXjpI3yjpCP7OnlVpxvJ4KskwbZbVM/oJDJXuNaGtlEy5A==", "7a198921-32ce-4e92-aa42-f747b5757cd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e1b0c5-012f-45a7-be68-3a71f417a903", "AQAAAAEAACcQAAAAEO4wZ7d/HHlP1uShfzkPeXp1wieyME+gNcmx9vb+hh1YA08xHCGCeO/y7Q2BzT8G7w==", "14313cf1-3d4b-4c54-a66e-a2c0e9925050" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a90d0835-829a-4103-adde-9342a4024a91", "AQAAAAEAACcQAAAAEI4zFRDUyyA8uopiXtFUkI/B8hFlTO3TFyHNI2CNnbBuA+0GBMFy/iDQZeW8XnWliA==", "653b116d-1638-41f3-8a4b-f6cec81637e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdbd8c4b-0172-4a2c-99e2-4cd73355eaf9", "AQAAAAEAACcQAAAAEIewVOppTMPmuSzJ1WXGpW4eLyo03m3QciBcm64GQQQAYmDBF/vY8l+HxNHrzhVsrw==", "fb8f860a-235f-43c4-93b3-3d7dd483e686" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8231b288-844c-4922-8423-199a3870a5a2", "AQAAAAEAACcQAAAAEE1HrjiVPxDbReOo/VMmn1t8CQ1izTYNBEaGVZ6tKZNQfvwOB+eS6op557xJq04FbA==", "b9867961-b145-4631-903d-75c2c377293b" });
        }
    }
}
