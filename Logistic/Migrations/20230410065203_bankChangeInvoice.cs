using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class bankChangeInvoice : Migration
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
                name: "CorrespondentBankCustomer",
                table: "Invoices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CorrespondentBankExpeditor",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrespondentBankCustomer",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CorrespondentBankExpeditor",
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
    }
}
