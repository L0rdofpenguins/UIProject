using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelerikUI.Migrations
{
    public partial class initial_data_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SystemMaterials_SystemSerials_SystemId",
                table: "SystemMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemSerials_Orders_OrderId1",
                table: "SystemSerials");

            migrationBuilder.DropIndex(
                name: "IX_SystemSerials_OrderId1",
                table: "SystemSerials");

            migrationBuilder.DropIndex(
                name: "IX_SystemMaterials_SystemId",
                table: "SystemMaterials");

            migrationBuilder.DropColumn(
                name: "OrderId1",
                table: "SystemSerials");

            migrationBuilder.DropColumn(
                name: "SystemId",
                table: "SystemMaterials");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SystemSerials",
                newName: "SystemSerialId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SystemMaterials",
                newName: "SystemMaterialId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "SystemSerials",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SystemSerialId",
                table: "SystemMaterials",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialName", "Manufacturer" },
                values: new object[,]
                {
                    { "1", "Advantech" },
                    { "9", "Advantech" },
                    { "8", "Advantech" },
                    { "7", "Advantech" },
                    { "6", "Advantech" },
                    { "10", "Advantech" },
                    { "4", "Advantech" },
                    { "3", "Advantech" },
                    { "2", "Advantech" },
                    { "5", "Advantech" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "FinishDate", "StartDate" },
                values: new object[,]
                {
                    { "9", null, new DateTime(2019, 4, 8, 17, 55, 39, 648, DateTimeKind.Local).AddTicks(157) },
                    { "1", null, new DateTime(2019, 4, 8, 17, 55, 39, 638, DateTimeKind.Local).AddTicks(9706) },
                    { "2", null, new DateTime(2019, 4, 8, 17, 55, 39, 647, DateTimeKind.Local).AddTicks(9232) },
                    { "3", null, new DateTime(2019, 4, 8, 17, 55, 39, 647, DateTimeKind.Local).AddTicks(9870) },
                    { "4", null, new DateTime(2019, 4, 8, 17, 55, 39, 647, DateTimeKind.Local).AddTicks(9928) },
                    { "5", null, new DateTime(2019, 4, 8, 17, 55, 39, 647, DateTimeKind.Local).AddTicks(9973) },
                    { "6", null, new DateTime(2019, 4, 8, 17, 55, 39, 648, DateTimeKind.Local).AddTicks(26) },
                    { "7", null, new DateTime(2019, 4, 8, 17, 55, 39, 648, DateTimeKind.Local).AddTicks(71) },
                    { "8", null, new DateTime(2019, 4, 8, 17, 55, 39, 648, DateTimeKind.Local).AddTicks(115) },
                    { "10", null, new DateTime(2019, 4, 8, 17, 55, 39, 648, DateTimeKind.Local).AddTicks(206) }
                });

            migrationBuilder.InsertData(
                table: "SystemSerials",
                columns: new[] { "SystemSerialId", "OrderId" },
                values: new object[,]
                {
                    { 1, "1" },
                    { 2, "2" },
                    { 3, "3" },
                    { 4, "4" },
                    { 5, "5" },
                    { 6, "6" },
                    { 7, "7" },
                    { 8, "8" },
                    { 9, "9" },
                    { 10, "10" }
                });

            migrationBuilder.InsertData(
                table: "SystemMaterials",
                columns: new[] { "SystemMaterialId", "MaterialName", "SystemSerialId" },
                values: new object[] { new Guid("a5e53837-a20b-4c0e-8de9-cbd6950543ea"), "1", 1 });

            migrationBuilder.InsertData(
                table: "SystemMaterials",
                columns: new[] { "SystemMaterialId", "MaterialName", "SystemSerialId" },
                values: new object[] { new Guid("065c2969-9fdc-42a2-9bc9-accec9857e45"), "2", 2 });

            migrationBuilder.InsertData(
                table: "SystemMaterials",
                columns: new[] { "SystemMaterialId", "MaterialName", "SystemSerialId" },
                values: new object[] { new Guid("8f6fef39-05e5-45ea-adb8-4f895a1be0e4"), "3", 3 });

            migrationBuilder.InsertData(
                table: "SystemMaterials",
                columns: new[] { "SystemMaterialId", "MaterialName", "SystemSerialId" },
                values: new object[] { new Guid("da4a422b-526f-46b6-b433-f994c2876d85"), "4", 4 });

            migrationBuilder.InsertData(
                table: "SystemMaterials",
                columns: new[] { "SystemMaterialId", "MaterialName", "SystemSerialId" },
                values: new object[] { new Guid("3686d152-1a31-48ce-ad93-6f420d5cf6df"), "5", 5 });

            migrationBuilder.InsertData(
                table: "SystemMaterials",
                columns: new[] { "SystemMaterialId", "MaterialName", "SystemSerialId" },
                values: new object[] { new Guid("9e6e180f-966c-457b-9ed0-052f7b239aed"), "6", 6 });

            migrationBuilder.InsertData(
                table: "SystemMaterials",
                columns: new[] { "SystemMaterialId", "MaterialName", "SystemSerialId" },
                values: new object[] { new Guid("6f195afd-ff3d-42ba-9bc2-7b4bc7d69097"), "7", 7 });

            migrationBuilder.InsertData(
                table: "SystemMaterials",
                columns: new[] { "SystemMaterialId", "MaterialName", "SystemSerialId" },
                values: new object[] { new Guid("21a3c6b2-bc58-4408-b885-cbf4984f13b4"), "8", 8 });

            migrationBuilder.InsertData(
                table: "SystemMaterials",
                columns: new[] { "SystemMaterialId", "MaterialName", "SystemSerialId" },
                values: new object[] { new Guid("8ed0779d-0738-4c2c-a9fd-8f34a32bbc4a"), "9", 9 });

            migrationBuilder.InsertData(
                table: "SystemMaterials",
                columns: new[] { "SystemMaterialId", "MaterialName", "SystemSerialId" },
                values: new object[] { new Guid("87a41731-6ff6-4b33-8b78-61ee1a13eb53"), "10", 10 });

            migrationBuilder.CreateIndex(
                name: "IX_SystemSerials_OrderId",
                table: "SystemSerials",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemMaterials_SystemSerialId",
                table: "SystemMaterials",
                column: "SystemSerialId");

            migrationBuilder.AddForeignKey(
                name: "FK_SystemMaterials_SystemSerials_SystemSerialId",
                table: "SystemMaterials",
                column: "SystemSerialId",
                principalTable: "SystemSerials",
                principalColumn: "SystemSerialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemSerials_Orders_OrderId",
                table: "SystemSerials",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SystemMaterials_SystemSerials_SystemSerialId",
                table: "SystemMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemSerials_Orders_OrderId",
                table: "SystemSerials");

            migrationBuilder.DropIndex(
                name: "IX_SystemSerials_OrderId",
                table: "SystemSerials");

            migrationBuilder.DropIndex(
                name: "IX_SystemMaterials_SystemSerialId",
                table: "SystemMaterials");

            migrationBuilder.DeleteData(
                table: "SystemMaterials",
                keyColumn: "SystemMaterialId",
                keyValue: new Guid("065c2969-9fdc-42a2-9bc9-accec9857e45"));

            migrationBuilder.DeleteData(
                table: "SystemMaterials",
                keyColumn: "SystemMaterialId",
                keyValue: new Guid("21a3c6b2-bc58-4408-b885-cbf4984f13b4"));

            migrationBuilder.DeleteData(
                table: "SystemMaterials",
                keyColumn: "SystemMaterialId",
                keyValue: new Guid("3686d152-1a31-48ce-ad93-6f420d5cf6df"));

            migrationBuilder.DeleteData(
                table: "SystemMaterials",
                keyColumn: "SystemMaterialId",
                keyValue: new Guid("6f195afd-ff3d-42ba-9bc2-7b4bc7d69097"));

            migrationBuilder.DeleteData(
                table: "SystemMaterials",
                keyColumn: "SystemMaterialId",
                keyValue: new Guid("87a41731-6ff6-4b33-8b78-61ee1a13eb53"));

            migrationBuilder.DeleteData(
                table: "SystemMaterials",
                keyColumn: "SystemMaterialId",
                keyValue: new Guid("8ed0779d-0738-4c2c-a9fd-8f34a32bbc4a"));

            migrationBuilder.DeleteData(
                table: "SystemMaterials",
                keyColumn: "SystemMaterialId",
                keyValue: new Guid("8f6fef39-05e5-45ea-adb8-4f895a1be0e4"));

            migrationBuilder.DeleteData(
                table: "SystemMaterials",
                keyColumn: "SystemMaterialId",
                keyValue: new Guid("9e6e180f-966c-457b-9ed0-052f7b239aed"));

            migrationBuilder.DeleteData(
                table: "SystemMaterials",
                keyColumn: "SystemMaterialId",
                keyValue: new Guid("a5e53837-a20b-4c0e-8de9-cbd6950543ea"));

            migrationBuilder.DeleteData(
                table: "SystemMaterials",
                keyColumn: "SystemMaterialId",
                keyValue: new Guid("da4a422b-526f-46b6-b433-f994c2876d85"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "SystemSerials",
                keyColumn: "SystemSerialId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SystemSerials",
                keyColumn: "SystemSerialId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SystemSerials",
                keyColumn: "SystemSerialId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SystemSerials",
                keyColumn: "SystemSerialId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SystemSerials",
                keyColumn: "SystemSerialId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SystemSerials",
                keyColumn: "SystemSerialId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SystemSerials",
                keyColumn: "SystemSerialId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SystemSerials",
                keyColumn: "SystemSerialId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SystemSerials",
                keyColumn: "SystemSerialId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SystemSerials",
                keyColumn: "SystemSerialId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "9");

            migrationBuilder.DropColumn(
                name: "SystemSerialId",
                table: "SystemMaterials");

            migrationBuilder.RenameColumn(
                name: "SystemSerialId",
                table: "SystemSerials",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SystemMaterialId",
                table: "SystemMaterials",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "SystemSerials",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderId1",
                table: "SystemSerials",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SystemId",
                table: "SystemMaterials",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SystemSerials_OrderId1",
                table: "SystemSerials",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_SystemMaterials_SystemId",
                table: "SystemMaterials",
                column: "SystemId");

            migrationBuilder.AddForeignKey(
                name: "FK_SystemMaterials_SystemSerials_SystemId",
                table: "SystemMaterials",
                column: "SystemId",
                principalTable: "SystemSerials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemSerials_Orders_OrderId1",
                table: "SystemSerials",
                column: "OrderId1",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
