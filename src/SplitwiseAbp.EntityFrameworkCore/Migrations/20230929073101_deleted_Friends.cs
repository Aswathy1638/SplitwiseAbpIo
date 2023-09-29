using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SplitwiseAbp.Migrations
{
    /// <inheritdoc />
    public partial class deletedFriends : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "AppFriendS");

            //migrationBuilder.DropTable(
            //    name: "AppFriendShips");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "AppFriendS",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FriendId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        FriendName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AppFriendS", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AppFriendShips",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FriendId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        FriendName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AppFriendShips", x => x.Id);
            //    });
        }
    }
}
