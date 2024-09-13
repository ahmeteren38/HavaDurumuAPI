using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesss.Migrations
{
    /// <inheritdoc />
    public partial class firstmig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SehirHavaDurumlari_TBL",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SehirAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SorguZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Derece = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HavaDurumuAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SehirHavaDurumlari_TBL", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SehirHavaDurumlari_TBL");
        }
    }
}
