using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoTrack.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenameCargoExtraServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExtraService",
                table: "Cargos",
                newName: "ExtraServices");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExtraServices",
                table: "Cargos",
                newName: "ExtraService");
        }
    }
}
