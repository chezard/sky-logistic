using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class ExpeditorAndCustomerCorrBankIdSaperated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_CorrespondentBanks_CorrespondentBankId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CorrespondentBankCustomer",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "CorrespondentBankId",
                table: "Invoices",
                newName: "CorrespondentBankExpeditorId");

            migrationBuilder.RenameColumn(
                name: "CorrespondentBankExpeditor",
                table: "Invoices",
                newName: "CorrespondentBankCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_CorrespondentBankId",
                table: "Invoices",
                newName: "IX_Invoices_CorrespondentBankExpeditorId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "058d93b6-c7a5-43c8-9574-c1f94236f378", "AQAAAAEAACcQAAAAEOH4ZIbypQRBq7FnqRE7r4topFdLrybQR+dl1uqgW2EOHhaYEZ/6arlpErVmEP7XTA==", "85551cf5-225f-499c-b903-6689fe57dcad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a940375b-6e0e-49d0-abae-bbfc85a33e57", "AQAAAAEAACcQAAAAEGXxUEX6nqwDsJ6pgbUBVIRn8zsYrMcVDPxAahchn7IaT3z0P3t6fk1ug/A2CdP2nA==", "f6050956-b056-46b7-a2b6-87ee342faf92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfc49bd4-b832-46ab-a103-9b1115ebb707", "AQAAAAEAACcQAAAAEIuwkNPZJX5Fvj0ADPU+tJeeCLaB9mceTDzM9xs42Mg+TuOa9FQvfM1uB6HZn2RiyA==", "4008746f-77df-4ef4-a95e-238b53907c89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf11d5e0-0725-43a5-9371-d67bacf3eaa8", "AQAAAAEAACcQAAAAEIXJuynsZh8bRBdZ9hB4XwuKHk2bfaiTA8FsIUqeKrLUgpqkbl6b4nD6C3cqfQBE1Q==", "71fc8371-4a6d-4f02-92d8-df9c43909aea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2175f9c9-6334-4c4a-a0b9-e490fc47422d", "AQAAAAEAACcQAAAAEEL62in8ZHlK0BAtMpvCiuuguwp2V4AMAJm63NbhLfY3S49RkaJfsFqrhvMRifW3Rg==", "cddc08b0-9fc5-45b6-b415-cd888a91bf00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04695a9d-0b5a-470d-9375-e269c8cea72e", "AQAAAAEAACcQAAAAEO/AGCkd5emNP47mfwND8DN/27OaooPDxu6Ciuhj4Q5tOLJCoR6tp0/GOg5MKWjk6w==", "21f2260a-a6f7-4433-b579-897a41041498" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e05e359d-7959-4f03-bb69-24b9ad8798ce", "AQAAAAEAACcQAAAAEAAMi7K+MCyHH8J88dTiPGWP6gWzWMEAiRh37HNB5f2HDCgvAlE/nR8MfBMl12zAFg==", "302461d4-5ddb-4e0f-ba67-cb1126e8f26f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c607168c-898d-4770-a73e-482d19eee3f5", "AQAAAAEAACcQAAAAEA6dPG+0PojzafvwFCHBKBBhY0sS5Rctsm756rZXcWlKoIexRTVL1XtBudDyI2DQvA==", "6e17bdc0-4f3e-4dae-af8e-cea0bd522d3e" });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CorrespondentBankCustomerId",
                table: "Invoices",
                column: "CorrespondentBankCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_CorrespondentBanks_CorrespondentBankCustomerId",
                table: "Invoices",
                column: "CorrespondentBankCustomerId",
                principalTable: "CorrespondentBanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_CorrespondentBanks_CorrespondentBankExpeditorId",
                table: "Invoices",
                column: "CorrespondentBankExpeditorId",
                principalTable: "CorrespondentBanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_CorrespondentBanks_CorrespondentBankCustomerId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_CorrespondentBanks_CorrespondentBankExpeditorId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_CorrespondentBankCustomerId",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "CorrespondentBankExpeditorId",
                table: "Invoices",
                newName: "CorrespondentBankId");

            migrationBuilder.RenameColumn(
                name: "CorrespondentBankCustomerId",
                table: "Invoices",
                newName: "CorrespondentBankExpeditor");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_CorrespondentBankExpeditorId",
                table: "Invoices",
                newName: "IX_Invoices_CorrespondentBankId");

            migrationBuilder.AddColumn<int>(
                name: "CorrespondentBankCustomer",
                table: "Invoices",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2da06dfa-78ed-417e-8f1d-8a436baa79b5", "AQAAAAEAACcQAAAAELDOexZJWtB3VQh+sQoK3TcDjEUr2zWnz/m144QgfUwWjKvUFQdmwlgwsDo7CbdzdQ==", "8c6ba2e4-90f1-46ca-a352-77d74c11d1ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afb69a1d-9b32-4ca9-b96d-f8d5bfb425f0", "AQAAAAEAACcQAAAAEAX8mfSb033R34JyseH/OO0PkSt0Wk32vx823BhKdFWxiyfu/K3Pa8ybEPhcn/21pg==", "9195b33f-2ae3-47f5-89d3-5db8fef6d47e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6cc3774-8b34-45a8-b659-6d005eb9bd3b", "AQAAAAEAACcQAAAAED+w7YWjSoYyqE18N+rb11YrpHYhGkpSqr9zo0tKYML45GecIMQYV/BoYsvzW2C5IA==", "ba3c58c4-1ed2-45f2-b711-a078e7147319" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81c8d2b5-a17e-48fb-89df-e42d9251084d", "AQAAAAEAACcQAAAAEAHTOZNk+Ld7qK8GU3fG5xijrc55g4leRGfuLumVCR8Q2Dn+croe0A7D8dwegtfEvg==", "5d4c6532-97b7-45d5-8953-3ccf7959ca25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5131cefe-6e96-4aa8-ac96-3f88fa3b3e90", "AQAAAAEAACcQAAAAEHJPrW47ASv2CQMU+wLlDMnqr51lFBNrwt01pKPfOgGYc/a8JAKfvxecmk92oi0vhg==", "1642122b-2bb7-4a65-9f83-b93dab7288bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09cb3546-1b5b-4f8c-b78b-b31be406e76b", "AQAAAAEAACcQAAAAEI3Q8UA68kPAgGAgiWNn8/rcjNnw4FVHPjBMO10aT9ZjWw7eiVRFx2zkmyg3MdJTew==", "2c88454f-32c4-49d1-b593-3a98a48cacee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0a6f706-f2c9-41ae-be98-012312bc614c", "AQAAAAEAACcQAAAAEF3NWv0fIlnAKT8Jz7TF/hZOphQaSANL2PvIXEFD/yfUEWuzW4zGA8sgFqECW+AFwA==", "e9eb4753-5bde-4311-a84f-628b7838d41a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ef45d29-efe8-4d35-befb-51662b7f9e51", "AQAAAAEAACcQAAAAECUyY08izDWCaWIOzpoXrXvvaa6d0SYgBWTbiKitS+DqD9NzMGyQDgF8T01drLvEQw==", "d7fe10a0-ec6c-4bff-85a3-39a84531b811" });

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_CorrespondentBanks_CorrespondentBankId",
                table: "Invoices",
                column: "CorrespondentBankId",
                principalTable: "CorrespondentBanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
