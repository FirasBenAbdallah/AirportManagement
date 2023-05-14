﻿// <auto-generated />
using System;
using AM.INfrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AM.INfrastructure.Migrations
{
    [DbContext(typeof(AMContext))]
    [Migration("20221108131240_mardi")]
    partial class mardi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightId"), 1L, 1);

                    b.Property<string>("Airline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EffectiveArrival")
                        .HasColumnType("date");

                    b.Property<int>("EstimateDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("date");

                    b.Property<int>("PlaneFk")
                        .HasColumnType("int");

                    b.HasKey("FlightId");

                    b.HasIndex("PlaneFk");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Passenger", b =>
                {
                    b.Property<string>("PssportNumber")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("TelNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PssportNumber");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Plane", b =>
                {
                    b.Property<int>("PlaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaneId"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("Planecapacity");

                    b.Property<DateTime>("ManifactureDate")
                        .HasColumnType("date");

                    b.Property<int>("Planetype")
                        .HasColumnType("int");

                    b.HasKey("PlaneId");

                    b.ToTable("MyPlane", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Ticket", b =>
                {
                    b.Property<string>("PassengerFK")
                        .HasColumnType("nvarchar(7)");

                    b.Property<int>("FlightFK")
                        .HasColumnType("int");

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.Property<int>("Siege")
                        .HasColumnType("int");

                    b.Property<bool>("VIP")
                        .HasColumnType("bit");

                    b.HasKey("PassengerFK", "FlightFK");

                    b.HasIndex("FlightFK");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Staff", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.Domain.Passenger");

                    b.Property<DateTime?>("EmploymentDate")
                        .HasColumnType("date");

                    b.Property<string>("Function")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.ToTable("Staff", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Traveller", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.Domain.Passenger");

                    b.Property<string>("HealthInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Travellers", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flight", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Plane", "MyPlane")
                        .WithMany("FlightsList")
                        .HasForeignKey("PlaneFk")
                        .IsRequired();

                    b.Navigation("MyPlane");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Passenger", b =>
                {
                    b.OwnsOne("AM.ApplicationCore.Domain.FullName", "FullName", b1 =>
                        {
                            b1.Property<string>("PassengerPssportNumber")
                                .HasColumnType("nvarchar(7)");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("nvarchar(30)")
                                .HasColumnName("PassFirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("PassLastName");

                            b1.HasKey("PassengerPssportNumber");

                            b1.ToTable("Passengers");

                            b1.WithOwner()
                                .HasForeignKey("PassengerPssportNumber");
                        });

                    b.Navigation("FullName")
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Ticket", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Flight", "Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AM.ApplicationCore.Domain.Passenger", "Passenger")
                        .WithMany("Tickets")
                        .HasForeignKey("PassengerFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Staff", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Passenger", null)
                        .WithOne()
                        .HasForeignKey("AM.ApplicationCore.Domain.Staff", "PssportNumber")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Traveller", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Passenger", null)
                        .WithOne()
                        .HasForeignKey("AM.ApplicationCore.Domain.Traveller", "PssportNumber")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flight", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Passenger", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Plane", b =>
                {
                    b.Navigation("FlightsList");
                });
#pragma warning restore 612, 618
        }
    }
}