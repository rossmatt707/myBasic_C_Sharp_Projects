using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarInsurance.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInsureeSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coverage",
                table: "Insurees");

            migrationBuilder.AddColumn<string>(
                name: "Coverages",
                table: "Insurees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coverages",
                table: "Insurees");

            migrationBuilder.AddColumn<int>(
                name: "Coverage",
                table: "Insurees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
