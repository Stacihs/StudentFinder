using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentFinder.Migrations
{
    public partial class UpdateAllModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Student",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Space",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Space",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "Space",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Space",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "School",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "School",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Domain",
                table: "School",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "School",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "School",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "School",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "School",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "School",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "From",
                table: "Schedule",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Schedule",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Schedule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "To",
                table: "Schedule",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "lName",
                table: "Student",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "fName",
                table: "Student",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "GradeLevel",
                table: "Student",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Space_ScheduleId",
                table: "Space",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_StudentId",
                table: "Schedule",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Student_StudentId",
                table: "Schedule",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Space_Schedule_ScheduleId",
                table: "Space",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Student_StudentId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Space_Schedule_ScheduleId",
                table: "Space");

            migrationBuilder.DropIndex(
                name: "IX_Space_ScheduleId",
                table: "Space");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_StudentId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Space");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Space");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "Space");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "Space");

            migrationBuilder.DropColumn(
                name: "City",
                table: "School");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "School");

            migrationBuilder.DropColumn(
                name: "Domain",
                table: "School");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "School");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "School");

            migrationBuilder.DropColumn(
                name: "State",
                table: "School");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "School");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "School");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "Label",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Schedule");

            migrationBuilder.AlterColumn<string>(
                name: "lName",
                table: "Student",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "fName",
                table: "Student",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GradeLevel",
                table: "Student",
                nullable: true);
        }
    }
}
