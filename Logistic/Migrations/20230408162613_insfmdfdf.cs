using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class insfmdfdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CorrespondentBankId",
                table: "Institutions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d623ef0-cb5d-4d3b-8c66-51e9c312d96b", "AQAAAAEAACcQAAAAEIvKnP/I/XuZ69kpOunq0UtV/ctSzoKVx+sLjEruV2ejF0MFBd+u7fdCtapn2etpFQ==", "c5366f47-12e3-4df5-99fa-cf3779587516" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c7ed58b-662a-4749-b43f-564d38c84d07", "AQAAAAEAACcQAAAAEGCFkJ4X+j9/xM9Fmp/fTN2loHtum4RrO0bzK8b2px1vpLQ+tcW72a/BUFOivkbH4A==", "ee079643-4970-4d57-92bc-b27c6c6c60d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2653a0a-b2a4-4b2e-a4e5-678c8ae8b34b", "AQAAAAEAACcQAAAAENDjhGclQw3z6j9n4aUUXOifIPWG2B6aulYgj5vP3/zds+IGeUQUIDWLnA5Y4YTsPA==", "de9666ca-583b-4981-8976-de1a1fe8f2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a76043b7-e16e-4156-84b7-a8de0f0c710b", "AQAAAAEAACcQAAAAEJjm4eEPd/F8WZ0fO2/tbSUWStNXhbCoX7W8fAGmDVgpQ9vR1XLs+vQM8E9V9PfrbQ==", "17a177df-734f-4a37-ad0e-c5ce56da7ee3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2fbec4e-6cfc-47b9-9171-273c134dbf94", "AQAAAAEAACcQAAAAEAIGnDnzMafbGV+w0Gve/iab2Yc6Q05jvOk385S7VCLwV/TytFL4brkd6UDHJ6cSJw==", "d6fabf12-444f-4fd0-8230-f447785d8e1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7485c24f-c232-471e-b4ba-4fced4a6c5b8", "AQAAAAEAACcQAAAAEAJ82/yJW9Hj61T8ibYNQge+FQLizhCG8RpVHTP2DXL0x6iD6H5JMvlVDYK1gHmTrQ==", "f92e33c3-109a-4a9c-8943-93b8373dc2f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23f7edf4-2e33-4efb-a48f-d5e3491ad3f4", "AQAAAAEAACcQAAAAEIMn+HbujozGVh5H3HBucxM0Lc2EwgMtapTBqqLSH8Rb+bumLimVSZFJMJRkDBpvzQ==", "b7b1c233-8ff2-40c8-8f19-ee260a3d6000" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ef475fd-bd0a-4234-920e-fc1cd1fa169e", "AQAAAAEAACcQAAAAEBBywA/Yi3PxNYcToXPbL9RVeq5rADjzjxSUfZ39qXEftUjdPD7XviDfMH/JYJ8NiA==", "cf9b28ac-033c-49bd-92ec-77a59fe05de6" });
        }
    }
}
