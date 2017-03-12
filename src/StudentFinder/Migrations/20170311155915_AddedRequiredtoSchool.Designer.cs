using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using StudentFinder.Data;

namespace StudentFinder.Migrations
{
    [DbContext(typeof(StudentFinderContext))]
    [Migration("20170311155915_AddedRequiredtoSchool")]
    partial class AddedRequiredtoSchool
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentFinder.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("From")
                        .IsRequired();

                    b.Property<string>("Label")
                        .IsRequired();

                    b.Property<int?>("StudentId");

                    b.Property<string>("To")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("StudentFinder.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Contact")
                        .IsRequired();

                    b.Property<string>("Domain")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("School");
                });

            modelBuilder.Entity("StudentFinder.Models.Space", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Room")
                        .IsRequired();

                    b.Property<int?>("ScheduleId");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Space");
                });

            modelBuilder.Entity("StudentFinder.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GradeLevel")
                        .IsRequired();

                    b.Property<int>("SchoolId");

                    b.Property<int?>("SpaceId");

                    b.Property<int>("StudentId");

                    b.Property<string>("fName")
                        .IsRequired();

                    b.Property<string>("lName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("SpaceId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentFinder.Models.Schedule", b =>
                {
                    b.HasOne("StudentFinder.Models.Student")
                        .WithMany("Schedules")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("StudentFinder.Models.Space", b =>
                {
                    b.HasOne("StudentFinder.Models.Schedule")
                        .WithMany("Spaces")
                        .HasForeignKey("ScheduleId");
                });

            modelBuilder.Entity("StudentFinder.Models.Student", b =>
                {
                    b.HasOne("StudentFinder.Models.Space")
                        .WithMany("Students")
                        .HasForeignKey("SpaceId");
                });
        }
    }
}
