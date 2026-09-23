using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendRandomizer.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreAttachments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attachments",
                columns: new[] { "Id", "Name", "Slot" },
                values: new object[,]
                {
                    { 44, "AK Compatible Rear Grip", 4 },
                    { 45, "Industrial AK Rear Grip", 4 },
                    { 46, "AK Modern Rear Grip", 4 },
                    { 47, "AK 12 Standard Rear Grip", 4 },
                    { 48, "KGB Lightweight AK Rear Grip", 4 },
                    { 49, "Lightweight AK Rear Grip", 4 },
                    { 50, "RK-3 Industrial AK Rear Grip", 4 },
                    { 51, "SAW Tactical AK Rear Grip", 4 },
                    { 52, "AK Series Standard Rear Grip", 4 },
                    { 53, "Dedicated FAL Rear Grip", 4 },
                    { 54, "FAL Comfortable Rear Grip", 4 },
                    { 55, "T19X Standard Rear Grip", 4 },
                    { 56, "Type 81 Stock", 1 },
                    { 57, "AK-74 Wooden Stock", 1 },
                    { 58, "AK Series High-Performance Buttstock", 1 },
                    { 59, "AK-74 Polymer Bootstock", 1 },
                    { 60, "AK Series AP Tactical Stock", 1 },
                    { 61, "AK Series FAB Buttstock", 1 },
                    { 62, "AK Series GS FixedStock", 1 },
                    { 63, "AK Series GS Modern Stock", 1 },
                    { 64, "AK Series ME Modern Stock", 1 },
                    { 65, "AK-Series SF Gen 2 Stock", 1 },
                    { 66, "AK-Series SF Lightweight Buttstock", 1 },
                    { 67, "FAL Lightweight Stock", 1 },
                    { 68, "FAL Polymer Stock", 1 },
                    { 69, "FAL Special Stock", 1 },
                    { 70, "FAL Stable Stock", 1 },
                    { 71, "FAL Triangle Stock", 1 },
                    { 72, "191 Assault Stock", 1 },
                    { 73, "191 Sniper Stock", 1 },
                    { 74, "T19X Standard Stock", 1 },
                    { 75, "Alloy Tactical Front Grip", 3 },
                    { 76, "Alluminum Vertical Front Grip", 3 },
                    { 77, "Comfortable Front Grip", 3 },
                    { 78, "KIR Tilt Front Grip", 3 },
                    { 79, "Lightweight Tactical Front Grip", 3 },
                    { 80, "Lightweight Long Grip", 3 },
                    { 81, "Lightweight Short Grip", 3 },
                    { 82, "Lightweight Tilt Front Grip", 3 },
                    { 83, "Lightweight Tactical Vertical Front Grip", 3 },
                    { 84, "RK-O Control Front Grip", 3 },
                    { 85, "RK-6 Front Grip", 3 },
                    { 86, "Short Vertical Front Grip", 3 },
                    { 87, "B25 Tilt Front Grip", 3 },
                    { 88, "Stable Triangular Front Grip", 3 },
                    { 89, "Vertical Front Grip", 3 },
                    { 90, "NO GRIP", 3 }
                });

            migrationBuilder.InsertData(
                table: "WeaponAttachments",
                columns: new[] { "AttachmentId", "WeaponId" },
                values: new object[,]
                {
                    { 44, 1 },
                    { 45, 1 },
                    { 46, 1 },
                    { 47, 1 },
                    { 48, 1 },
                    { 49, 1 },
                    { 50, 1 },
                    { 51, 1 },
                    { 52, 1 },
                    { 56, 1 },
                    { 57, 1 },
                    { 58, 1 },
                    { 59, 1 },
                    { 60, 1 },
                    { 61, 1 },
                    { 62, 1 },
                    { 63, 1 },
                    { 64, 1 },
                    { 65, 1 },
                    { 66, 1 },
                    { 75, 1 },
                    { 76, 1 },
                    { 77, 1 },
                    { 78, 1 },
                    { 79, 1 },
                    { 80, 1 },
                    { 81, 1 },
                    { 82, 1 },
                    { 83, 1 },
                    { 84, 1 },
                    { 85, 1 },
                    { 86, 1 },
                    { 87, 1 },
                    { 88, 1 },
                    { 89, 1 },
                    { 90, 1 },
                    { 53, 2 },
                    { 54, 2 },
                    { 67, 2 },
                    { 68, 2 },
                    { 69, 2 },
                    { 70, 2 },
                    { 71, 2 },
                    { 75, 2 },
                    { 76, 2 },
                    { 77, 2 },
                    { 78, 2 },
                    { 79, 2 },
                    { 80, 2 },
                    { 81, 2 },
                    { 82, 2 },
                    { 83, 2 },
                    { 84, 2 },
                    { 85, 2 },
                    { 86, 2 },
                    { 87, 2 },
                    { 88, 2 },
                    { 89, 2 },
                    { 90, 2 },
                    { 55, 3 },
                    { 72, 3 },
                    { 73, 3 },
                    { 74, 3 },
                    { 75, 3 },
                    { 76, 3 },
                    { 77, 3 },
                    { 78, 3 },
                    { 79, 3 },
                    { 80, 3 },
                    { 81, 3 },
                    { 82, 3 },
                    { 83, 3 },
                    { 84, 3 },
                    { 85, 3 },
                    { 86, 3 },
                    { 87, 3 },
                    { 88, 3 },
                    { 89, 3 },
                    { 90, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 46, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 76, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 78, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 81, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 82, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 83, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 84, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 86, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 88, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 89, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 90, 1 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 53, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 54, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 67, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 68, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 69, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 70, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 71, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 75, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 76, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 77, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 79, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 80, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 83, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 84, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 85, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 86, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 87, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 88, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 89, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 90, 2 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 55, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 72, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 73, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 74, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 75, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 76, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 77, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 78, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 79, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 80, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 81, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 82, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 83, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 84, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 85, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 86, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 87, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 88, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 89, 3 });

            migrationBuilder.DeleteData(
                table: "WeaponAttachments",
                keyColumns: new[] { "AttachmentId", "WeaponId" },
                keyValues: new object[] { 90, 3 });

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 90);
        }
    }
}
