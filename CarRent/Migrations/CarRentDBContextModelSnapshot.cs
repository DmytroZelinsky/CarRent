﻿// <auto-generated />
using System;
using CarRent.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRent.Migrations
{
    [DbContext(typeof(CarRentDBContext))]
    partial class CarRentDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookingClientOption", b =>
                {
                    b.Property<int>("BookingsBookingId")
                        .HasColumnType("int");

                    b.Property<int>("ClientOptionsClientOptionId")
                        .HasColumnType("int");

                    b.HasKey("BookingsBookingId", "ClientOptionsClientOptionId");

                    b.HasIndex("ClientOptionsClientOptionId");

                    b.ToTable("BookingClientOption");
                });

            modelBuilder.Entity("CarClient", b =>
                {
                    b.Property<int>("CarsCarId")
                        .HasColumnType("int");

                    b.Property<int>("ClientsClientId")
                        .HasColumnType("int");

                    b.HasKey("CarsCarId", "ClientsClientId");

                    b.HasIndex("ClientsClientId");

                    b.ToTable("CarClient");
                });

            modelBuilder.Entity("CarRent.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AddressId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AddressName");

                    b.Property<int>("AddressNumber")
                        .HasColumnType("int")
                        .HasColumnName("AddressNumber");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("City");

                    b.Property<int>("PostCode")
                        .HasColumnType("int")
                        .HasColumnName("PostCode");

                    b.HasKey("AddressId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.AutoPark", b =>
                {
                    b.Property<int>("AutoParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AutoParkId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AutoParkId"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("AddressId");

                    b.Property<int>("CurrentCarCount")
                        .HasColumnType("int")
                        .HasColumnName("CurrentCarCount");

                    b.Property<int>("MaxCarCount")
                        .HasColumnType("int")
                        .HasColumnName("MaxCarCount");

                    b.HasKey("AutoParkId");

                    b.HasIndex("AddressId");

                    b.ToTable("AutoPark", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.Billing", b =>
                {
                    b.Property<int>("BillingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BillingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillingId"), 1L, 1);

                    b.Property<string>("Method")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Method");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("PaymentDate");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Status");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int")
                        .HasColumnName("TotalAmount");

                    b.HasKey("BillingId");

                    b.ToTable("Billing", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BookingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<DateTime?>("ActualEndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ActualEndDate");

                    b.Property<int?>("ActualReturnAddressId")
                        .HasColumnType("int")
                        .HasColumnName("ActualReturnAddressId");

                    b.Property<int>("BillingId")
                        .HasColumnType("int")
                        .HasColumnName("BillingId");

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("CarId");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasColumnName("ClientId");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EndDate");

                    b.Property<int>("ReceivingAddressId")
                        .HasColumnType("int")
                        .HasColumnName("ReceivingAddressId");

                    b.Property<int>("ReturnAddressId")
                        .HasColumnType("int")
                        .HasColumnName("ReturnAddressId");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartDate");

                    b.HasKey("BookingId");

                    b.HasIndex("ActualReturnAddressId");

                    b.HasIndex("BillingId");

                    b.HasIndex("CarId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ReceivingAddressId");

                    b.HasIndex("ReturnAddressId");

                    b.ToTable("Booking", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CarId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"), 1L, 1);

                    b.Property<int>("AutoParkId")
                        .HasColumnType("int")
                        .HasColumnName("AutoParkId");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Brand");

                    b.Property<int>("CarRentInfoId")
                        .HasColumnType("int")
                        .HasColumnName("CarRentInfoId");

                    b.Property<int>("Class")
                        .HasColumnType("int")
                        .HasColumnName("Class");

                    b.Property<int>("DriveType")
                        .HasColumnType("int")
                        .HasColumnName("DriveType");

                    b.Property<double>("EngineVolume")
                        .HasColumnType("float")
                        .HasColumnName("EngineVolume");

                    b.Property<int>("FuelType")
                        .HasColumnType("int")
                        .HasColumnName("FuelType");

                    b.Property<int>("Geerbox")
                        .HasColumnType("int")
                        .HasColumnName("Geerbox");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Model");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int")
                        .HasColumnName("OwnerId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Type");

                    b.Property<string>("Vin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Vin");

                    b.HasKey("CarId");

                    b.HasIndex("AutoParkId");

                    b.HasIndex("CarRentInfoId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Car", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.CarInsurance", b =>
                {
                    b.Property<int>("CarInsuranceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CarInsuranceId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarInsuranceId"), 1L, 1);

                    b.Property<int>("CarRentInfoId")
                        .HasColumnType("int")
                        .HasColumnName("CarRentInfoId");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EffectiveDate");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ExpirationDate");

                    b.Property<string>("InsuranceCompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("InsuranceCompanyName");

                    b.Property<string>("PolicyNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PolicyNumber");

                    b.HasKey("CarInsuranceId");

                    b.HasIndex("CarRentInfoId");

                    b.ToTable("CarInsurance", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.CarRentInfo", b =>
                {
                    b.Property<int>("CarRentInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CarRentInfoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarRentInfoId"), 1L, 1);

                    b.Property<int>("Deposit")
                        .HasColumnType("int")
                        .HasColumnName("Deposit");

                    b.Property<int>("DistanceLimit")
                        .HasColumnType("int")
                        .HasColumnName("DistanceLimit");

                    b.Property<bool>("IsOccupied")
                        .HasColumnType("bit")
                        .HasColumnName("IsOccupied");

                    b.Property<int>("PricePerDay")
                        .HasColumnType("int")
                        .HasColumnName("PricePerDay");

                    b.HasKey("CarRentInfoId");

                    b.ToTable("CarRentInfo", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClientId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("AddressId");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("IdentificationCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IdentificationCode");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("LicenseCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LicenseCode");

                    b.Property<string>("PassportCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PassportCode");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("ClientId");

                    b.HasIndex("AddressId");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.ClientOption", b =>
                {
                    b.Property<int>("ClientOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClientOptionId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientOptionId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("Price");

                    b.HasKey("ClientOptionId");

                    b.ToTable("ClientOption", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OwnerId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OwnerId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("OwnerId");

                    b.ToTable("Owner", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.RoadAccident", b =>
                {
                    b.Property<int>("RoadAccidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RoadAccidentId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoadAccidentId"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("CarId");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasColumnName("ClientId");

                    b.Property<string>("ProtocolNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProtocolNumber");

                    b.HasKey("RoadAccidentId");

                    b.HasIndex("CarId");

                    b.HasIndex("ClientId");

                    b.ToTable("RoadAccident", (string)null);
                });

            modelBuilder.Entity("BookingClientOption", b =>
                {
                    b.HasOne("CarRent.Models.Booking", null)
                        .WithMany()
                        .HasForeignKey("BookingsBookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRent.Models.ClientOption", null)
                        .WithMany()
                        .HasForeignKey("ClientOptionsClientOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarClient", b =>
                {
                    b.HasOne("CarRent.Models.Car", null)
                        .WithMany()
                        .HasForeignKey("CarsCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRent.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarRent.Models.AutoPark", b =>
                {
                    b.HasOne("CarRent.Models.Address", "Address")
                        .WithMany("AutoParks")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("CarRent.Models.Booking", b =>
                {
                    b.HasOne("CarRent.Models.Address", "ActualReturnAddress")
                        .WithMany()
                        .HasForeignKey("ActualReturnAddressId");

                    b.HasOne("CarRent.Models.Billing", "Billing")
                        .WithMany()
                        .HasForeignKey("BillingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRent.Models.Car", "Car")
                        .WithMany("Bookings")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRent.Models.Client", "Client")
                        .WithMany("Bookings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRent.Models.Address", "ReceivingAddress")
                        .WithMany()
                        .HasForeignKey("ReceivingAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRent.Models.Address", "ReturnAddress")
                        .WithMany()
                        .HasForeignKey("ReturnAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActualReturnAddress");

                    b.Navigation("Billing");

                    b.Navigation("Car");

                    b.Navigation("Client");

                    b.Navigation("ReceivingAddress");

                    b.Navigation("ReturnAddress");
                });

            modelBuilder.Entity("CarRent.Models.Car", b =>
                {
                    b.HasOne("CarRent.Models.AutoPark", "AutoPark")
                        .WithMany("Cars")
                        .HasForeignKey("AutoParkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRent.Models.CarRentInfo", "CarRentInfo")
                        .WithMany()
                        .HasForeignKey("CarRentInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRent.Models.Owner", "Owner")
                        .WithMany("Cars")
                        .HasForeignKey("OwnerId");

                    b.Navigation("AutoPark");

                    b.Navigation("CarRentInfo");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("CarRent.Models.CarInsurance", b =>
                {
                    b.HasOne("CarRent.Models.CarRentInfo", "CarRentInfo")
                        .WithMany()
                        .HasForeignKey("CarRentInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarRentInfo");
                });

            modelBuilder.Entity("CarRent.Models.Client", b =>
                {
                    b.HasOne("CarRent.Models.Address", "Address")
                        .WithMany("Clients")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("CarRent.Models.RoadAccident", b =>
                {
                    b.HasOne("CarRent.Models.Car", "Car")
                        .WithMany("RoadAccidents")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRent.Models.Client", "Client")
                        .WithMany("RoadAccidents")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("CarRent.Models.Address", b =>
                {
                    b.Navigation("AutoParks");

                    b.Navigation("Clients");
                });

            modelBuilder.Entity("CarRent.Models.AutoPark", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarRent.Models.Car", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("RoadAccidents");
                });

            modelBuilder.Entity("CarRent.Models.Client", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("RoadAccidents");
                });

            modelBuilder.Entity("CarRent.Models.Owner", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
