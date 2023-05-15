using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class AddLocked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLocked",
                table: "TransportDocuments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f24c7b7b-290f-4ca7-b363-f549e6355c22", "AQAAAAEAACcQAAAAECJc34LzuS8c84lyNz/Nxzn/65bEalsLKweCuj0xKHoggilwrif9bojJkKJoWwscfQ==", "c3baec9c-901a-4bbe-ba93-910182c467fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef70b3a7-562d-4fc5-81af-57ea115f9978", "AQAAAAEAACcQAAAAECBikXiHpj6Xw5s/YenTwLZR0WDT+PVfaeMsNRLwcsJjs5ptZQrHfNYMXJEaU9ImSQ==", "e63e81b1-5c72-4258-8bd9-101f092cf17d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c7a70d5-0b67-46d5-b78f-01b23c6cd00a", "AQAAAAEAACcQAAAAEHNhi7FUTLNBZlBqkf/o/IKJX5opQGG+dTXJwRdADZdh5oVuddB+MW5ZfZju4PV1sA==", "68a4f48b-4f1d-4730-96d7-3eaa4e621071" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d25dda1c-cdfc-46de-bad5-74c8a66fa82c", "AQAAAAEAACcQAAAAEDwrOqB8uCPq0rYrbyxfuovAoeTGLopY2bycsnuFM4fCaT+3efmzgEu45lfwWNMPjw==", "04777359-aecb-4bcd-b20e-13644c2c5ce8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e15be6ea-4c6f-4a92-bd17-1462f105ffaf", "AQAAAAEAACcQAAAAEJrQeEdJxz2svF0/DLyN8mgWMP4tx/0e8tc2mVGJBE6R0TCnMUJV5uQ+v9JtkiWy6A==", "9e672aa2-3fad-48bc-b6e4-624ae08c8dd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff1ca45-be62-4a06-ab17-1ae354c58f1f", "AQAAAAEAACcQAAAAEEhDOEa9SGY/y4XjZ1PyrBlDmq5PEY1t5UUs8X4ehopPNBEmR1ozlnyQXd+MyKEfyg==", "8a2e3e7a-f271-459c-90cb-9dfc290048fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "336fea50-137d-4be1-9438-e452a8186b51", "AQAAAAEAACcQAAAAEHLOMPd+0cmeEBjFXG3vl32dv74DgBFnSFE5P3jkL3rSseSldb8ON+uFT5nTXyP/9g==", "00a87eec-d0e8-4029-b5fa-dfe199615769" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abde2c23-3cf5-4389-90ad-8e2ba1c82b89", "AQAAAAEAACcQAAAAEBWGONkVtcUknZsJqPvqS2VwolyEb2ta1fPieU/PizXfHVBdxZZ9CUHW+YybhXbB/A==", "cb374f02-e6bc-44cb-a2ae-99035aedd6c0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLocked",
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
    }
}
