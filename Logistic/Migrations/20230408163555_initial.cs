using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b93bcce0-c7a5-494b-b8e3-e25b1ff496e7", "AQAAAAEAACcQAAAAEBK8Q3QfsbOxiOd1i1jCnOFHcwZkfwgC5pUcRwPeHAXFT/UvrmOySlrmZnXnSYcBNw==", "015caa33-00f4-438d-af5f-a14b010684fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93753eab-8087-4764-8141-60894e44931a", "AQAAAAEAACcQAAAAENjIGwIjMjckQ0oUMCn1nQCdM+v39GnpllCLDdQPt9W5h7Q2MugX5FbD/LG9igi45A==", "6484ab11-fc44-4688-abba-7aa39ad268f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bbe500f-24af-49a2-94a1-2b9ee5e70e33", "AQAAAAEAACcQAAAAEHPoZ7dIUqrLujg8tmFNN6SZ73bZmpoXTUmXjB9OP5xkqsRxq+ElLF0gnSFvdeHobA==", "4cbd7531-3881-44a2-9540-3c6e5b53b0b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0795424c-fc97-4724-80ce-421d0689fad1", "AQAAAAEAACcQAAAAEDi6eAZhQ+gE7g6IqIz4GfHi0AC80YCd8WSE6TzvlkRvETNXhFC5CGkHEuZynvSTjw==", "3a289c65-253a-45fb-aa1c-4b3f2c42c585" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c36030c8-8844-4c23-ab43-7392466a5695", "AQAAAAEAACcQAAAAEMzu4YfBQquUBKDHgOzA6FiRLhXjZLMgs4Tcx97mZxiVZS8PG46YYeXeQkvBMZCZog==", "58e2ecf8-ccc7-4606-a0d3-ed2eb2f73da3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2282d1ba-e0d0-44e0-9879-dcc40e6e6f2c", "AQAAAAEAACcQAAAAELL7BmEJ0Te45r9Pi3JN8gL8neEFj+Q0fx+znbATC89wujYyfy6sggz0dBFgh7z7yA==", "43b1e3ac-65a7-4c03-a844-8ad9e39af0ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8b537ba-6975-4035-b2af-b8772d8c178e", "AQAAAAEAACcQAAAAEHJnBTr7qjFfWUskr48Tay6PR+a3DReyx8f2E+PuWy8lh22WqTgtVqGArl2QvPKeDg==", "3bfcdcf5-f45c-4a00-a622-dfd9dbf7962f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82ca6f5a-4e6b-4b58-bf98-8fd6da5a5ca8", "AQAAAAEAACcQAAAAEFufLqJFcyYFX7l7IWgdYq5m+Bb8wclHDeVjRGDeYNdVppqp9Ua8ihDy6t+q9ivw0Q==", "cca3f719-aec2-4de3-8f3d-15252864079e" });
        }
    }
}
