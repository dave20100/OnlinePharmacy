using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePharmacy.Migrations
{
    public partial class idk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerAddress = table.Column<string>(nullable: true),
                    PESEL = table.Column<string>(nullable: true),
                    NFZNumber = table.Column<string>(nullable: true),
                    MedicineName = table.Column<string>(nullable: true),
                    ClinicInfo = table.Column<string>(nullable: true),
                    DoctorsName = table.Column<string>(nullable: true),
                    DateOfCreating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PrescriptionId",
                table: "Orders",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Prescription_PrescriptionId",
                table: "Orders",
                column: "PrescriptionId",
                principalTable: "Prescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Prescription_PrescriptionId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PrescriptionId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Orders");
        }
    }
}
