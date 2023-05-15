using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Logistic.Migrations
{
    public partial class InitialServer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
