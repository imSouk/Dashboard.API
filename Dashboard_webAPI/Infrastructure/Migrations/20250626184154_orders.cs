using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboard_webAPI.Migrations
{
    /// <inheritdoc />
    public partial class orders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
              migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OderDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Base_selling_price = table.Column<decimal>(type: "nvarchar(max)", nullable: false),
                    Base_selling_quantity = table.Column<int>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

        }
    }
}
