using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class initDbupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "AnimalVaccination");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AnimalAttitudeTo");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "AnimalProcessing",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AnimalProcessing",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "AnimalProcessing",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "AnimalProcessing",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "AnimalNeeds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AnimalNeeds",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "AnimalNeeds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "AnimalNeeds",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "AnimalKeeping",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AnimalKeeping",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "AnimalKeeping",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "AnimalKeeping",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "AnimalDefects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AnimalDefects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "AnimalDefects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "AnimalDefects",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "AnimalProcessing");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AnimalProcessing");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "AnimalProcessing");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "AnimalProcessing");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "AnimalNeeds");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AnimalNeeds");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "AnimalNeeds");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "AnimalNeeds");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "AnimalKeeping");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AnimalKeeping");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "AnimalKeeping");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "AnimalKeeping");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "AnimalDefects");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AnimalDefects");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "AnimalDefects");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "AnimalDefects");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "AnimalVaccination",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "AnimalAttitudeTo",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
