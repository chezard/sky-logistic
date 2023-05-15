using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class cgbb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "BankGroupId",
                table: "CorrespondentBanks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CorrespondentBankGroupId",
                table: "CorrespondentBanks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CorrespondentBankGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrespondentBankGroups", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69f2ae9b-f321-45a7-9c78-c29cd297763c", "AQAAAAEAACcQAAAAEGQdB3gHSQPkEMHvlmPHc/CM03P0mwli7/qnfsqcCgyW/uS+y+xA48yZ05jCMJhAeg==", "16332570-98b6-4663-8e01-cf2d345a4154" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdfe6475-7f1f-4f1c-b3bd-96c3695001b1", "AQAAAAEAACcQAAAAEMhvV/gqPcmHz+SXVf+WoblvVfpX0Xzjabw+uDXyFUgRW0ey5NLIZxp0HxHgkdOI1Q==", "6c574584-e922-4fb1-862d-bb494b28a32b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e61cf766-5161-4207-a6d7-bb21cda463d9", "AQAAAAEAACcQAAAAEJbjyw4cWKsOiOlZ36Ayz8wjNthJ4JzWPCV/Lkl0IJ1WAYYWbW6NxAxK9B4Aqqkg1g==", "c4b7b886-21cb-4930-acac-57f48a30c0d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e574d55d-6441-4604-81bc-e11ba7d85cde", "AQAAAAEAACcQAAAAEBV0l0MumADGy4aAnSm8C0WlqXxhd2Cu2SGTMUfN0ZuBh0FUPneeqKPdNu/BgqjjbA==", "803a8b80-b3d7-41cd-9745-656c99fae2a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "797896d4-75e4-4f94-8fe3-4db2f531a7cc", "AQAAAAEAACcQAAAAEMzxP6C9LMVsdAZZ3UdPWQVmgck8T3xIMKtknUKV1fi2cD97zLCz2oTJMF9ui7Xy6g==", "274df741-855d-4d22-af69-f0d049d04bc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f363996-ab2f-4d64-ac5a-0326ee1c2964", "AQAAAAEAACcQAAAAEIXpt7ua3IpacukvrpMYZTd98yvF9qy6A/X7vdc3m1WJP2ElPFlSIoQgn6666W1XJg==", "376d948c-517a-4d6c-88e1-8dd47f45e9c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fa4a96c-53c4-4d9f-a3e9-ce33ef0db728", "AQAAAAEAACcQAAAAEHybD9+uiUMBp5Ly5VNP9shrz2/ckzsNNF7wDZHGjEEP1U5psJmWJocjZbwETPVg2Q==", "edce23b6-bae3-4b56-ae25-7b3efc9cbb2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c14cb265-8002-443e-9734-168b071b4ecd", "AQAAAAEAACcQAAAAEG1KijTRg4oGIgiDUihujise/rlYRMo0ymN8pk3RFpIHkG2r+vL9ISc1yeW9PZxACA==", "0500bbf6-326c-4fd6-a66e-5f8909a7c985" });

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondentBanks_BankGroupId",
                table: "CorrespondentBanks",
                column: "BankGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondentBanks_CorrespondentBankGroupId",
                table: "CorrespondentBanks",
                column: "CorrespondentBankGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondentBanks_BankGroups_BankGroupId",
                table: "CorrespondentBanks",
                column: "BankGroupId",
                principalTable: "BankGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondentBanks_CorrespondentBankGroups_CorrespondentBankGroupId",
                table: "CorrespondentBanks",
                column: "CorrespondentBankGroupId",
                principalTable: "CorrespondentBankGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CorrespondentBanks_BankGroups_BankGroupId",
                table: "CorrespondentBanks");

            migrationBuilder.DropForeignKey(
                name: "FK_CorrespondentBanks_CorrespondentBankGroups_CorrespondentBankGroupId",
                table: "CorrespondentBanks");

            migrationBuilder.DropTable(
                name: "CorrespondentBankGroups");

            migrationBuilder.DropIndex(
                name: "IX_CorrespondentBanks_BankGroupId",
                table: "CorrespondentBanks");

            migrationBuilder.DropIndex(
                name: "IX_CorrespondentBanks_CorrespondentBankGroupId",
                table: "CorrespondentBanks");

            migrationBuilder.DropColumn(
                name: "BankGroupId",
                table: "CorrespondentBanks");

            migrationBuilder.DropColumn(
                name: "CorrespondentBankGroupId",
                table: "CorrespondentBanks");

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
                values: new object[] { "61e8a9d3-1572-459e-b3fd-e55e711cd64a", "AQAAAAEAACcQAAAAEN7OxHrrMie13qIkOdBnhuBKf0aA8bQSx2qkAE7Jy8b7b0TyS2uD4TRDTm5tisUvgg==", "b6180934-18fe-45e3-97f8-38cf92336207" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87043fe0-ede2-4141-a986-52cae5546afb", "AQAAAAEAACcQAAAAEKfZbNjLrMQJrEwMTCUReOVTzVNF4z07ggbkYQxcYD0ZCXeXD3Nw9Mf327sYYIgX9A==", "f806bcdc-28c8-4095-8ed4-ca87a0d1af0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a4bbeba-596b-4585-98d1-940be1873fc2", "AQAAAAEAACcQAAAAEE80wc4P1LCDULoTxaoVfpeVNqM/R/lRS9c9VajjnSqkjFt8dKGJJm7fCrMGezr/kQ==", "c948f480-4c63-42ad-ae69-d8372d402566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c90481f-5926-4167-a723-ec2d2b99a7b7", "AQAAAAEAACcQAAAAEO90OjyBHDo/wI2G6ojdVTJqPev3BtYQurrRtwv3ED582qLzjiIdtaKPXoUS97YogQ==", "30705ae5-5537-43ea-b80b-53661ae9e2df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44e6a90f-0f45-499e-af28-196e9c2599db", "AQAAAAEAACcQAAAAEGonv+CF4Gp7/l4c2lbL/BDTc+hsTImbuwP9NfuS+xr4mLyjlGZ+6LM+wM/PjKxZkw==", "f72816c3-7328-41ce-b4cc-239150503be5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9bb439f-6bba-43d5-b2cd-20df1f744140", "AQAAAAEAACcQAAAAEBglRkoIg6bhnByOoRMhJwaoujBbYw7cZCht6laa9Ld23+aYyd7xzJ7zGeKG9kIZlQ==", "ce4c5db2-4a4d-4212-8072-a254f8c3f5bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0983b662-2b88-46b3-8342-ed52befb5062", "AQAAAAEAACcQAAAAEPH9eEP7n7Q4yMHcNtEcQMl/CTVe9HjXbYmiXSmCCtD8frNoTpm8BZEk7qEOXR0KbA==", "4e5cad70-ad71-47e2-88ef-c19f9cd7b7d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1db1452-8834-4eeb-b3d7-138ff698aa50", "AQAAAAEAACcQAAAAEJWZcHFCR0IiIRZ0YyUN78cBp0DyJzsbKIMnCqWnE2FTLsl8XJrr0cAPPPecmIsy6A==", "3600288b-ce12-49ae-aa54-4eda225fceb5" });
        }
    }
}
