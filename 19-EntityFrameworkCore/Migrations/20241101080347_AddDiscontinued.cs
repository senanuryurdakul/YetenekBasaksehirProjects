using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _19_EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscontinued : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Discontinued",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discontinued",
                table: "Products");
        }
    }
}
