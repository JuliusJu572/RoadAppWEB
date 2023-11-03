﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoadAppWEB.Data;

#nullable disable

namespace RoadAppWEB.Migrations
{
    [DbContext(typeof(RoadAppWEBContext))]
    [Migration("20230918121747_addViaduct")]
    partial class addViaduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RoadAppWEB.Models.mainline", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EndNode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartNode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("avg_length")
                        .HasColumnType("real");

                    b.Property<string>("direction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("viaduct_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("mainline");
                });

            modelBuilder.Entity("RoadAppWEB.Models.node", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("childnode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fathernode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hubnode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("latitude")
                        .HasColumnType("float");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.Property<double>("longitude")
                        .HasColumnType("float");

                    b.Property<string>("mainline_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ramp_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("node");
                });

            modelBuilder.Entity("RoadAppWEB.Models.overpass", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("lanes")
                        .HasColumnType("int");

                    b.Property<double?>("length")
                        .HasColumnType("float");

                    b.Property<string>("maintenanceunit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("operatingunit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("square")
                        .HasColumnType("float");

                    b.Property<string>("trunknetwork")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("overpass");
                });

            modelBuilder.Entity("RoadAppWEB.Models.viaduct", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("lanes")
                        .HasColumnType("int");

                    b.Property<double?>("length")
                        .HasColumnType("float");

                    b.Property<string>("maintenanceunit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("operatingunit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("square")
                        .HasColumnType("float");

                    b.Property<string>("trunknetwork")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("viaduct");
                });
#pragma warning restore 612, 618
        }
    }
}
