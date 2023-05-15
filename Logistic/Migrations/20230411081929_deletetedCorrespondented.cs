using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class deletetedCorrespondented : Migration
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
                values: new object[] { "0e24ffe8-8b4c-49d7-8a35-3aec8f0aa1fd", "AQAAAAEAACcQAAAAELA97QlypD3AuuEIgv816sbLLqpnsks/5dOp71+bXqGIOlz7spRc0ofPW3gxOKskMw==", "69057a94-be5c-47af-8284-3b9032020e5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a5b6259-1af8-41ad-86e5-ad446673b6b4", "AQAAAAEAACcQAAAAEBV1iwW/9Fu/ZkWyN1kzuCGR+KJTzJ0xiXqdPsags7mvAE12AutWhfY57A7wqQdWgQ==", "e8191338-1cc0-4d50-99fe-8a9524d3bae6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2b9cc7a-76cb-4186-b248-86982a0cc0f9", "AQAAAAEAACcQAAAAENrmlJHl0PwR/h3EA6nu5gnSKytHPJ4TzmMI7yP4nT3WfDclRTJE7XmRnWw6XB13hQ==", "90a8faa4-44da-456e-97bc-04a01039be35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12e05ccf-eb34-4316-a6ca-2297c3ca0b3d", "AQAAAAEAACcQAAAAEAyvm7YRko+0wgWRdSPHO7dZPZ6HrU5GU5jKvS+cz7xJK/lCAEAxbGepAazqDo0fuw==", "b3abc8b4-9570-4a7c-8fc2-8a472d9782b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36cbab2e-af45-4607-a6c1-47067d149c7b", "AQAAAAEAACcQAAAAEAKNZhveJ9VQU6ebaaC3NuLTeZteK8EI8q0QyWsJbZD8okvoos3ul2enq6kYRlyk7g==", "120595e7-67ad-4ba8-b5f7-84e5c621737f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c01c634-d01f-47b2-b1a7-1cadcfae548c", "AQAAAAEAACcQAAAAEEqXGe8whuYP7ZDA0ic12EtZL8e0l8HySCcMrQKG/1xK0jicrquzap+xhk7b6it/Hg==", "6516df6a-69a0-45ac-baac-3cc7f4cffc04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cffd0fc-23ce-47a2-bcc9-db35a8d53081", "AQAAAAEAACcQAAAAEOBztfjO6YXactj+lP3FbhEEJhkisbV8lmuwZxJwsY00oi6AEb5XgZc27hWhWLee7Q==", "2c849867-3cb8-492f-9772-006b0295312f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e800f53b-3c9e-452b-b3fd-cac2efd18939", "AQAAAAEAACcQAAAAEFK2lrNrK1tz8iiGoX3ydlZhaGICKv6/VPTAhtZ6P9zY8q5tcf02syUIL3gTqCIvWA==", "4f870b03-997d-4279-83e8-6df748b918b6" });
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

            migrationBuilder.AlterColumn<int>(
                name: "CorrespondentBankId",
                table: "CustomerLegalPeople",
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
                values: new object[] { "931f6c40-e5e4-49d3-910f-223e173c6f6b", "AQAAAAEAACcQAAAAENcokp+kkPtr+2g2G1rn+TNwMuHp9rf4kfN03hIJVNbczIMhqvwnQXZkpYYDmrAofw==", "d6342c8b-e830-4ca7-b718-585002768955" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4512044b-4415-4cfc-a39a-6138a2a5e1a5", "AQAAAAEAACcQAAAAEBe8HJ2U6cw45OlSn9/eL03IB8Z9FypeJ7jzBpo3HioCc+q0pPtr5wGvgz56PKQ4Rw==", "868e7a82-c8cf-44ee-9cff-b312eef17941" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54fb0dc8-c0c6-4191-928b-735ef522f50a", "AQAAAAEAACcQAAAAEJ1D09GLpe6PJxS8QR2Y0o1ovE1JcqDdyUD4vXuWrtgg91ksw4JrqJew2PCS8zp0lA==", "af4a0ee1-6f6c-4363-a2cb-6e9cb502fc25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d33f23be-7e22-4d4a-b53f-b65f50e3774a", "AQAAAAEAACcQAAAAEEggB4wPpPfM0uDcTKey1r1B/gJBsoAeKMbB+8pS/cfNSHldqgwNGDZlIM1CAG1Yeg==", "b5a9d6c5-f912-4681-92da-734079559107" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "071a8121-7ba0-44f5-80f6-ec9b82cda361", "AQAAAAEAACcQAAAAEHjGY1fqtOdUS7xVs12vaCnTXe3wFH0JDY5z3Ih5etslHFsTKky3Nvn2GRFALG25PA==", "2357ae22-1410-4fe8-9891-627b5986da35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61267b0f-94d4-4353-bdc9-353b2d51c806", "AQAAAAEAACcQAAAAEF7ejDsuq3fmQ+sagA/XqVfvvWrmf13Ob4zUAJEM2tfa+lEZ5Zs8MiiqITnpoCElQw==", "9dc30119-9828-483d-bec0-4164e947a13f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "695977e2-5c71-415e-9187-0635ec6e7cbf", "AQAAAAEAACcQAAAAEMGKk1vwoJsVQNVbOfOH322VNBxQxuB+zJtB1/odDmjYLwCix5xhTckABR/4jBWkog==", "daa83093-f980-4ec6-aeb1-522ebbf41142" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5af38df9-56ad-4b7d-bde3-39a1aff261ab", "AQAAAAEAACcQAAAAECUnHHwBMH+wYSvhOAvDfAiV1soJnit5LeaTgf+HLRu1o/sW957+LxSVeM70+IWNqg==", "d05a8482-be39-46a5-9b18-44b9e956815d" });
        }
    }
}
