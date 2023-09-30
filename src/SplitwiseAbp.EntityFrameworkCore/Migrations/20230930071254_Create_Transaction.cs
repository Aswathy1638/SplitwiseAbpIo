using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SplitwiseAbp.Migrations
{
    /// <inheritdoc />
    public partial class CreateTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TransactionId",
                table: "AbpUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    groupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    payerUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    paidUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    expenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    transactionAmount = table.Column<decimal>(name: "transaction_Amount", type: "decimal(18,2)", nullable: false),
                    transactionDate = table.Column<DateTime>(name: "transaction_Date", type: "datetime2", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppTransactions_AppExpenses_expenseId",
                        column: x => x.expenseId,
                        principalTable: "AppExpenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_TransactionId",
                table: "AbpUsers",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppTransactions_expenseId",
                table: "AppTransactions",
                column: "expenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AppTransactions_TransactionId",
                table: "AbpUsers",
                column: "TransactionId",
                principalTable: "AppTransactions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AppTransactions_TransactionId",
                table: "AbpUsers");

            migrationBuilder.DropTable(
                name: "AppTransactions");

            migrationBuilder.DropIndex(
                name: "IX_AbpUsers_TransactionId",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "AbpUsers");
        }
    }
}
