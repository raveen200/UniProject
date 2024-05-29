﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoServices.API.Data;

#nullable disable

namespace ToDoServices.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240529184336_setdb2")]
    partial class setdb2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ToDoServices.API.Model.TodoTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Tile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TodoTasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description 1",
                            IsCompleted = false,
                            Tile = "Task 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description 2",
                            IsCompleted = false,
                            Tile = "Task 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description 3",
                            IsCompleted = false,
                            Tile = "Task 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}