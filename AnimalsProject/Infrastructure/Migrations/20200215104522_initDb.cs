using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttitudeTo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttitudeTo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Defects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keepings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keepings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Needs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Needs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vaccinations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccinations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    WithersHeight = table.Column<double>(nullable: false),
                    NeckCircumference = table.Column<double>(nullable: false),
                    IsAdopted = table.Column<bool>(nullable: false),
                    ContinuatitonOfTreatment = table.Column<bool>(nullable: false),
                    ChipNumber = table.Column<long>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Sterialization = table.Column<int>(nullable: false),
                    AddressId = table.Column<long>(nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    FoodId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalAttitudeTo",
                columns: table => new
                {
                    AnimalId = table.Column<long>(nullable: false),
                    AttitudeId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalAttitudeTo", x => new { x.AnimalId, x.AttitudeId });
                    table.ForeignKey(
                        name: "FK_AnimalAttitudeTo_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalAttitudeTo_AttitudeTo_AttitudeId",
                        column: x => x.AttitudeId,
                        principalTable: "AttitudeTo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalDefects",
                columns: table => new
                {
                    AnimalId = table.Column<long>(nullable: false),
                    DefectsId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalDefects", x => new { x.AnimalId, x.DefectsId });
                    table.ForeignKey(
                        name: "FK_AnimalDefects_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalDefects_Defects_DefectsId",
                        column: x => x.DefectsId,
                        principalTable: "Defects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalKeeping",
                columns: table => new
                {
                    AnimalId = table.Column<long>(nullable: false),
                    KeepingId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalKeeping", x => new { x.AnimalId, x.KeepingId });
                    table.ForeignKey(
                        name: "FK_AnimalKeeping_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalKeeping_Keepings_KeepingId",
                        column: x => x.KeepingId,
                        principalTable: "Keepings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalNeeds",
                columns: table => new
                {
                    AnimalId = table.Column<long>(nullable: false),
                    NeedsId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalNeeds", x => new { x.AnimalId, x.NeedsId });
                    table.ForeignKey(
                        name: "FK_AnimalNeeds_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalNeeds_Needs_NeedsId",
                        column: x => x.NeedsId,
                        principalTable: "Needs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalProcessing",
                columns: table => new
                {
                    AnimalId = table.Column<long>(nullable: false),
                    ProcessingId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalProcessing", x => new { x.AnimalId, x.ProcessingId });
                    table.ForeignKey(
                        name: "FK_AnimalProcessing_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalProcessing_Processings_ProcessingId",
                        column: x => x.ProcessingId,
                        principalTable: "Processings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalVaccination",
                columns: table => new
                {
                    AnimalId = table.Column<long>(nullable: false),
                    VaccinationId = table.Column<long>(nullable: false),
                    Id = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalVaccination", x => new { x.AnimalId, x.VaccinationId });
                    table.ForeignKey(
                        name: "FK_AnimalVaccination_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalVaccination_Vaccinations_VaccinationId",
                        column: x => x.VaccinationId,
                        principalTable: "Vaccinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Img = table.Column<byte[]>(nullable: true),
                    AnimalId = table.Column<int>(nullable: false),
                    AnimalId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Animals_AnimalId1",
                        column: x => x.AnimalId1,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                columns: new[] { "Id", "AddressId", "CategoryId", "ChipNumber", "ContinuatitonOfTreatment", "Created", "CreatedBy", "DateOfBirth", "FoodId", "Gender", "IsAdopted", "LastModified", "LastModifiedBy", "NeckCircumference", "Sterialization", "Weight", "WithersHeight" },
                values: new object[,]
                {
                    { 3L, 1L, 1L, 12245678L, true, null, null, new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 0, false, null, null, 10.199999999999999, 0, 15.5, 15.0 },
                    { 5L, 1L, 1L, 12355678L, false, null, null, new DateTime(2018, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1, false, null, null, 10.199999999999999, 0, 2.5, 15.0 },
                    { 7L, 6L, 1L, 12345778L, true, null, null, new DateTime(2018, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 0, false, null, null, 10.199999999999999, 2, 25.5, 45.0 },
                    { 8L, 2L, 1L, 12345688L, true, null, null, new DateTime(2018, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 0, false, null, null, 10.199999999999999, 0, 2.5, 15.0 },
                    { 9L, 2L, 2L, 12345681L, false, null, null, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1, false, null, null, 1.2, 1, 12.5, 5.0 },
                    { 12L, 1L, 1L, 444445688L, false, null, null, new DateTime(2018, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 0, false, null, null, 10.199999999999999, 0, 222.5, 15.0 },
                    { 13L, 2L, 1L, 12342138L, true, null, null, new DateTime(2018, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 0, false, null, null, 10.199999999999999, 0, 2.5, 15.0 },
                    { 14L, 2L, 1L, 32132688L, true, null, null, new DateTime(2018, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 0, false, null, null, 10.199999999999999, 0, 42.5, 125.0 },
                    { 2L, 2L, 2L, 13345678L, false, null, null, new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 1, true, null, null, 9.1999999999999993, 2, 25.5, 45.0 },
                    { 6L, 6L, 2L, 12346678L, true, null, null, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 0, false, null, null, 1.2, 0, 25.5, 45.0 },
                    { 11L, 4L, 3L, 11145688L, true, null, null, new DateTime(2016, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 1, false, null, null, 10.199999999999999, 0, 21.5, 5.0 },
                    { 16L, 3L, 2L, 12345611L, true, null, null, new DateTime(2014, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 0, true, null, null, 10.199999999999999, 0, 2.5, 15.0 },
                    { 4L, 4L, 3L, 12445678L, false, null, null, new DateTime(2014, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L, 0, false, null, null, 10.199999999999999, 1, 5.5, 5.0 },
                    { 10L, 5L, 1L, 33345688L, true, null, null, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L, 0, false, null, null, 10.199999999999999, 0, 2.5, 15.0 },
                    { 15L, 4L, 2L, 88885688L, false, null, null, new DateTime(2012, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L, 1, true, null, null, 0.20000000000000001, 0, 2.5, 15.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalAttitudeTo_AttitudeId",
                table: "AnimalAttitudeTo",
                column: "AttitudeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalDefects_DefectsId",
                table: "AnimalDefects",
                column: "DefectsId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalKeeping_KeepingId",
                table: "AnimalKeeping",
                column: "KeepingId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalNeeds_NeedsId",
                table: "AnimalNeeds",
                column: "NeedsId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalProcessing_ProcessingId",
                table: "AnimalProcessing",
                column: "ProcessingId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AddressId",
                table: "Animals",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CategoryId",
                table: "Animals",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_FoodId",
                table: "Animals",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalVaccination_VaccinationId",
                table: "AnimalVaccination",
                column: "VaccinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_AnimalId1",
                table: "Images",
                column: "AnimalId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalAttitudeTo");

            migrationBuilder.DropTable(
                name: "AnimalDefects");

            migrationBuilder.DropTable(
                name: "AnimalKeeping");

            migrationBuilder.DropTable(
                name: "AnimalNeeds");

            migrationBuilder.DropTable(
                name: "AnimalProcessing");

            migrationBuilder.DropTable(
                name: "AnimalVaccination");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "AttitudeTo");

            migrationBuilder.DropTable(
                name: "Defects");

            migrationBuilder.DropTable(
                name: "Keepings");

            migrationBuilder.DropTable(
                name: "Needs");

            migrationBuilder.DropTable(
                name: "Processings");

            migrationBuilder.DropTable(
                name: "Vaccinations");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
