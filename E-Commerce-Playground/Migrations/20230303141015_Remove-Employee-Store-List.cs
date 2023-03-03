using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Playground.Migrations
{
    /// <inheritdoc />
    public partial class RemoveEmployeeStoreList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Stores_StoreID",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "StoreID",
                table: "Employees",
                newName: "StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_StoreID",
                table: "Employees",
                newName: "IX_Employees_StoreId");

            migrationBuilder.AlterColumn<int>(
                name: "StoreId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Stores_StoreId",
                table: "Employees",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Stores_StoreId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "Employees",
                newName: "StoreID");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_StoreId",
                table: "Employees",
                newName: "IX_Employees_StoreID");

            migrationBuilder.AlterColumn<int>(
                name: "StoreID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Stores_StoreID",
                table: "Employees",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
