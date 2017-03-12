using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using StudentFinder.Data;

namespace StudentFinder.Migrations
{
    [DbContext(typeof(StudentFinderContext))]
    [Migration("20170311060456_UpdateAllModels")]
    partial class UpdateAllModels
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

                    b.Property<string>("City");

                    b.Property<string>("Contact");

                    b.Property<string>("Domain");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<string>("ZipCode");

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
