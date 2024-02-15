using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resturant_App.Migrations
{
    public partial class test44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryAdderss",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "OrdereDate",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "orders",
                newName: "orderId");

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "orders",
                newName: "OrderID");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryAdderss",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OrdereDate",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
