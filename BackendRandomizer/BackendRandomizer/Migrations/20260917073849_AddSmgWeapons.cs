using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendRandomizer.Migrations
{
    /// <inheritdoc />
    public partial class AddSmgWeapons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attachments",
                columns: new[] { "Id", "Name", "Slot" },
                values: new object[,]
                {
                    { 91, "9mm Muzzle Brake", 2 },
                    { 92, "9x19 Conventional Suppressor", 2 },
                    { 93, "9mm Lightweight Muzzle Brake", 2 },
                    { 94, "9x19 Lightweight Suppressor", 2 },
                    { 95, "9x19 Suppressor", 2 },
                    { 96, "Dedicated MPX Muzzle Brake", 2 },
                    { 97, "P90 Special Handguard", 2 },
                    { 98, "Dedicated P90 Flash Suppressor", 2 },
                    { 99, "P90 Conventional Suppressor", 2 },
                    { 100, "P50A Suppressor", 2 },
                    { 101, "Dedicated P90 Flash Suppressor", 2 },
                    { 102, "P90 Flash Suppressor Adapter + P90 Conventional Suppressor", 2 },
                    { 103, "Alloy Tactical Front Grip", 3 },
                    { 104, "Alluminum Vertical Front Grip", 3 },
                    { 105, "Comfortable Front Grip", 3 },
                    { 106, "KIR Tilt Front Grip", 3 },
                    { 107, "Lightweight Tactical Front Grip", 3 },
                    { 108, "Lightweight Long Grip", 3 },
                    { 109, "Lightweight Short Grip", 3 },
                    { 110, "Lightweight Tilt Front Grip", 3 },
                    { 111, "Lightweight Tactical Vertical Front Grip", 3 },
                    { 112, "RK-O Control Front Grip", 3 },
                    { 113, "RK-6 Front Grip", 3 },
                    { 114, "Short Vertical Front Grip", 3 },
                    { 115, "B25 Tilt Front Grip", 3 },
                    { 116, "Stable Triangular Front Grip", 3 },
                    { 117, "Vertical Front Grip", 3 },
                    { 118, "NO GRIP", 3 },
                    { 119, "Available", 3 },
                    { 120, "NO FRONT GRIP", 3 },
                    { 121, "MPX Standard-Issue Collapsible Stock", 1 },
                    { 122, "MPX Collapsible Stock", 1 },
                    { 123, "AR Recoil Buffer", 1 },
                    { 124, "FA Gen4 Tactical Stock", 1 },
                    { 125, "FA Desert Tan Gen 2 Collapsible Stock", 1 },
                    { 126, "FA Gen 2 Collapsible Stock", 1 },
                    { 127, "M16 Standard Stock", 1 },
                    { 128, "M4A1 Simple Recoil Buffer", 1 },
                    { 129, "Professional Collapsible Stock", 1 },
                    { 130, "P90 OEM Stock", 1 },
                    { 131, "P90 High-Performance Stock", 1 },
                    { 132, "AR Modernizer Improved Buttstock", 1 },
                    { 133, "AR Universal Nylon Buttstock", 1 },
                    { 134, "AR Precision Stock", 1 },
                    { 135, "AR Balanced Buttstock", 1 },
                    { 136, "Banshee Standard Stock", 1 },
                    { 137, "Carabine Lightweight Stock", 1 },
                    { 138, "Carabine Industrial Stock", 1 },
                    { 139, "Collapsible Compatible Stock", 1 },
                    { 140, "Compatible Lightweight Stock", 1 },
                    { 141, "FA Gen 3 Precision Rifle Stock", 1 },
                    { 142, "GL Shock Lightweight Stock", 1 },
                    { 143, "M4 Standard Stock", 1 },
                    { 144, "AR Comfortable Rear Grip", 4 },
                    { 145, "AR Compatible Rear Grip", 4 },
                    { 146, "Industrial AR Rear Grip", 4 },
                    { 147, "AR Modernized Rear Grip", 4 },
                    { 148, "Premium AR Compatible Grip", 4 },
                    { 149, "AR Classic Third-Party Grip", 4 },
                    { 150, "Lightweight AR Rear Grip", 4 },
                    { 151, "Lightweight Skeleton AR Rear Grip", 4 },
                    { 152, "Lightweight Tactical AR Rear Grip", 4 },
                    { 153, "MPX Standard Polymer Rear Grip", 4 },
                    { 154, "Standard Polymer AR Rear Grip", 4 },
                    { 155, "Polymer Lightweight AR Rear Grip", 4 },
                    { 156, "SCAR Stomped Grip", 4 },
                    { 157, "SCAR-L Rear Grip", 4 },
                    { 158, "Stable Industrial AR Rear Grip", 4 },
                    { 159, "Banshee Standard Grip", 4 },
                    { 160, "Universal Tactical Rear Grip", 4 }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Name", "WeaponCategory" },
                values: new object[,]
                {
                    { 4, "MPX", 1 },
                    { 5, "P90", 1 },
                    { 6, "Banshee", 1 }
                });

            migrationBuilder.InsertData(
                table: "WeaponAttachments",
                columns: new[] { "AttachmentId", "WeaponId" },
                values: new object[,]
                {
                    { 19, 4 },
                    { 20, 4 },
                    { 21, 4 },
                    { 22, 4 },
                    { 23, 4 },
                    { 24, 4 },
                    { 25, 4 },
                    { 26, 4 },
                    { 27, 4 },
                    { 28, 4 },
                    { 29, 4 },
                    { 30, 4 },
                    { 31, 4 },
                    { 32, 4 },
                    { 33, 4 },
                    { 34, 4 },
                    { 35, 4 },
                    { 36, 4 },
                    { 37, 4 },
                    { 38, 4 },
                    { 39, 4 },
                    { 40, 4 },
                    { 41, 4 },
                    { 42, 4 },
                    { 43, 4 },
                    { 91, 4 },
                    { 92, 4 },
                    { 93, 4 },
                    { 94, 4 },
                    { 95, 4 },
                    { 96, 4 },
                    { 103, 4 },
                    { 104, 4 },
                    { 105, 4 },
                    { 106, 4 },
                    { 107, 4 },
                    { 108, 4 },
                    { 109, 4 },
                    { 110, 4 },
                    { 111, 4 },
                    { 112, 4 },
                    { 113, 4 },
                    { 114, 4 },
                    { 115, 4 },
                    { 116, 4 },
                    { 117, 4 },
                    { 118, 4 },
                    { 121, 4 },
                    { 122, 4 },
                    { 123, 4 },
                    { 124, 4 },
                    { 125, 4 },
                    { 126, 4 },
                    { 127, 4 },
                    { 128, 4 },
                    { 129, 4 },
                    { 144, 4 },
                    { 145, 4 },
                    { 146, 4 },
                    { 147, 4 },
                    { 148, 4 },
                    { 149, 4 },
                    { 150, 4 },
                    { 151, 4 },
                    { 152, 4 },
                    { 153, 4 },
                    { 154, 4 },
                    { 155, 4 },
                    { 156, 4 },
                    { 157, 4 },
                    { 158, 4 },
                    { 19, 5 },
                    { 20, 5 },
                    { 21, 5 },
                    { 22, 5 },
                    { 23, 5 },
                    { 24, 5 },
                    { 25, 5 },
                    { 26, 5 },
                    { 27, 5 },
                    { 28, 5 },
                    { 29, 5 },
                    { 30, 5 },
                    { 31, 5 },
                    { 32, 5 },
                    { 33, 5 },
                    { 34, 5 },
                    { 35, 5 },
                    { 36, 5 },
                    { 37, 5 },
                    { 38, 5 },
                    { 39, 5 },
                    { 40, 5 },
                    { 41, 5 },
                    { 42, 5 },
                    { 43, 5 },
                    { 97, 5 },
                    { 98, 5 },
                    { 99, 5 },
                    { 119, 5 },
                    { 120, 5 },
                    { 130, 5 },
                    { 131, 5 },
                    { 19, 6 },
                    { 20, 6 },
                    { 21, 6 },
                    { 22, 6 },
                    { 23, 6 },
                    { 24, 6 },
                    { 25, 6 },
                    { 26, 6 },
                    { 27, 6 },
                    { 28, 6 },
                    { 29, 6 },
                    { 30, 6 },
                    { 31, 6 },
                    { 32, 6 },
                    { 33, 6 },
                    { 34, 6 },
                    { 35, 6 },
                    { 36, 6 },
                    { 37, 6 },
                    { 38, 6 },
                    { 39, 6 },
                    { 40, 6 },
                    { 41, 6 },
                    { 42, 6 },
                    { 43, 6 },
                    { 100, 6 },
                    { 101, 6 },
                    { 102, 6 },
                    { 103, 6 },
                    { 104, 6 },
                    { 105, 6 },
                    { 106, 6 },
                    { 107, 6 },
                    { 108, 6 },
                    { 109, 6 },
                    { 110, 6 },
                    { 111, 6 },
                    { 112, 6 },
                    { 113, 6 },
                    { 114, 6 },
                    { 115, 6 },
                    { 116, 6 },
                    { 117, 6 },
                    { 118, 6 },
                    { 132, 6 },
                    { 133, 6 },
                    { 134, 6 },
                    { 135, 6 },
                    { 136, 6 },
                    { 137, 6 },
                    { 138, 6 },
                    { 139, 6 },
                    { 140, 6 },
                    { 141, 6 },
                    { 142, 6 },
                    { 143, 6 },
                    { 144, 6 },
                    { 145, 6 },
                    { 146, 6 },
                    { 147, 6 },
                    { 148, 6 },
                    { 149, 6 },
                    { 150, 6 },
                    { 151, 6 },
                    { 152, 6 },
                    { 153, 6 },
                    { 154, 6 },
                    { 155, 6 },
                    { 156, 6 },
                    { 157, 6 },
                    { 158, 6 },
                    { 159, 6 },
                    { 160, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 25, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 30, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 31, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 32, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 33, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 34, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 35, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 36, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 37, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 38, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 39, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 40, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 41, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 42, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 43, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 91, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 92, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 93, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 94, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 95, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 96, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 103, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 104, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 105, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 106, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 107, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 108, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 109, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 110, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 111, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 112, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 113, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 114, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 115, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 116, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 117, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 118, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 121, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 122, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 123, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 124, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 125, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 126, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 127, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 128, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 129, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 144, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 145, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 146, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 147, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 148, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 149, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 150, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 151, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 152, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 153, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 154, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 155, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 156, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 157, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 158, 4 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 21, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 32, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 34, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 35, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 36, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 37, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 38, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 39, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 40, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 41, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 42, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 43, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 97, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 98, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 99, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 119, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 120, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 130, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 131, 5 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 23, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 24, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 27, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 28, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 29, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 30, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 31, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 32, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 33, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 34, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 35, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 36, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 37, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 38, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 39, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 40, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 41, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 42, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 43, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 100, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 101, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 102, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 103, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 104, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 105, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 106, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 107, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 108, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 109, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 110, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 111, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 112, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 113, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 114, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 115, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 116, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 117, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 118, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 132, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 133, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 134, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 135, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 136, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 137, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 138, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 139, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 140, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 141, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 142, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 143, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 144, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 145, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 146, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 147, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 148, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 149, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 150, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 151, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 152, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 153, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 154, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 155, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 156, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 157, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 158, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 159, 6 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 160, 6 });

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
