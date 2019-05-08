using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace formulario.Migrations
{
    public partial class TipoDocumento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoDocumentoID",
                table: "Contactos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TiposDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDocumentos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_TipoDocumentoID",
                table: "Contactos",
                column: "TipoDocumentoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contactos_TiposDocumentos_TipoDocumentoID",
                table: "Contactos",
                column: "TipoDocumentoID",
                principalTable: "TiposDocumentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contactos_TiposDocumentos_TipoDocumentoID",
                table: "Contactos");

            migrationBuilder.DropTable(
                name: "TiposDocumentos");

            migrationBuilder.DropIndex(
                name: "IX_Contactos_TipoDocumentoID",
                table: "Contactos");

            migrationBuilder.DropColumn(
                name: "TipoDocumentoID",
                table: "Contactos");
        }
    }
}
