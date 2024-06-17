using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace New_Grid_Api.Migrations
{
    public partial class MyThirdDemoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quentity",
                table: "product_Details",
                newName: "Quantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "product_Details",
                newName: "Quentity");
        }
    }
}
