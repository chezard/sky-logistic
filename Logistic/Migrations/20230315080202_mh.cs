using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class mh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CorrespondentBankId",
                table: "Institutions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CorrespondentBankId",
                table: "CustomerLegalPeople",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CorrespondentBanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Swift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrespondentBanks", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Institutions_CorrespondentBankId",
                table: "Institutions",
                column: "CorrespondentBankId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLegalPeople_CorrespondentBankId",
                table: "CustomerLegalPeople",
                column: "CorrespondentBankId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerLegalPeople_CorrespondentBanks_CorrespondentBankId",
                table: "CustomerLegalPeople",
                column: "CorrespondentBankId",
                principalTable: "CorrespondentBanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Institutions_CorrespondentBanks_CorrespondentBankId",
                table: "Institutions",
                column: "CorrespondentBankId",
                principalTable: "CorrespondentBanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerLegalPeople_CorrespondentBanks_CorrespondentBankId",
                table: "CustomerLegalPeople");

            migrationBuilder.DropForeignKey(
                name: "FK_Institutions_CorrespondentBanks_CorrespondentBankId",
                table: "Institutions");

            migrationBuilder.DropTable(
                name: "CorrespondentBanks");

            migrationBuilder.DropIndex(
                name: "IX_Institutions_CorrespondentBankId",
                table: "Institutions");

            migrationBuilder.DropIndex(
                name: "IX_CustomerLegalPeople_CorrespondentBankId",
                table: "CustomerLegalPeople");

            migrationBuilder.DropColumn(
                name: "CorrespondentBankId",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "CorrespondentBankId",
                table: "CustomerLegalPeople");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da2968a5-3ba7-4089-a20d-854a2fd7eb8e", "AQAAAAEAACcQAAAAEO8DSe5etu1fkN1PGtPwwNPweNmGJYSloWJUg/IDlZ2/yizfLH9T+GBre258G/F6qA==", "ed80c42b-d38e-4dce-8481-cccc3168a5a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c6be959-d287-406d-9022-668d69f2e5c5", "AQAAAAEAACcQAAAAEC5HsgdiTtjpITfZ7OfiKloqG30shW7V3XUsNJ0XPp8rFaHV+/Lb2ILi6ZfWXZuZ8w==", "906f3a4b-74c8-4542-9d65-d9927b587e4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "198f05ac-cbdd-4371-b0e2-7db28067132c", "AQAAAAEAACcQAAAAECY3dFfKBqRnIzw6HmJdYEXvjc59XDRxurdDnkNLGPdqxv4AeEn3YPTSB48VvvYwew==", "179cf9f2-dcb4-4970-ba97-af2a565e4e2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "882ff465-1087-4472-89e4-053384b1dba6", "AQAAAAEAACcQAAAAEKLQw/GDav3aq+CRnIG1erQ7ts/rnl3RSjXWIUUNGl7VqP3YJTwH+DIq16FNSb/7/A==", "e6b48698-9c5d-4fb7-9199-ba1b9bb659f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "132d89c0-2db2-4d9d-881d-522114634d2e", "AQAAAAEAACcQAAAAEL7xFM8B2Nm4KXaX3QPQ35H/aHP7BfiqPBhtb0kfdyR/1XlM3wLuRc3SujA574A4qg==", "3abc178b-c48e-49b4-ad9b-d140280a84d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9bd91d9-aadb-4faf-ad9b-2d3c0b8785f1", "AQAAAAEAACcQAAAAEMKRahLLLuGQdoQ657Y2JoodcY2btBLJl5mi2Mb49hnUqALyUXyqjOsPgOTHdN5XqA==", "cc1f5c36-959f-40d9-b737-da789913143a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76307c4d-723e-496c-bf62-3333dea88c16", "AQAAAAEAACcQAAAAEEVL/zkzoS1+WPJJdjydia8W24pCEFncsH6VdC2Ss2nbIk1wq5a6r9VEhnJvkMvEdQ==", "e4b140f3-9311-4743-b01f-bba03da21a14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e676e49d-28e4-470d-a05b-fbbb48626ec7", "AQAAAAEAACcQAAAAEBVdfEQZzUNcL5V1AnosSkfh468y/xoojI96p2ieLiF8LMSpNKFmFB6nwHx/Nw0Trg==", "565aa38e-e5a8-4719-8367-7ee7e7b2bd4a" });
        }
    }
}
