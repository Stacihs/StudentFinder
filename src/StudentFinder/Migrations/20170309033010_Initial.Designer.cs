using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using StudentFinder.Data;

namespace StudentFinder.Migrations
{
    [DbContext(typeof(StudentFinderContext))]
    [Migration("20170309033010_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentFinder.Models.ScheduleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("StudentFinder.Models.SchoolModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("School");
                });

            modelBuilder.Entity("StudentFinder.Models.SpaceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Space");
                });

            modelBuilder.Entity("StudentFinder.Models.StudentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GradeLevel");

                    b.Property<int?>("SpaceId");

                    b.Property<int>("StudentId");

                    b.Property<string>("fName");

                    b.Property<string>("lName");

                    b.HasKey("Id");

                    b.HasIndex("SpaceId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentFinder.Models.StudentModel", b =>
                {
                    b.HasOne("StudentFinder.Models.SpaceModel", "Space")
                        .WithMany()
                        .HasForeignKey("SpaceId");
                });
        }
    }
}
