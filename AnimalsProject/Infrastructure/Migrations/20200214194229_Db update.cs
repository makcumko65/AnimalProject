using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Dbupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInvalid",
                table: "Animals");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1L, null, null, null, null, "Berlin" },
                    { 2L, null, null, null, null, "Hamburg" },
                    { 3L, null, null, null, null, "Munich" },
                    { 4L, null, null, null, null, "Cologne" },
                    { 5L, null, null, null, null, "Frankfurt" },
                    { 6L, null, null, null, null, "Stuttgart" },
                    { 7L, null, null, null, null, "Dusseldorf" },
                    { 8L, null, null, null, null, "Dortmund" },
                    { 9L, null, null, null, null, "Essen" },
                    { 10L, null, null, null, null, "Leipzig" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1L, null, null, null, null, "Dog" },
                    { 2L, null, null, null, null, "Cat" },
                    { 3L, null, null, null, null, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1L, null, null, null, null, "Premium feed" },
                    { 2L, null, null, null, null, "Medical feed" },
                    { 3L, null, null, null, null, "Natural feed" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AddressId", "CategoryId", "CategotyId", "ChipNumber", "ContinuatitonOfTreatment", "Created", "CreatedBy", "DateOfBirth", "FoodId", "Gender", "IsAdopted", "LastModified", "LastModifiedBy", "NeckCircumference", "Sterialization", "Weight", "WithersHeight" },
                values: new object[,]
                {
                    { 3L, 1L, null, 1L, 12245678L, true, null, null, new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 0, false, null, null, 10.199999999999999, 0, 15.5, 15.0 },
                    { 5L, 1L, null, 1L, 12355678L, false, null, null, new DateTime(2018, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1, false, null, null, 10.199999999999999, 0, 2.5, 15.0 },
                    { 7L, 6L, null, 1L, 12345778L, true, null, null, new DateTime(2018, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 0, false, null, null, 10.199999999999999, 2, 25.5, 45.0 },
                    { 8L, 2L, null, 1L, 12345688L, true, null, null, new DateTime(2018, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 0, true, null, null, 10.199999999999999, 0, 2.5, 15.0 },
                    { 2L, 2L, null, 2L, 13345678L, false, null, null, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 1, true, null, null, 9.1999999999999993, 2, 25.5, 45.0 },
                    { 6L, 6L, null, 2L, 12346678L, true, null, null, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 0, false, null, null, 1.2, 0, 25.5, 45.0 },
                    { 4L, 4L, null, 3L, 12445678L, false, null, null, new DateTime(2014, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L, 0, false, null, null, 10.199999999999999, 1, 5.5, 5.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.AddColumn<bool>(
                name: "IsInvalid",
                table: "Animals",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
