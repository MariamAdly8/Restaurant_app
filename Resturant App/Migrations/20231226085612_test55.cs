using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resturant_App.Migrations
{
    public partial class test55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_delivaryMen_delivaryId",
                table: "orders");

            migrationBuilder.DropTable(
                name: "delivaryMen");

            migrationBuilder.DropIndex(
                name: "IX_orders_delivaryId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "delivaryId",
                table: "orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "delivaryId",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "delivaryMen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delivaryMen", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_delivaryId",
                table: "orders",
                column: "delivaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_delivaryMen_delivaryId",
                table: "orders",
                column: "delivaryId",
                principalTable: "delivaryMen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
