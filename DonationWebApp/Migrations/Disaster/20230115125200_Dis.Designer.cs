﻿// <auto-generated />
using System;
using DonationWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DonationWebApp.Migrations.Disaster
{
    [DbContext(typeof(DisasterContext))]
    [Migration("20230115125200_Dis")]
    partial class Dis
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DonationWebApp.Models.DisasterClass", b =>
                {
                    b.Property<int>("DisasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("DisasterName")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("RequiredAidTypes")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DisasterId");

                    b.ToTable("Disaster");
                });
#pragma warning restore 612, 618
        }
    }
}
