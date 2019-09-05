﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Repositories.SqlServer;

namespace School.Repositories.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("School.Domain.School", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("School.Domain.SchoolSignature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("Credits");

                    b.Property<Guid>("SchoolId");

                    b.Property<Guid>("SignatureId");

                    b.Property<Guid?>("TeacherId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.HasIndex("SignatureId");

                    b.HasIndex("TeacherId");

                    b.ToTable("SchoolSignature");
                });

            modelBuilder.Entity("School.Domain.Section", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("MaxStudentsCapacity");

                    b.Property<Guid>("SchoolId");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("School.Domain.Signature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Signatures");
                });

            modelBuilder.Entity("School.Domain.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<Guid>("SchoolId");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("School.Domain.SchoolSignature", b =>
                {
                    b.HasOne("School.Domain.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("School.Domain.Signature", "Signature")
                        .WithMany()
                        .HasForeignKey("SignatureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("School.Domain.Teacher")
                        .WithMany("Signatures")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("School.Domain.Section", b =>
                {
                    b.HasOne("School.Domain.School", "School")
                        .WithMany("Sections")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("School.Domain.Teacher", b =>
                {
                    b.HasOne("School.Domain.School", "School")
                        .WithMany("Teachers")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
