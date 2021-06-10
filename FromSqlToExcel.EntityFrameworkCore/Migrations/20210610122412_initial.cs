using Microsoft.EntityFrameworkCore.Migrations;

namespace FromSqlToExcel.EntityFrameworkCore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Izdels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izdels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    IzdelUpId = table.Column<int>(type: "int", nullable: true),
                    IzdelId = table.Column<int>(type: "int", nullable: true),
                    Kol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Accounts_Izdels_IzdelId",
                        column: x => x.IzdelId,
                        principalTable: "Izdels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Izdels_IzdelUpId",
                        column: x => x.IzdelUpId,
                        principalTable: "Izdels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_IzdelId",
                table: "Accounts",
                column: "IzdelId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_IzdelUpId",
                table: "Accounts",
                column: "IzdelUpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Izdels");
        }
    }
}
