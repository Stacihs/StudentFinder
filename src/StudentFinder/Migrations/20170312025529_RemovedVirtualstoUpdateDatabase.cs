using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentFinder.Migrations
{
    public partial class RemovedVirtualstoUpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Student_StudentId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Space_Schedule_ScheduleId",
                table: "Space");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Space_SpaceId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_SpaceId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Space_ScheduleId",
                table: "Space");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_StudentId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "SpaceId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "Space");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Schedule");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpaceId",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Space",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Schedule",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_SpaceId",
                table: "Student",
                column: "SpaceId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Space_SpaceId",
                table: "Student",
                column: "SpaceId",
                principalTable: "Space",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
