using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class seedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NextVaccinationDate",
                table: "AnimalVaccination",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "VaccinationDate",
                table: "AnimalVaccination",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NextProcessingDate",
                table: "AnimalProcessing",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ProcessingDate",
                table: "AnimalProcessing",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Mark",
                table: "AnimalAttitudeTo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AttitudeTo",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1L, null, null, null, null, "Adults" },
                    { 2L, null, null, null, null, "Childrens" },
                    { 3L, null, null, null, null, "Cats" },
                    { 4L, null, null, null, null, "Dogs" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Type" },
                values: new object[,]
                {
                    { 1L, null, null, null, null, "Front pow disability" },
                    { 2L, null, null, null, null, "Back pow disability" },
                    { 3L, null, null, null, null, "Vision disability" },
                    { 4L, null, null, null, null, "Hearing disability" }
                });

            migrationBuilder.InsertData(
                table: "Keepings",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 2L, null, null, null, null, "Enclosed house with yard" },
                    { 3L, null, null, null, null, "Wintering only in the house" },
                    { 1L, null, null, null, null, "Flat" }
                });

            migrationBuilder.InsertData(
                table: "Needs",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1L, null, null, null, null, "Need to be housed with other animals" },
                    { 2L, null, null, null, null, "Need to be housed apart from other animals" },
                    { 3L, null, null, null, null, "Need for a suitable diet" }
                });

            migrationBuilder.InsertData(
                table: "Processings",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Type" },
                values: new object[,]
                {
                    { 1L, null, null, null, null, "Anti-flea and anti-ticks processing" },
                    { 2L, null, null, null, null, "Anti-worms processing" }
                });

            migrationBuilder.InsertData(
                table: "Vaccinations",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name", "Type" },
                values: new object[,]
                {
                    { 4L, null, null, null, null, "Rabisin", "Rabies vaccine" },
                    { 1L, null, null, null, null, "Daramoon", "Common" },
                    { 2L, null, null, null, null, "Vangard", "Common" },
                    { 3L, null, null, null, null, "Nobivak", "Common" },
                    { 5L, null, null, null, null, "Rabistar", "Rabies vaccine" }
                });

            migrationBuilder.InsertData(
                table: "AnimalAttitudeTo",
                columns: new[] { "AnimalId", "AttitudeId", "Created", "CreatedBy", "Id", "LastModified", "LastModifiedBy", "Mark" },
                values: new object[,]
                {
                    { 4L, 1L, null, null, 0L, null, null, 3 },
                    { 12L, 1L, null, null, 0L, null, null, 3 },
                    { 11L, 1L, null, null, 0L, null, null, 5 },
                    { 2L, 2L, null, null, 0L, null, null, 3 },
                    { 11L, 3L, null, null, 0L, null, null, 4 },
                    { 11L, 4L, null, null, 0L, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "AnimalDefects",
                columns: new[] { "AnimalId", "DefectsId" },
                values: new object[,]
                {
                    { 11L, 4L },
                    { 10L, 2L },
                    { 13L, 1L },
                    { 8L, 1L }
                });

            migrationBuilder.InsertData(
                table: "AnimalKeeping",
                columns: new[] { "AnimalId", "KeepingId" },
                values: new object[,]
                {
                    { 4L, 2L },
                    { 3L, 3L },
                    { 2L, 3L },
                    { 14L, 2L },
                    { 12L, 2L },
                    { 8L, 2L },
                    { 6L, 2L },
                    { 16L, 1L },
                    { 10L, 2L },
                    { 13L, 1L },
                    { 12L, 1L },
                    { 11L, 1L },
                    { 9L, 1L },
                    { 7L, 1L },
                    { 5L, 1L },
                    { 2L, 1L },
                    { 15L, 1L }
                });

            migrationBuilder.InsertData(
                table: "AnimalNeeds",
                columns: new[] { "AnimalId", "NeedsId" },
                values: new object[,]
                {
                    { 7L, 3L },
                    { 8L, 2L },
                    { 2L, 3L },
                    { 14L, 1L },
                    { 3L, 1L },
                    { 2L, 2L }
                });

            migrationBuilder.InsertData(
                table: "AnimalProcessing",
                columns: new[] { "AnimalId", "ProcessingId", "NextProcessingDate", "ProcessingDate" },
                values: new object[,]
                {
                    { 7L, 1L, new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11L, 1L, new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, 2L, new DateTime(2019, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, 2L, new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11L, 2L, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, 2L, new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AnimalVaccination",
                columns: new[] { "AnimalId", "VaccinationId", "Created", "CreatedBy", "Id", "LastModified", "LastModifiedBy", "NextVaccinationDate", "VaccinationDate" },
                values: new object[,]
                {
                    { 2L, 4L, null, null, 0L, null, null, new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, 1L, null, null, 0L, null, null, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, 2L, null, null, 0L, null, null, new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, 3L, null, null, 0L, null, null, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, 3L, null, null, 0L, null, null, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, 5L, null, null, 0L, null, null, new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalAttitudeTo",
                keyColumns: new[] { "AnimalId", "AttitudeId" },
                keyValues: new object[] { 2L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalAttitudeTo",
                keyColumns: new[] { "AnimalId", "AttitudeId" },
                keyValues: new object[] { 4L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalAttitudeTo",
                keyColumns: new[] { "AnimalId", "AttitudeId" },
                keyValues: new object[] { 11L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalAttitudeTo",
                keyColumns: new[] { "AnimalId", "AttitudeId" },
                keyValues: new object[] { 11L, 3L });

            migrationBuilder.DeleteData(
                table: "AnimalAttitudeTo",
                keyColumns: new[] { "AnimalId", "AttitudeId" },
                keyValues: new object[] { 11L, 4L });

            migrationBuilder.DeleteData(
                table: "AnimalAttitudeTo",
                keyColumns: new[] { "AnimalId", "AttitudeId" },
                keyValues: new object[] { 12L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalDefects",
                keyColumns: new[] { "AnimalId", "DefectsId" },
                keyValues: new object[] { 8L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalDefects",
                keyColumns: new[] { "AnimalId", "DefectsId" },
                keyValues: new object[] { 10L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalDefects",
                keyColumns: new[] { "AnimalId", "DefectsId" },
                keyValues: new object[] { 11L, 4L });

            migrationBuilder.DeleteData(
                table: "AnimalDefects",
                keyColumns: new[] { "AnimalId", "DefectsId" },
                keyValues: new object[] { 13L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 2L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 2L, 3L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 3L, 3L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 4L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 5L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 6L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 7L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 8L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 9L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 10L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 11L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 12L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 12L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 13L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 14L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 15L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalKeeping",
                keyColumns: new[] { "AnimalId", "KeepingId" },
                keyValues: new object[] { 16L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalNeeds",
                keyColumns: new[] { "AnimalId", "NeedsId" },
                keyValues: new object[] { 2L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalNeeds",
                keyColumns: new[] { "AnimalId", "NeedsId" },
                keyValues: new object[] { 2L, 3L });

            migrationBuilder.DeleteData(
                table: "AnimalNeeds",
                keyColumns: new[] { "AnimalId", "NeedsId" },
                keyValues: new object[] { 3L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalNeeds",
                keyColumns: new[] { "AnimalId", "NeedsId" },
                keyValues: new object[] { 7L, 3L });

            migrationBuilder.DeleteData(
                table: "AnimalNeeds",
                keyColumns: new[] { "AnimalId", "NeedsId" },
                keyValues: new object[] { 8L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalNeeds",
                keyColumns: new[] { "AnimalId", "NeedsId" },
                keyValues: new object[] { 14L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalProcessing",
                keyColumns: new[] { "AnimalId", "ProcessingId" },
                keyValues: new object[] { 4L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalProcessing",
                keyColumns: new[] { "AnimalId", "ProcessingId" },
                keyValues: new object[] { 7L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalProcessing",
                keyColumns: new[] { "AnimalId", "ProcessingId" },
                keyValues: new object[] { 8L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalProcessing",
                keyColumns: new[] { "AnimalId", "ProcessingId" },
                keyValues: new object[] { 9L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalProcessing",
                keyColumns: new[] { "AnimalId", "ProcessingId" },
                keyValues: new object[] { 11L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalProcessing",
                keyColumns: new[] { "AnimalId", "ProcessingId" },
                keyValues: new object[] { 11L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalVaccination",
                keyColumns: new[] { "AnimalId", "VaccinationId" },
                keyValues: new object[] { 2L, 3L });

            migrationBuilder.DeleteData(
                table: "AnimalVaccination",
                keyColumns: new[] { "AnimalId", "VaccinationId" },
                keyValues: new object[] { 2L, 4L });

            migrationBuilder.DeleteData(
                table: "AnimalVaccination",
                keyColumns: new[] { "AnimalId", "VaccinationId" },
                keyValues: new object[] { 3L, 2L });

            migrationBuilder.DeleteData(
                table: "AnimalVaccination",
                keyColumns: new[] { "AnimalId", "VaccinationId" },
                keyValues: new object[] { 5L, 1L });

            migrationBuilder.DeleteData(
                table: "AnimalVaccination",
                keyColumns: new[] { "AnimalId", "VaccinationId" },
                keyValues: new object[] { 5L, 3L });

            migrationBuilder.DeleteData(
                table: "AnimalVaccination",
                keyColumns: new[] { "AnimalId", "VaccinationId" },
                keyValues: new object[] { 5L, 5L });

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "AttitudeTo",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "AttitudeTo",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "AttitudeTo",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "AttitudeTo",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Keepings",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Keepings",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Keepings",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Needs",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Needs",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Needs",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Processings",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Processings",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DropColumn(
                name: "NextVaccinationDate",
                table: "AnimalVaccination");

            migrationBuilder.DropColumn(
                name: "VaccinationDate",
                table: "AnimalVaccination");

            migrationBuilder.DropColumn(
                name: "NextProcessingDate",
                table: "AnimalProcessing");

            migrationBuilder.DropColumn(
                name: "ProcessingDate",
                table: "AnimalProcessing");

            migrationBuilder.DropColumn(
                name: "Mark",
                table: "AnimalAttitudeTo");
        }
    }
}
