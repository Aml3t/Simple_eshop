using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Simple_Eshop.Migrations
{
    public partial class OrderAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressLine",
                table: "Orders",
                newName: "AddressLine1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressLine1",
                table: "Orders",
                newName: "AddressLine");
        }
    }
}
