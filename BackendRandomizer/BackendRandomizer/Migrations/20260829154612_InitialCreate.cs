using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendRandomizer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Slot = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    WeaponCategory = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaponAttachments",
                columns: table => new
                {
                    WeaponId = table.Column<int>(type: "INTEGER", nullable: false),
                    AttachmentId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponAttachments", x => new { x.WeaponId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_WeaponAttachments_Attachments_AttachmentId",
                        column: x => x.AttachmentId,
                        principalTable: "Attachments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponAttachments_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Attachments",
                columns: new[] { "Id", "Name", "Slot" },
                values: new object[,]
                {
                    { 1, "7.62x39 Suppressor", 2 },
                    { 2, "AKM Premium Stable Flash Suppressor", 2 },
                    { 3, "AKM Precision Flash Suppressor", 2 },
                    { 4, "AK Series 7.62x39 Suppressor", 2 },
                    { 5, "AKM Standard Flash Suppressor", 2 },
                    { 6, "AKM Stabilized Flash Suppressor", 2 },
                    { 7, "AKM Compatible Hexagon Suppressor", 2 },
                    { 8, "AK Guard Muzzle Brake", 2 },
                    { 9, "Classic Flash Suppressor", 2 },
                    { 10, "Multi-Port Flash Suppressor", 2 },
                    { 11, "Precission Flash Suppressor", 2 },
                    { 12, "AR-10 Muzzle Flash Suppressor", 2 },
                    { 13, "MG 3 Muzzle Flash Suppressor", 2 },
                    { 14, "Mk14/M14 Suppressor", 2 },
                    { 15, "7.62x51mm Caliber SureFire Suppressor", 2 },
                    { 16, "191 Muzzle Compensator", 2 },
                    { 17, "T19X Flash Suppressor", 2 },
                    { 18, "U191 Suppressor", 2 },
                    { 19, "1x/4x Scope", 0 },
                    { 20, "1x/6x Scope", 0 },
                    { 21, "2x Sight*", 0 },
                    { 22, "3.5x Scope", 0 },
                    { 23, "6.5/20x Scope", 0 },
                    { 24, "2x/7x Scope", 0 },
                    { 25, "4x/16x Scope", 0 },
                    { 26, "3x Scope", 0 },
                    { 27, "3x Combination Holographic Scope", 0 },
                    { 28, "4x Holographic Triangle Scope", 0 },
                    { 29, "533 Holographic Sight", 0 },
                    { 30, "EKP-8-18 Reflex Sight", 0 },
                    { 31, "Bat Ear Holographic Scope", 0 },
                    { 32, "Classic Holographic Scope", 0 },
                    { 33, "Classic Compact Red Dot Sight", 0 },
                    { 34, "Whirlpool Holographic Scope", 0 },
                    { 35, "Periscope Hybrid Sight", 0 },
                    { 36, "M1 Tactical Red Dot", 0 },
                    { 37, "Modern Red Dot Sight", 0 },
                    { 38, "PK-06 Reflex Sight", 0 },
                    { 39, "PZ4 THERMAL SCOPE", 0 },
                    { 40, "Raised Precision Red Dot Sight", 0 },
                    { 41, "Simple Red Dot Sight", 0 },
                    { 42, "Tactical Red Dot Scope", 0 },
                    { 43, "Triangle Precision Sight", 0 }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Name", "WeaponCategory" },
                values: new object[,]
                {
                    { 1, "AKM", 0 },
                    { 2, "FAL", 0 },
                    { 3, "T191", 0 }
                });

            migrationBuilder.InsertData(
                table: "WeaponAttachments",
                columns: new[] { "AttachmentId", "WeaponId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 8, 1 },
                    { 19, 1 },
                    { 20, 1 },
                    { 21, 1 },
                    { 22, 1 },
                    { 23, 1 },
                    { 24, 1 },
                    { 25, 1 },
                    { 26, 1 },
                    { 27, 1 },
                    { 28, 1 },
                    { 29, 1 },
                    { 30, 1 },
                    { 31, 1 },
                    { 32, 1 },
                    { 33, 1 },
                    { 34, 1 },
                    { 35, 1 },
                    { 36, 1 },
                    { 37, 1 },
                    { 38, 1 },
                    { 39, 1 },
                    { 40, 1 },
                    { 41, 1 },
                    { 42, 1 },
                    { 43, 1 },
                    { 9, 2 },
                    { 10, 2 },
                    { 11, 2 },
                    { 12, 2 },
                    { 13, 2 },
                    { 14, 2 },
                    { 15, 2 },
                    { 19, 2 },
                    { 20, 2 },
                    { 21, 2 },
                    { 22, 2 },
                    { 23, 2 },
                    { 24, 2 },
                    { 25, 2 },
                    { 26, 2 },
                    { 27, 2 },
                    { 28, 2 },
                    { 29, 2 },
                    { 30, 2 },
                    { 31, 2 },
                    { 32, 2 },
                    { 33, 2 },
                    { 34, 2 },
                    { 35, 2 },
                    { 36, 2 },
                    { 37, 2 },
                    { 38, 2 },
                    { 39, 2 },
                    { 40, 2 },
                    { 41, 2 },
                    { 42, 2 },
                    { 43, 2 },
                    { 16, 3 },
                    { 17, 3 },
                    { 18, 3 },
                    { 19, 3 },
                    { 20, 3 },
                    { 21, 3 },
                    { 22, 3 },
                    { 23, 3 },
                    { 24, 3 },
                    { 25, 3 },
                    { 26, 3 },
                    { 27, 3 },
                    { 28, 3 },
                    { 29, 3 },
                    { 30, 3 },
                    { 31, 3 },
                    { 32, 3 },
                    { 33, 3 },
                    { 34, 3 },
                    { 35, 3 },
                    { 36, 3 },
                    { 37, 3 },
                    { 38, 3 },
                    { 39, 3 },
                    { 40, 3 },
                    { 41, 3 },
                    { 42, 3 },
                    { 43, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponAttachments_AttachmentId",
                table: "WeaponAttachments",
                column: "AttachmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponAttachments");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
