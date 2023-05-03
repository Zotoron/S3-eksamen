using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace S3_eksamen.Migrations
{
    /// <inheritdoc />
    public partial class Boghandler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bøger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Forfatter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Udgiver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Udgivelsesår = table.Column<int>(type: "int", nullable: false),
                    Eksemplarer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bøger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lånte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dato = table.Column<int>(type: "int", nullable: false),
                    Låner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LånteBog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Antal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lånte", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bøger");

            migrationBuilder.DropTable(
                name: "Lånte");
        }
    }
}
