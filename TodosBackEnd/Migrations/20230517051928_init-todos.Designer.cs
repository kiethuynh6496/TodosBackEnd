﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodosBackEnd.Data;

namespace TodosBackEnd.Migrations
{
    [DbContext(typeof(TodosDbContext))]
    [Migration("20230517051928_init-todos")]
    partial class inittodos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TodosBackEnd.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsComplete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsComplete = false,
                            Name = "Nhiệm vụ 1"
                        },
                        new
                        {
                            Id = 2,
                            IsComplete = false,
                            Name = "Nhiệm vụ 2"
                        },
                        new
                        {
                            Id = 3,
                            IsComplete = false,
                            Name = "Nhiệm vụ 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}