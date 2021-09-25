using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMigrationTest.Migrations
{
    public partial class NoChangesExceptUpdateToEFCore6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Address_AddressId",
                table: "Company");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Company",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Address_AddressId",
                table: "Company",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Address_AddressId",
                table: "Company");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Address_AddressId",
                table: "Company",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
