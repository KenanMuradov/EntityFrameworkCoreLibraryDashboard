﻿// <auto-generated />
using System;
using EntityFrameworkCoreLibraryDashboard.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkCoreLibraryDashboard.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Id_Author")
                        .HasColumnType("int");

                    b.Property<int>("Id_Category")
                        .HasColumnType("int");

                    b.Property<int>("Id_Press")
                        .HasColumnType("int");

                    b.Property<int>("Id_Theme")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("YearPress")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Author");

                    b.HasIndex("Id_Category");

                    b.HasIndex("Id_Press");

                    b.HasIndex("Id_Theme");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Id_Faculty")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Faculty");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Lib", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Libs");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Press", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Presses");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.S_Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 1, 30, 15, 43, 15, 835, DateTimeKind.Local).AddTicks(9259));

                    b.Property<int>("Id_Book")
                        .HasColumnType("int");

                    b.Property<int>("Id_Lib")
                        .HasColumnType("int");

                    b.Property<int>("Id_Student")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Book");

                    b.HasIndex("Id_Lib");

                    b.HasIndex("Id_Student");

                    b.ToTable("S_Cards");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Id_Group")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Group");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.T_Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 1, 30, 15, 43, 15, 835, DateTimeKind.Local).AddTicks(3820));

                    b.Property<int>("Id_Book")
                        .HasColumnType("int");

                    b.Property<int>("Id_Lib")
                        .HasColumnType("int");

                    b.Property<int>("Id_Teacher")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Book");

                    b.HasIndex("Id_Lib");

                    b.HasIndex("Id_Teacher");

                    b.ToTable("T_Cards");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Id_Dep")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Dep");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Book", b =>
                {
                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("Id_Author")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("Id_Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Press", "Press")
                        .WithMany("Books")
                        .HasForeignKey("Id_Press")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Theme", "Theme")
                        .WithMany("Books")
                        .HasForeignKey("Id_Theme")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Press");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Group", b =>
                {
                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Faculty", "Faculty")
                        .WithMany("Groups")
                        .HasForeignKey("Id_Faculty")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.S_Card", b =>
                {
                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Book", "Book")
                        .WithMany("S_Cards")
                        .HasForeignKey("Id_Book")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Lib", "Lib")
                        .WithMany("S_Cards")
                        .HasForeignKey("Id_Lib")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Student", "Student")
                        .WithMany("S_Cards")
                        .HasForeignKey("Id_Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Lib");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Student", b =>
                {
                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("Id_Group")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.T_Card", b =>
                {
                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Book", "Book")
                        .WithMany("T_Cards")
                        .HasForeignKey("Id_Book")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Lib", "Lib")
                        .WithMany("T_Cards")
                        .HasForeignKey("Id_Lib")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Teacher", "Teacher")
                        .WithMany("T_Cards")
                        .HasForeignKey("Id_Teacher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Lib");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Teacher", b =>
                {
                    b.HasOne("EntityFrameworkCoreLibraryDashboard.Models.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("Id_Dep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Book", b =>
                {
                    b.Navigation("S_Cards");

                    b.Navigation("T_Cards");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Department", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Faculty", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Lib", b =>
                {
                    b.Navigation("S_Cards");

                    b.Navigation("T_Cards");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Press", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Student", b =>
                {
                    b.Navigation("S_Cards");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Teacher", b =>
                {
                    b.Navigation("T_Cards");
                });

            modelBuilder.Entity("EntityFrameworkCoreLibraryDashboard.Models.Theme", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
