using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentFinder.Migrations
{
    public partial class ChangeStudentIdtoStudentSchoolId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "StudentSchoolId",
                table: "Student",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentSchoolId",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Student",
                nullable: false,
                defaultValue: 0);
        }
    }
}
