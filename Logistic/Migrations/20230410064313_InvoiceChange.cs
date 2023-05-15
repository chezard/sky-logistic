using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class InvoiceChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "CorrespondentBankId",
                table: "Institutions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "CorrespondentBankId",
                table: "Institutions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                values: new object[] { "a8a73430-7fc2-4f6b-9382-51411e43c06b", "AQAAAAEAACcQAAAAEHYOi9Si4myVH+l5YsrwqH/yNFADZo2AuxOw65KLFKZo342rbXVcOJZ3VV0JwWzp8g==", "c61cb16d-1f81-486e-977e-bc43bc533065" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98825ada-7b7f-45fd-be1b-4004233e00ce", "AQAAAAEAACcQAAAAEMylSq37Z9Najq02nGWCn+UBrfbNEE0upk2V62EuzRs2D8Dum54Yd/Z695NkxTYcKA==", "0d0817ef-9356-4279-8500-545c8c685e0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66676195-9586-4164-a727-368c7695d7dd", "AQAAAAEAACcQAAAAECEsGy6gfnfm2QUn1+3DyTypSH2W31+TA0MfwEPkseB3NJZL3Bc7Np+XacDx7yYddA==", "a6c497d5-24fd-4c9f-a621-50a41b0c65d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b896242-1ea8-43c4-bf40-34bfa7bf1fe2", "AQAAAAEAACcQAAAAEH0UFZfG7bQoxwo9JNKKZTOkIiWwTh2HHsAv0eOi1ubGuqCmeyV7TuIudyscBY3Trw==", "e5222396-9bca-4fe1-9fc9-b9b33f7cc825" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6030bd80-202e-493a-ba88-398e4ea69e86", "AQAAAAEAACcQAAAAEBTTnDwHnoiJqtKSwnuJ8/7x7MHjNZebHv7ykKBdl32krPGD17p53oMvMpqGcKFRog==", "710726e1-a139-4449-aa6b-3fd44fd0892d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4f09620-75a8-4a0f-8aef-8eb911548c2e", "AQAAAAEAACcQAAAAEPrM6PjJmMvPmoV9t2OrvI1CtGF8XnqBd9/5WMk9iM7cGNPCehbnrYliJfVyu46S9g==", "38e1249e-dac5-4c95-a4a5-a66abdb7bd2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d137ae02-f948-4144-b24b-104a0955d012", "AQAAAAEAACcQAAAAEMmOi4n0/8GN6yqsRUYLTxvYPbShJXcKek/MiKPa+6UKrbuzAsERKdGxw1uwgBksow==", "cd4fd241-fc2c-470f-ae44-3d9b937dc9ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e345ef4-36ac-405f-b103-5714ac5e6057", "AQAAAAEAACcQAAAAEIthaYexcp16PJMRFohJueAHNjaxpJWO4irK65CHHt2RzgeaGRyv5rMwatH1IByqJA==", "692dc40d-2e8b-4e55-bf24-5f0a133a676e" });
        }
    }
}
