using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SplitwiseAbp.Migrations
{
    /// <inheritdoc />
    public partial class CreatedFriendss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_AppFriends",
            //    table: "AppFriends");

            //migrationBuilder.AddColumn<int>(
            //    name: "Id",
            //    table: "AppFriends",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0)
            //    .Annotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_AppFriends",
            //    table: "AppFriends",
            //    column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_AppFriends",
            //    table: "AppFriends");

            //migrationBuilder.DropColumn(
            //    name: "Id",
            //    table: "AppFriends");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_AppFriends",
            //    table: "AppFriends",
            //    column: "FriendId");
        }
    }
}
