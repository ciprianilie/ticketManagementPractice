﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TMS.Api.DbContext;

#nullable disable

namespace TMS.Api.Migrations
{
    [DbContext(typeof(TicketManagementDbContext))]
    [Migration("20230717173324_updated_entities")]
    partial class updated_entities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TMS.Api.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("TMS.Api.Entities.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("EventTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.HasIndex("EventTypeId");

                    b.HasIndex("VenueId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            EndDate = new DateTime(2024, 2, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1073),
                            EventDescription = "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.",
                            EventName = "John Egbert Live",
                            EventTypeId = 1,
                            StartDate = new DateTime(2024, 1, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1039),
                            VenueId = 1
                        },
                        new
                        {
                            EventId = 2,
                            EndDate = new DateTime(2024, 2, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1081),
                            EventDescription = "Michael Johnson doesn't need an introduction. His 25 concert across the globe last year were seen by thousands. Can we add you to the list?",
                            EventName = "The State of Affairs: Michael Live!",
                            EventTypeId = 1,
                            StartDate = new DateTime(2024, 1, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1080),
                            VenueId = 1
                        },
                        new
                        {
                            EventId = 3,
                            EndDate = new DateTime(2024, 2, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1088),
                            EventDescription = "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.",
                            EventName = "John Egbert Live",
                            EventTypeId = 1,
                            StartDate = new DateTime(2024, 1, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1087),
                            VenueId = 2
                        },
                        new
                        {
                            EventId = 4,
                            EndDate = new DateTime(2024, 2, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1093),
                            EventDescription = "DJs from all over the world will compete in this epic battle for eternal fame.",
                            EventName = "Clash of the DJs",
                            EventTypeId = 1,
                            StartDate = new DateTime(2024, 1, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1092),
                            VenueId = 1
                        },
                        new
                        {
                            EventId = 6,
                            EndDate = new DateTime(2024, 2, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1099),
                            EventDescription = "The best tech conference in the world",
                            EventName = "Techorama 2021",
                            EventTypeId = 4,
                            StartDate = new DateTime(2024, 1, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1098),
                            VenueId = 1
                        },
                        new
                        {
                            EventId = 5,
                            EndDate = new DateTime(2024, 2, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1125),
                            EventDescription = "The critics are over the moon and so will you after you've watched this sing and dance extravaganza written by Nick Sailor, the man from 'My dad and sister'.",
                            EventName = "To the Moon and Back",
                            EventTypeId = 2,
                            StartDate = new DateTime(2024, 1, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1124),
                            VenueId = 1
                        });
                });

            modelBuilder.Entity("TMS.Api.Entities.EventType", b =>
                {
                    b.Property<int>("EventTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventTypeId"));

                    b.Property<string>("EventTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventTypeId");

                    b.ToTable("EventTypes");

                    b.HasData(
                        new
                        {
                            EventTypeId = 1,
                            EventTypeName = "Concerts"
                        },
                        new
                        {
                            EventTypeId = 2,
                            EventTypeName = "Musicals"
                        },
                        new
                        {
                            EventTypeId = 3,
                            EventTypeName = "Plays"
                        },
                        new
                        {
                            EventTypeId = 4,
                            EventTypeName = "Conferences"
                        });
                });

            modelBuilder.Entity("TMS.Api.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfTickets")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("TicketCategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EventId");

                    b.HasIndex("TicketCategoryId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TMS.Api.Entities.TicketCategory", b =>
                {
                    b.Property<int>("TicketCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketCategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TicketCategoryId");

                    b.HasIndex("EventId");

                    b.ToTable("TicketCategories");

                    b.HasData(
                        new
                        {
                            TicketCategoryId = 1,
                            Description = "Regular",
                            EventId = 1,
                            Price = 10m
                        },
                        new
                        {
                            TicketCategoryId = 2,
                            Description = "VIP",
                            EventId = 1,
                            Price = 20m
                        });
                });

            modelBuilder.Entity("TMS.Api.Entities.Venue", b =>
                {
                    b.Property<int>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenueId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VenueId");

                    b.ToTable("Venue");

                    b.HasData(
                        new
                        {
                            VenueId = 1,
                            Capacity = 20,
                            Location = "Remote"
                        },
                        new
                        {
                            VenueId = 2,
                            Capacity = 20,
                            Location = "Physical"
                        });
                });

            modelBuilder.Entity("TMS.Api.Entities.Event", b =>
                {
                    b.HasOne("TMS.Api.Entities.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS.Api.Entities.Venue", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventType");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("TMS.Api.Entities.Order", b =>
                {
                    b.HasOne("TMS.Api.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS.Api.Entities.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS.Api.Entities.TicketCategory", "TicketCategory")
                        .WithMany()
                        .HasForeignKey("TicketCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Event");

                    b.Navigation("TicketCategory");
                });

            modelBuilder.Entity("TMS.Api.Entities.TicketCategory", b =>
                {
                    b.HasOne("TMS.Api.Entities.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });
#pragma warning restore 612, 618
        }
    }
}
