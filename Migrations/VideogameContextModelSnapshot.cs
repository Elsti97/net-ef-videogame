﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using net_ef_videogame.Models;

#nullable disable

namespace net_ef_videogame.Migrations
{
    [DbContext(typeof(VideogameContext))]
    partial class VideogameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SoftwareHouse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SoftwareHouses");
                });

            modelBuilder.Entity("net_ef_videogame.Models.Videogame", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("SoftwareHouseId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SoftwareHouseId");

                    b.ToTable("Videogames");
                });

            modelBuilder.Entity("net_ef_videogame.Models.Videogame", b =>
                {
                    b.HasOne("SoftwareHouse", "SoftwareHouse")
                        .WithMany("Videogame")
                        .HasForeignKey("SoftwareHouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SoftwareHouse");
                });

            modelBuilder.Entity("SoftwareHouse", b =>
                {
                    b.Navigation("Videogame");
                });
#pragma warning restore 612, 618
        }
    }
}
