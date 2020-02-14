using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ChangesinDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Addresses_AddressId1",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Foods_FoodId1",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_AddressId1",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_FoodId1",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "AddressId1",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "FoodId1",
                table: "Animals");

            migrationBuilder.AlterColumn<long>(
                name: "FoodId",
                table: "Animals",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "CategotyId",
                table: "Animals",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "AddressId",
                table: "Animals",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AddressId",
                table: "Animals",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_FoodId",
                table: "Animals",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Addresses_AddressId",
                table: "Animals",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Foods_FoodId",
                table: "Animals",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Addresses_AddressId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Foods_FoodId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_AddressId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_FoodId",
                table: "Animals");

            migrationBuilder.AlterColumn<int>(
                name: "FoodId",
                table: "Animals",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "CategotyId",
                table: "Animals",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Animals",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "AddressId1",
                table: "Animals",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FoodId1",
                table: "Animals",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AddressId1",
                table: "Animals",
                column: "AddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_FoodId1",
                table: "Animals",
                column: "FoodId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Addresses_AddressId1",
                table: "Animals",
                column: "AddressId1",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Foods_FoodId1",
                table: "Animals",
                column: "FoodId1",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
