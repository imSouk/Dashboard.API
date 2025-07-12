using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboard_webAPI.Migrations
{
    /// <inheritdoc />
    public partial class orderStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "orderStats",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "orderStats",
                table: "Orders");
        }
    }
}
