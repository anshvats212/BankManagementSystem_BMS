﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankLoan_Management133.Repositoryy.Migrations
{
    /// <inheritdoc />
    public partial class a9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    interest = table.Column<int>(type: "int", nullable: false),
                    minAmount = table.Column<int>(type: "int", nullable: false),
                    maxAmount = table.Column<int>(type: "int", nullable: false),
                    tenure = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanProducts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanProducts");
        }
    }
}
