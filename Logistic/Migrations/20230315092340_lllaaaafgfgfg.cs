using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class lllaaaafgfgfg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CorrespondentBanks_BankGroups_BankGroupId",
                table: "CorrespondentBanks");

            migrationBuilder.DropIndex(
                name: "IX_CorrespondentBanks_BankGroupId",
                table: "CorrespondentBanks");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondentBanks_BankGroups_BankGroupId",
                table: "CorrespondentBanks",
                column: "BankGroupId",
                principalTable: "BankGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
