﻿// <auto-generated />
using System;
using Laboratorium_4_2.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Laboratorium_4_2.Migrations.MovieDBMigrations
{
    [DbContext(typeof(MovieDB))]
    partial class MovieDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("Laboratorium_4_2.Components.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<float?>("Rate")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("RelaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Two",
                            Rate = 7f,
                            Title = "The Shawshank Redemption"
                        },
                        new
                        {
                            Id = 2,
                            Description = "No no no",
                            Rate = 4f,
                            Title = "Baby Shark"
                        },
                        new
                        {
                            Id = 3,
                            Description = "No",
                            Rate = 5f,
                            Title = "The Challengers"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
