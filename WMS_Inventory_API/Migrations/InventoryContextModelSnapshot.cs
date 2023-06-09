﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WMS_Inventory_API;

#nullable disable

namespace WMS_Inventory_API.Migrations
{
    [DbContext(typeof(InventoryContext))]
    partial class InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WMS_Inventory_API.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address1 = "5814 N 17th St",
                            Address2 = "",
                            City = "Tampa",
                            Email = "charles.baker@gmail.com",
                            Name = "Charles Baker",
                            Password = "password",
                            State = "FL",
                            ZipCode = 33610
                        });
                });

            modelBuilder.Entity("WMS_Inventory_API.Models.Container", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StorageLocationId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StorageLocationId");

                    b.ToTable("Container");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Brown corrugated box containing hand tools",
                            StorageLocationId = 2,
                            Type = "Box"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Clear plastic w/ blue lid - metal fasteners",
                            StorageLocationId = 2,
                            Type = "Tote"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Blue painted wooden chest - fishing tackle",
                            StorageLocationId = 1,
                            Type = "Chest"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Far left cabinet under built in work bench",
                            StorageLocationId = 1,
                            Type = "Cabinet"
                        });
                });

            modelBuilder.Entity("WMS_Inventory_API.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ContainerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContainerId");

                    b.ToTable("Content");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContainerId = 1,
                            Description = "5 lbs box 2 inch cut nails",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            ContainerId = 1,
                            Description = "1 lbs box 2 1/2 in cut nails",
                            Quantity = 3
                        },
                        new
                        {
                            Id = 3,
                            ContainerId = 1,
                            Description = "Misc boxes of cut nails - finish, box, brad",
                            Quantity = 6
                        },
                        new
                        {
                            Id = 4,
                            ContainerId = 1,
                            Description = "Misc boxes wood screws, brass/bronze, #8/9, 3/4 in - 1 1/2 in",
                            Quantity = 4
                        },
                        new
                        {
                            Id = 5,
                            ContainerId = 2,
                            Description = "Mom's winter clothes - slacks, tops, sweaters",
                            Quantity = 25
                        },
                        new
                        {
                            Id = 6,
                            ContainerId = 3,
                            Description = "Box of fly reels - Berkley, Ross, Pflueger",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 7,
                            ContainerId = 3,
                            Description = "Leonard 37H flyrod",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 8,
                            ContainerId = 3,
                            Description = "Orvis Fullflex fly/spin rod",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 9,
                            ContainerId = 3,
                            Description = "Box of spinning reels - Shakespeare, Micron, Mitchell",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 10,
                            ContainerId = 4,
                            Description = "Makita 7 1/4 in track saw",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 11,
                            ContainerId = 4,
                            Description = "Parallel guides for Makita track",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 12,
                            ContainerId = 4,
                            Description = "Makita 10 in circular saw",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 13,
                            ContainerId = 4,
                            Description = "Skilsaw 5 1/2 in circular saw",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 14,
                            ContainerId = 4,
                            Description = "Ryobi One+ tools - 1/2 in drill, finish sander, brad nailer",
                            Quantity = 3
                        },
                        new
                        {
                            Id = 15,
                            ContainerId = 4,
                            Description = "Milwaukee 7 1/4 in circular saw",
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("WMS_Inventory_API.Models.StorageLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("StorageLocation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            Address1 = "5814 N 17th St",
                            Address2 = "",
                            City = "Tampa",
                            Latitude = -82.440321999999995,
                            LocationName = "Home Shop",
                            Longitude = 27.995778000000001,
                            State = "FL",
                            ZipCode = 33610
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 1,
                            Address1 = "1711 E Hillsborough Ave",
                            Address2 = "",
                            City = "Tampa",
                            Latitude = -82.441528000000005,
                            LocationName = "Extra Space Storage",
                            Longitude = 28.000686999999999,
                            State = "FL",
                            ZipCode = 33610
                        });
                });

            modelBuilder.Entity("WMS_Inventory_API.Models.Container", b =>
                {
                    b.HasOne("WMS_Inventory_API.Models.StorageLocation", "StorageLocation")
                        .WithMany("Container")
                        .HasForeignKey("StorageLocationId");

                    b.Navigation("StorageLocation");
                });

            modelBuilder.Entity("WMS_Inventory_API.Models.Content", b =>
                {
                    b.HasOne("WMS_Inventory_API.Models.Container", "Container")
                        .WithMany("Content")
                        .HasForeignKey("ContainerId");

                    b.Navigation("Container");
                });

            modelBuilder.Entity("WMS_Inventory_API.Models.StorageLocation", b =>
                {
                    b.HasOne("WMS_Inventory_API.Models.Account", null)
                        .WithMany("StorageLocation")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("WMS_Inventory_API.Models.Account", b =>
                {
                    b.Navigation("StorageLocation");
                });

            modelBuilder.Entity("WMS_Inventory_API.Models.Container", b =>
                {
                    b.Navigation("Content");
                });

            modelBuilder.Entity("WMS_Inventory_API.Models.StorageLocation", b =>
                {
                    b.Navigation("Container");
                });
#pragma warning restore 612, 618
        }
    }
}
