using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class AddValueTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApportionmentOfValueTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransportDocumentTableId = table.Column<int>(type: "int", nullable: false),
                    Expense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    ValyutaId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApportionmentOfValueTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApportionmentOfValueTables_TransportDocumentTables_TransportDocumentTableId",
                        column: x => x.TransportDocumentTableId,
                        principalTable: "TransportDocumentTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApportionmentOfValueTables_Valyutas_ValyutaId",
                        column: x => x.ValyutaId,
                        principalTable: "Valyutas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1e18e88-5209-4efe-a6b2-69d71b4992e7", "AQAAAAEAACcQAAAAEBcU9KmeyttHZvzKUpi51EvIgA0Bx+bquY1DKfK0etK0nXPVXiZANYMyym6e1UA4cg==", "e81163af-1158-4458-9941-5485f3a33482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cbe975a-0b2c-40e5-9f28-0e904e019d5d", "AQAAAAEAACcQAAAAEDkM3qgwOPPHFtIE88J3+d++YOd5UJGp/qSvNhf96DTrHTwy7yp+3XyTrKXF3znIDA==", "088ab6d2-ab23-449a-8a6c-8a59fc44f1d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "606e0358-61e8-4524-8b0c-5d7c4d4f6e4b", "AQAAAAEAACcQAAAAEPyh0tcg2lbW9wcfKQTYnglZONv/UMRp7kObvesqbdEs+DuZFjyzdHqZMhHBUFQbow==", "586d50c4-7932-4c96-bb6d-ff6f23116444" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3d6015d-31da-4461-acb2-48288344428d", "AQAAAAEAACcQAAAAEEWmsZ8wFC8AYF4S+ngevv3aJVd0iyKRf7D5en+1oOa1g9HCTZfm+0N1tlINwSfNcg==", "c5a25729-9135-4757-9a9a-ce02963a16a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eab0b9fb-0e3f-4100-ba55-9240e9a6c96c", "AQAAAAEAACcQAAAAEP8nXTD/uXs5JyvWHlTxlgLUuyZAvtUKz998IWSzddvqkEY6Qh6Z1/2jyxagGX9FlA==", "28446ac2-273e-497d-ac41-2fa64c11ed73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ea7a2fb-611b-4bfc-9b99-80de7ec22c78", "AQAAAAEAACcQAAAAECsMo8ze2xhx049ps93Jm7bVJomYJMKeqCSeyKDDZ/8zmFCbeieT0I8M893rL4f26w==", "5b738e15-f6ba-42ac-be02-09845decfac6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22f987e1-c61d-449b-9e91-9fc7873c5bc1", "AQAAAAEAACcQAAAAEJydkAgM6aiFGT1DBypnx1JxtEQgIhwNJ7rHjONk2a0jrG3cClDBsN+4cWf/ImPkXw==", "f6002e1d-67f4-4c06-8799-355ba7874467" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73755b6d-7ad1-4899-9a33-35e1db2a6e3b", "AQAAAAEAACcQAAAAEAqjr3tKe2LN9YkBoDSflGw15OlJWTY8LwxkdmP/KSfgmTlaBzTw/cz/lW2FPdqWdw==", "fdd133b1-4624-4f69-91a0-73e8b1eb989b" });

            migrationBuilder.CreateIndex(
                name: "IX_ApportionmentOfValueTables_TransportDocumentTableId",
                table: "ApportionmentOfValueTables",
                column: "TransportDocumentTableId");

            migrationBuilder.CreateIndex(
                name: "IX_ApportionmentOfValueTables_ValyutaId",
                table: "ApportionmentOfValueTables",
                column: "ValyutaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApportionmentOfValueTables");

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
    }
}
