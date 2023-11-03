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
    [Migration("20230918123432_addFacility_Road")]
    partial class addFacility_Road
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RoadAppWEB.Models.facility", b =>
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

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("facility");
                });

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

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("overpass_id")
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

            modelBuilder.Entity("RoadAppWEB.Models.ramp", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("avg_length")
                        .HasColumnType("real");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("end_node")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linknode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("overpass_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("start_node")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("viaduct_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ramp");
                });

            modelBuilder.Entity("RoadAppWEB.Models.road", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("avg_length")
                        .HasColumnType("real");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("end_linknode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("end_node")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("facility_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("start_linknode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("start_node")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("road");
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
