using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokeymanz.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokeymanz",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Species = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Types = table.Column<string[]>(type: "text[]", maxLength: 2, nullable: false),
                    Level = table.Column<decimal>(type: "numeric", nullable: false),
                    Ability = table.Column<string>(type: "text", nullable: false),
                    HeldItem = table.Column<string>(type: "text", nullable: true),
                    AvailableAttacks = table.Column<string[]>(type: "text[]", nullable: false),
                    EquippedAttacks = table.Column<string[]>(type: "text[]", maxLength: 4, nullable: false),
                    Nature = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    EggGroup = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokeymanz", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokeymanz");
        }
    }
}
