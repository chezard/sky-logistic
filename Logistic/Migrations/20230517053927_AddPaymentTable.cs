using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class AddPaymentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApportionmentOfPaymentTables",
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
                    table.PrimaryKey("PK_ApportionmentOfPaymentTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApportionmentOfPaymentTables_TransportDocumentTables_TransportDocumentTableId",
                        column: x => x.TransportDocumentTableId,
                        principalTable: "TransportDocumentTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApportionmentOfPaymentTables_Valyutas_ValyutaId",
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
                values: new object[] { "ee3f40fe-8bcd-49f0-894c-373723e43c6a", "AQAAAAEAACcQAAAAEP1uNWTxO+sEbDe2JK5DfmwlVAH67y868CtR2RRZYyEZ9uzqjnJ21TGVcC3RCxtzRA==", "8e20b104-accc-41ae-99b3-4d0bba7f20d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2fc566f-662c-4c5e-a717-5738d40ecd5e", "AQAAAAEAACcQAAAAEKeCkmE94N/hbs0AidCOonJN3iI2X8odpJQ/F60TyFcGhRE/PGas5QubxcYHVMe+ZA==", "59c725a5-723a-40e8-8b02-0eaf5e84cd84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "871a356a-ef2c-44ba-9042-c4d193cb1690", "AQAAAAEAACcQAAAAEDtrFxzPviWCzmVvj0HgllcwgqletfGio1QzCfnURimZkzjxslFqFrOwHvmsiNb6wA==", "f567ab83-d716-4f5b-b260-fd4419d1787b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24acc429-ec67-4515-930f-89f92550fd54", "AQAAAAEAACcQAAAAECN+8d9QlsMa7oW+m0151HpQG4xRd07YufXNHbAen58JXwgoJe+KqUcSAuOAutMqhw==", "31fef231-2138-4227-9d4d-3ab4d0208fe3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fd51dd3-8b09-42e0-8cb6-91d2db4eef93", "AQAAAAEAACcQAAAAEPuzyqXwrn20AyG3dHtE9f7qbaAGgbilO7MrE9OSDUux/TXQVeghiQrXNvMLvqJfKQ==", "3a48e044-7745-46d1-864e-dd7eefcf7b28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "841ca2c6-cb16-4210-aab7-3af43faddaba", "AQAAAAEAACcQAAAAECVNaPbfl4vwxAYbX84Wf64+Ps26aCWPRwJ2diLnDIz2qpTSo1CztHrBhLW7H7LC9g==", "88fb1f06-e802-4358-8412-3995aaf273cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ca47e0c-d9cb-42f8-961c-d931ce33fdec", "AQAAAAEAACcQAAAAEPg/4Ov+ZHlktS/OWInyZ9G+Dgr9hRsAK739Bbo1PZbTxG0Wcz2joQ5Uih2tNRG4Yg==", "8342a143-e5e6-4597-b6ad-34d12d9e07a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce5cb9b5-f0e8-4207-9658-e37589a952a5", "AQAAAAEAACcQAAAAEB80YmiW95nsAJlkDRxboC2k+O29QinuzwkcUAQVt1a9CbvB4I+WY5i+dw7hBqpTUA==", "c3cf6180-1b68-4c16-9b63-59240eda7205" });

            migrationBuilder.CreateIndex(
                name: "IX_ApportionmentOfPaymentTables_TransportDocumentTableId",
                table: "ApportionmentOfPaymentTables",
                column: "TransportDocumentTableId");

            migrationBuilder.CreateIndex(
                name: "IX_ApportionmentOfPaymentTables_ValyutaId",
                table: "ApportionmentOfPaymentTables",
                column: "ValyutaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApportionmentOfPaymentTables");

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
        }
    }
}
