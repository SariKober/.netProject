﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Solid.Data;

#nullable disable

namespace Solid.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240125105344_try")]
    partial class @try
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Solid.Core.Models.Girl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<double>("Heigh")
                        .HasColumnType("float");

                    b.Property<bool>("IfGiveFlat")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seminary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("girls");
                });

            modelBuilder.Entity("Solid.Core.Models.Guy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<double>("Heigh")
                        .HasColumnType("float");

                    b.Property<bool>("IfGiveFlat")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yeshiva")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("guys");
                });

            modelBuilder.Entity("Solid.Core.Models.Matchmaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExperienceYear")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("matchmakers");
                });

            modelBuilder.Entity("Solid.Core.Models.Proposal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GirlId")
                        .HasColumnType("int");

                    b.Property<int>("GuyId")
                        .HasColumnType("int");

                    b.Property<int?>("MatchmakerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GirlId");

                    b.HasIndex("GuyId");

                    b.HasIndex("MatchmakerId");

                    b.ToTable("proposal");
                });

            modelBuilder.Entity("Solid.Core.Models.Proposal", b =>
                {
                    b.HasOne("Solid.Core.Models.Girl", "Girl")
                        .WithMany("Proposals")
                        .HasForeignKey("GirlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Solid.Core.Models.Guy", "Guy")
                        .WithMany("Proposals")
                        .HasForeignKey("GuyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Solid.Core.Models.Matchmaker", null)
                        .WithMany("Proposals")
                        .HasForeignKey("MatchmakerId");

                    b.Navigation("Girl");

                    b.Navigation("Guy");
                });

            modelBuilder.Entity("Solid.Core.Models.Girl", b =>
                {
                    b.Navigation("Proposals");
                });

            modelBuilder.Entity("Solid.Core.Models.Guy", b =>
                {
                    b.Navigation("Proposals");
                });

            modelBuilder.Entity("Solid.Core.Models.Matchmaker", b =>
                {
                    b.Navigation("Proposals");
                });
#pragma warning restore 612, 618
        }
    }
}
