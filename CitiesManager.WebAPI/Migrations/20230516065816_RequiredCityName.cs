using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitiesManager.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RequiredCityName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Cities",
                newName: "CityID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CityID",
                table: "Cities",
                newName: "CityId");
        }
    }
}
