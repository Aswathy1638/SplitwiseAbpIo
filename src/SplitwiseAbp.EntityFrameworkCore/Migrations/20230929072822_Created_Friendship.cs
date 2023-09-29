using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SplitwiseAbp.Migrations
{
    /// <inheritdoc />
    public partial class CreatedFriendship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        { 
        //{
        //    migrationBuilder.DropPrimaryKey(
        //        name: "PK_AppFriends",
        //        table: "AppFriends");

        //    migrationBuilder.RenameTable(
        //        name: "AppFriends",
        //        newName: "AppFriendS");

        //    migrationBuilder.AddPrimaryKey(
        //        name: "PK_AppFriendS",
        //        table: "AppFriendS",
        //        column: "Id");

        //    migrationBuilder.CreateTable(
        //        name: "AppFriendShips",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            FriendId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            FriendName = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AppFriendShips", x => x.Id);
        //        });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "AppFriendShips");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_AppFriendS",
            //    table: "AppFriendS");

            //migrationBuilder.RenameTable(
            //    name: "AppFriendS",
            //    newName: "AppFriends");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_AppFriends",
            //    table: "AppFriends",
            //    column: "Id");
        }
    }
}
