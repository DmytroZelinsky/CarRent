﻿// <auto-generated />
using System;
using CarRent.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRent.Migrations
{
    [DbContext(typeof(CarRentDBContext))]
    [Migration("20211128192953_RemoveClientBookingBind")]
    partial class RemoveClientBookingBind
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarRent.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("addressId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("addressName")
                        .IsFixedLength();

                    b.Property<int>("AddressNumber")
                        .HasColumnType("int")
                        .HasColumnName("addressNumber");

                    b.Property<string>("City")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("city")
                        .HasDefaultValueSql("('Kek')")
                        .IsFixedLength();

                    b.Property<int>("PostCode")
                        .HasColumnType("int")
                        .HasColumnName("postCode");

                    b.HasKey("AddressId");

                    b.ToTable("address", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.AutoPark", b =>
                {
                    b.Property<int>("AutoParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("autoParkId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AutoParkId"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("addressId");

                    b.Property<int>("CurrentCarCount")
                        .HasColumnType("int")
                        .HasColumnName("currentCarCount");

                    b.Property<int>("MaxCarCount")
                        .HasColumnType("int")
                        .HasColumnName("maxCarCount");

                    b.HasKey("AutoParkId");

                    b.HasIndex("AddressId");

                    b.ToTable("autoPark", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("bookingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<DateTime?>("ActualEndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("actualEndDate");

                    b.Property<int?>("ActualReturnAddressId")
                        .HasColumnType("int")
                        .HasColumnName("actualReturnAddressId");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("endDate");

                    b.Property<int>("ReceivingAddressId")
                        .HasColumnType("int")
                        .HasColumnName("receivingAddressId");

                    b.Property<int>("ReturnAddressId")
                        .HasColumnType("int")
                        .HasColumnName("returnAddressId");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("startDate");

                    b.HasKey("BookingId");

                    b.HasIndex("ActualReturnAddressId");

                    b.HasIndex("ReceivingAddressId");

                    b.HasIndex("ReturnAddressId");

                    b.ToTable("booking", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("carId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"), 1L, 1);

                    b.Property<int?>("AutoParkId")
                        .HasColumnType("int")
                        .HasColumnName("autoParkId");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("brand")
                        .IsFixedLength();

                    b.Property<int?>("CarServiceId")
                        .HasColumnType("int")
                        .HasColumnName("carServiceId");

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<string>("DriveType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("driveType")
                        .IsFixedLength();

                    b.Property<double>("EngineVolume")
                        .HasColumnType("float")
                        .HasColumnName("engineVolume");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("fuelType")
                        .IsFixedLength();

                    b.Property<string>("Geerbox")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("geerbox")
                        .IsFixedLength();

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("type")
                        .IsFixedLength();

                    b.Property<string>("Vin")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("vin")
                        .IsFixedLength();

                    b.HasKey("CarId");

                    b.HasIndex("AutoParkId");

                    b.HasIndex("CarServiceId");

                    b.HasIndex(new[] { "Brand" }, "NCLIX_brand");

                    b.ToTable("car", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.CarClient", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("carId");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasColumnName("clientId");

                    b.HasIndex("CarId");

                    b.HasIndex("ClientId");

                    b.ToTable("car_client", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.CarInsurance", b =>
                {
                    b.Property<int>("CarInsuranceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("carInsuranceId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarInsuranceId"), 1L, 1);

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("effectiveDate");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("expirationDate");

                    b.Property<int>("InsuranceCompanyAddressId")
                        .HasColumnType("int")
                        .HasColumnName("insuranceCompanyAddressId");

                    b.Property<string>("InsuranceCompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .HasColumnName("insuranceCompanyName")
                        .IsFixedLength();

                    b.Property<string>("PolicyNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nchar(15)")
                        .HasColumnName("policyNumber")
                        .IsFixedLength();

                    b.HasKey("CarInsuranceId");

                    b.ToTable("carInsurance", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.CarService", b =>
                {
                    b.Property<int>("CarServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("carServiceId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarServiceId"), 1L, 1);

                    b.Property<int>("CarInsuranceId")
                        .HasColumnType("int")
                        .HasColumnName("carInsuranceId");

                    b.Property<int>("Deposit")
                        .HasColumnType("int")
                        .HasColumnName("deposit");

                    b.Property<int>("DistanceLimit")
                        .HasColumnType("int")
                        .HasColumnName("distanceLimit");

                    b.Property<bool>("IsOccupied")
                        .HasColumnType("bit")
                        .HasColumnName("isOccupied");

                    b.Property<int>("PricePerDay")
                        .HasColumnType("int")
                        .HasColumnName("pricePerDay");

                    b.HasKey("CarServiceId");

                    b.HasIndex("CarInsuranceId");

                    b.ToTable("carService", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("clientId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("addressId");

                    b.Property<int>("ClientServiceId")
                        .HasColumnType("int")
                        .HasColumnName("clientServiceId");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("dateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("firstName")
                        .IsFixedLength();

                    b.Property<string>("IdentificationCode")
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("identificationCode")
                        .IsFixedLength();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("lastName")
                        .IsFixedLength();

                    b.Property<string>("LicenseCode")
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("licenseCode")
                        .IsFixedLength();

                    b.Property<string>("PassportCode")
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("passportCode")
                        .IsFixedLength();

                    b.Property<int>("PaymentId")
                        .HasColumnType("int")
                        .HasColumnName("paymentId");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("phoneNumber")
                        .IsFixedLength();

                    b.HasKey("ClientId");

                    b.HasIndex("AddressId");

                    b.HasIndex("ClientServiceId");

                    b.HasIndex("PaymentId");

                    b.HasIndex(new[] { "FirstName" }, "NCLIX_firstName");

                    b.ToTable("client", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.ClientService", b =>
                {
                    b.Property<int>("ClientServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("clientServiceId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientServiceId"), 1L, 1);

                    b.Property<bool>("HasChildSeat")
                        .HasColumnType("bit")
                        .HasColumnName("hasChildSeat");

                    b.Property<bool>("HasDriver")
                        .HasColumnType("bit")
                        .HasColumnName("hasDriver");

                    b.Property<bool>("HasWiFi")
                        .HasColumnType("bit")
                        .HasColumnName("hasWiFi");

                    b.Property<bool>("OneWay")
                        .HasColumnType("bit")
                        .HasColumnName("oneWay");

                    b.HasKey("ClientServiceId");

                    b.ToTable("clientService", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("invoiceId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"), 1L, 1);

                    b.Property<int>("ClientServiceId")
                        .HasColumnType("int")
                        .HasColumnName("clientServiceId");

                    b.Property<int>("InvioceStatus")
                        .HasColumnType("int")
                        .HasColumnName("invioceStatus");

                    b.Property<int>("InvoiceAmount")
                        .HasColumnType("int")
                        .HasColumnName("invoiceAmount");

                    b.HasKey("InvoiceId");

                    b.HasIndex("ClientServiceId");

                    b.ToTable("invoice", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ownerId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OwnerId"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("carId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("firstName")
                        .IsFixedLength();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("lastName")
                        .IsFixedLength();

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("phoneNumber")
                        .IsFixedLength();

                    b.HasKey("OwnerId");

                    b.HasIndex("CarId");

                    b.ToTable("owner", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("paymentId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"), 1L, 1);

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int")
                        .HasColumnName("invoiceId");

                    b.Property<int>("PaymentAmount")
                        .HasColumnType("int")
                        .HasColumnName("paymentAmount");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime")
                        .HasColumnName("paymentDate");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("paymentMethod")
                        .IsFixedLength();

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int")
                        .HasColumnName("paymentStatus");

                    b.HasKey("PaymentId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("payment", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.RoadAccident", b =>
                {
                    b.Property<int>("RoadAccidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("roadAccidentId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoadAccidentId"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("carId");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasColumnName("clientId");

                    b.Property<string>("ProtocolNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .HasColumnName("protocolNumber")
                        .IsFixedLength();

                    b.HasKey("RoadAccidentId");

                    b.HasIndex("CarId");

                    b.HasIndex("ClientId");

                    b.ToTable("roadAccident", (string)null);
                });

            modelBuilder.Entity("CarRent.Models.AutoPark", b =>
                {
                    b.HasOne("CarRent.Models.Address", "Address")
                        .WithMany("AutoParks")
                        .HasForeignKey("AddressId")
                        .IsRequired()
                        .HasConstraintName("FK_autoPark_address");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("CarRent.Models.Booking", b =>
                {
                    b.HasOne("CarRent.Models.Address", "ActualReturnAddress")
                        .WithMany()
                        .HasForeignKey("ActualReturnAddressId");

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

                    b.Navigation("ReceivingAddress");

                    b.Navigation("ReturnAddress");
                });

            modelBuilder.Entity("CarRent.Models.Car", b =>
                {
                    b.HasOne("CarRent.Models.AutoPark", "AutoPark")
                        .WithMany("Cars")
                        .HasForeignKey("AutoParkId")
                        .HasConstraintName("FK_car_autoPark");

                    b.HasOne("CarRent.Models.CarService", "CarService")
                        .WithMany("Cars")
                        .HasForeignKey("CarServiceId")
                        .HasConstraintName("FK_car_carService");

                    b.Navigation("AutoPark");

                    b.Navigation("CarService");
                });

            modelBuilder.Entity("CarRent.Models.CarClient", b =>
                {
                    b.HasOne("CarRent.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .IsRequired()
                        .HasConstraintName("FK_car_owner_car");

                    b.HasOne("CarRent.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .IsRequired()
                        .HasConstraintName("FK_car_client_client");

                    b.Navigation("Car");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("CarRent.Models.CarService", b =>
                {
                    b.HasOne("CarRent.Models.CarInsurance", "CarInsurance")
                        .WithMany("CarServices")
                        .HasForeignKey("CarInsuranceId")
                        .IsRequired()
                        .HasConstraintName("FK_carService_carInsurance");

                    b.Navigation("CarInsurance");
                });

            modelBuilder.Entity("CarRent.Models.Client", b =>
                {
                    b.HasOne("CarRent.Models.Address", "Address")
                        .WithMany("Clients")
                        .HasForeignKey("AddressId")
                        .IsRequired()
                        .HasConstraintName("FK_client_address");

                    b.HasOne("CarRent.Models.ClientService", "ClientService")
                        .WithMany("Clients")
                        .HasForeignKey("ClientServiceId")
                        .IsRequired()
                        .HasConstraintName("FK_client_service");

                    b.HasOne("CarRent.Models.Payment", "Payment")
                        .WithMany("Clients")
                        .HasForeignKey("PaymentId")
                        .IsRequired()
                        .HasConstraintName("FK_client_payment");

                    b.Navigation("Address");

                    b.Navigation("ClientService");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("CarRent.Models.Invoice", b =>
                {
                    b.HasOne("CarRent.Models.ClientService", "ClientService")
                        .WithMany("Invoices")
                        .HasForeignKey("ClientServiceId")
                        .IsRequired()
                        .HasConstraintName("FK_invoice_service");

                    b.Navigation("ClientService");
                });

            modelBuilder.Entity("CarRent.Models.Owner", b =>
                {
                    b.HasOne("CarRent.Models.Car", "Car")
                        .WithMany("Owners")
                        .HasForeignKey("CarId")
                        .IsRequired()
                        .HasConstraintName("FK_owner_car");

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarRent.Models.Payment", b =>
                {
                    b.HasOne("CarRent.Models.Invoice", "Invoice")
                        .WithMany("Payments")
                        .HasForeignKey("InvoiceId")
                        .IsRequired()
                        .HasConstraintName("FK_payment_invoice");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("CarRent.Models.RoadAccident", b =>
                {
                    b.HasOne("CarRent.Models.Car", "Car")
                        .WithMany("RoadAccidents")
                        .HasForeignKey("CarId")
                        .IsRequired()
                        .HasConstraintName("FK_roadAccident_car");

                    b.HasOne("CarRent.Models.Client", "Client")
                        .WithMany("RoadAccidents")
                        .HasForeignKey("ClientId")
                        .IsRequired()
                        .HasConstraintName("FK_roadAccident_client");

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
                    b.Navigation("Owners");

                    b.Navigation("RoadAccidents");
                });

            modelBuilder.Entity("CarRent.Models.CarInsurance", b =>
                {
                    b.Navigation("CarServices");
                });

            modelBuilder.Entity("CarRent.Models.CarService", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarRent.Models.Client", b =>
                {
                    b.Navigation("RoadAccidents");
                });

            modelBuilder.Entity("CarRent.Models.ClientService", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("CarRent.Models.Invoice", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("CarRent.Models.Payment", b =>
                {
                    b.Navigation("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}
