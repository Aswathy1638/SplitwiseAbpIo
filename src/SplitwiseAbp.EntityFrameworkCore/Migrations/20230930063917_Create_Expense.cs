using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SplitwiseAbp.Migrations
{
    /// <inheritdoc />
    public partial class CreateExpense : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ExpenseId",
                table: "AbpUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppExpenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    paiduserid = table.Column<Guid>(name: "paiduser_id", type: "uniqueidentifier", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    shareAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppExpenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppExpenses_AppGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "AppGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_ExpenseId",
                table: "AbpUsers",
                column: "ExpenseId");

            migrationBuilder.CreateIndex(
                name: "IX_AppExpenses_GroupId",
                table: "AppExpenses",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AppExpenses_ExpenseId",
                table: "AbpUsers",
                column: "ExpenseId",
                principalTable: "AppExpenses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AppExpenses_ExpenseId",
                table: "AbpUsers");

            migrationBuilder.DropTable(
                name: "AppExpenses");

            migrationBuilder.DropIndex(
                name: "IX_AbpUsers_ExpenseId",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "ExpenseId",
                table: "AbpUsers");
        }
    }
}
