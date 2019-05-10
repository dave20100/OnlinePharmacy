using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePharmacy.Migrations
{
    public partial class refundpercent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPrescription",
                table: "Products",
                newName: "IsPrescripted");

            migrationBuilder.AddColumn<int>(
                name: "RefundPercentage",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefundPercentage",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "IsPrescripted",
                table: "Products",
                newName: "IsPrescription");
        }
    }
}
