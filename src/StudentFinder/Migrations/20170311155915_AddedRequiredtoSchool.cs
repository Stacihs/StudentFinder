using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentFinder.Migrations
{
    public partial class AddedRequiredtoSchool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "School",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "School",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "School",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "School",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "School",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Domain",
                table: "School",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "School",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "School",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "School",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "School",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "School",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "School",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "School",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Domain",
                table: "School",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "School",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "School",
                nullable: true);
        }
    }
}
