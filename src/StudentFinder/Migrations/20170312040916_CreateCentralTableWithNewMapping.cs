using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudentFinder.Migrations
{
    public partial class CreateCentralTableWithNewMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Central",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScheduleId = table.Column<int>(nullable: false),
                    SpaceId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Central", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "CentralId",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CentralId",
                table: "Space",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CentralId",
                table: "Schedule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpaceId",
                table: "Schedule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Schedule",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_CentralId",
                table: "Student",
                column: "CentralId");

            migrationBuilder.CreateIndex(
                name: "IX_Space_CentralId",
                table: "Space",
                column: "CentralId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_CentralId",
                table: "Schedule",
                column: "CentralId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_SpaceId",
                table: "Schedule",
                column: "SpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_StudentId",
                table: "Schedule",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Central_CentralId",
                table: "Schedule",
                column: "CentralId",
                principalTable: "Central",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Space_SpaceId",
                table: "Schedule",
                column: "SpaceId",
                principalTable: "Space",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Student_StudentId",
                table: "Schedule",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Space_Central_CentralId",
                table: "Space",
                column: "CentralId",
                principalTable: "Central",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Central_CentralId",
                table: "Student",
                column: "CentralId",
                principalTable: "Central",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Central_CentralId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Space_SpaceId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Student_StudentId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Space_Central_CentralId",
                table: "Space");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Central_CentralId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_CentralId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Space_CentralId",
                table: "Space");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_CentralId",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_SpaceId",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_StudentId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "CentralId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "CentralId",
                table: "Space");

            migrationBuilder.DropColumn(
                name: "CentralId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "SpaceId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Schedule");

            migrationBuilder.DropTable(
                name: "Central");
        }
    }
}
