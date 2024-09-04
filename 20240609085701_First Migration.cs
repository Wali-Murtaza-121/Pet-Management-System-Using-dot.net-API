using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PetsInfo",
                columns: table => new
                {
                    PetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PetAge = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DateOfAdd = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DateOfExit = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PetGender = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PetCategory = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PetRoutine = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PetFood = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PetDietRoutine = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PetDose = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PetDoseRoutine = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetsInfo", x => x.PetId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetsInfo");
        }
    }
}
