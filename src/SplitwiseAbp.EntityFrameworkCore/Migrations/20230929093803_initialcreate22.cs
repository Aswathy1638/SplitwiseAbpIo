using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SplitwiseAbp.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_AppUserGroup_AbpUsers_GroupId",
            //    table: "AppUserGroup");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_AppUserGroup_AppGroups_GroupId1",
            //    table: "AppUserGroup");

            //migrationBuilder.DropIndex(
            //    name: "IX_AppUserGroup_GroupId1",
            //    table: "AppUserGroup");

            //migrationBuilder.DropColumn(
            //    name: "GroupId1",
            //    table: "AppUserGroup");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AppUserGroup_UserId",
            //    table: "AppUserGroup",
            //    column: "UserId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AppUserGroup_AbpUsers_UserId",
            //    table: "AppUserGroup",
            //    column: "UserId",
            //    principalTable: "AbpUsers",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AppUserGroup_AppGroups_GroupId",
            //    table: "AppUserGroup",
            //    column: "GroupId",
            //    principalTable: "AppGroups",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_AppUserGroup_AbpUsers_UserId",
            //    table: "AppUserGroup");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_AppUserGroup_AppGroups_GroupId",
            //    table: "AppUserGroup");

            //migrationBuilder.DropIndex(
            //    name: "IX_AppUserGroup_UserId",
            //    table: "AppUserGroup");

            //migrationBuilder.AddColumn<Guid>(
            //    name: "GroupId1",
            //    table: "AppUserGroup",
            //    type: "uniqueidentifier",
            //    nullable: false,
            //    defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            //migrationBuilder.CreateIndex(
            //    name: "IX_AppUserGroup_GroupId1",
            //    table: "AppUserGroup",
            //    column: "GroupId1");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AppUserGroup_AbpUsers_GroupId",
            //    table: "AppUserGroup",
            //    column: "GroupId",
            //    principalTable: "AbpUsers",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AppUserGroup_AppGroups_GroupId1",
            //    table: "AppUserGroup",
            //    column: "GroupId1",
            //    principalTable: "AppGroups",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
