﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrbanZoo.Models;

namespace UrbanZoo_API.Migrations
{
    [DbContext(typeof(UrbanZooContext))]
    [Migration("20220823223947_StreetAddress_field")]
    partial class StreetAddress_field
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("UrbanZoo.Models.Feature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Lat")
                        .HasColumnType("double");

                    b.Property<double>("Lng")
                        .HasColumnType("double");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zipcode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("FeatureId");

                    b.ToTable("Features");

                    b.HasData(
                        new
                        {
                            FeatureId = 1,
                            Availability = true,
                            City = "Portland",
                            CreatedDate = new DateTime(2022, 8, 23, 15, 39, 46, 638, DateTimeKind.Local).AddTicks(6270),
                            Description = "Entire contents of bedroom",
                            Lat = 45.588689330000001,
                            Lng = -122.56404786,
                            State = "OR",
                            StreetAddress = "",
                            Title = "Roommate cleanout",
                            UserId = 4,
                            Zipcode = "97211"
                        },
                        new
                        {
                            FeatureId = 2,
                            Availability = true,
                            City = "Vancouver",
                            CreatedDate = new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1780),
                            Description = "Looks like 100+ figurines of all types",
                            Lat = 45.654670580000001,
                            Lng = -122.53756002,
                            State = "WA",
                            StreetAddress = "",
                            Title = "Dog figurine collection",
                            UserId = 3,
                            Zipcode = "98682"
                        },
                        new
                        {
                            FeatureId = 3,
                            Availability = true,
                            City = "Portland",
                            CreatedDate = new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1810),
                            Description = "Sports equipment",
                            Lat = 45.481928770000003,
                            Lng = -122.5580511,
                            State = "OR",
                            StreetAddress = "",
                            Title = "Sports equipment",
                            UserId = 3,
                            Zipcode = "97266"
                        },
                        new
                        {
                            FeatureId = 4,
                            Availability = true,
                            City = "Vancouver",
                            CreatedDate = new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1820),
                            Description = "Metal junk",
                            Lat = 45.674033960000003,
                            Lng = -122.74122815,
                            State = "WA",
                            StreetAddress = "",
                            Title = "Metal junk",
                            UserId = 2,
                            Zipcode = "98660"
                        },
                        new
                        {
                            FeatureId = 5,
                            Availability = true,
                            City = "Portland",
                            CreatedDate = new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1820),
                            Description = "Books",
                            Lat = 45.573054669999998,
                            Lng = -122.64396572,
                            State = "OR",
                            StreetAddress = "",
                            Title = "Books",
                            UserId = 1,
                            Zipcode = "97211"
                        },
                        new
                        {
                            FeatureId = 6,
                            Availability = true,
                            City = "Vancouver",
                            CreatedDate = new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1830),
                            Description = "looks useable",
                            Lat = 45.707315459999997,
                            Lng = -122.70110880999999,
                            State = "WA",
                            StreetAddress = "",
                            Title = "Clothes dresser",
                            UserId = 4,
                            Zipcode = "98685"
                        },
                        new
                        {
                            FeatureId = 7,
                            Availability = true,
                            City = "Portland",
                            CreatedDate = new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1830),
                            Description = "4 pairs, size men's 10",
                            Lat = 45.487334359999998,
                            Lng = -122.76339163999999,
                            State = "OR",
                            StreetAddress = "",
                            Title = "Shoes",
                            UserId = 1,
                            Zipcode = "97225"
                        },
                        new
                        {
                            FeatureId = 8,
                            Availability = true,
                            City = "Portland",
                            CreatedDate = new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1840),
                            Description = "size medium",
                            Lat = 45.34753517,
                            Lng = -122.66505906,
                            State = "OR",
                            StreetAddress = "",
                            Title = "Box of women's clothes",
                            UserId = 5,
                            Zipcode = "97068"
                        },
                        new
                        {
                            FeatureId = 9,
                            Availability = true,
                            City = "Portland",
                            CreatedDate = new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1840),
                            Description = "2 shovels, 1 hoe, 1 hose",
                            Lat = 45.604418240000001,
                            Lng = -122.8296801,
                            State = "OR",
                            StreetAddress = "",
                            Title = "Garden tools",
                            UserId = 6,
                            Zipcode = "97231"
                        },
                        new
                        {
                            FeatureId = 10,
                            Availability = true,
                            City = "Portland",
                            CreatedDate = new DateTime(2022, 8, 23, 15, 39, 46, 639, DateTimeKind.Local).AddTicks(1850),
                            Description = "Looks well loved, but has some more life in them",
                            Lat = 45.570666279999998,
                            Lng = -122.59853484,
                            State = "OR",
                            StreetAddress = "",
                            Title = "Kids toys",
                            UserId = 2,
                            Zipcode = "97218"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
