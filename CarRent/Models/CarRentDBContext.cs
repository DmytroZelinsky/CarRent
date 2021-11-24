using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CarRent.Models
{
    public partial class CarRentDBContext : DbContext
    {
        public CarRentDBContext()
        {
        }

        public CarRentDBContext(DbContextOptions<CarRentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AutoPark> AutoParks { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarClient> CarClients { get; set; }
        public virtual DbSet<CarInfoView> CarInfoViews { get; set; }
        public virtual DbSet<CarInsurance> CarInsurances { get; set; }
        public virtual DbSet<CarService> CarServices { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientService> ClientServices { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<RoadAccident> RoadAccidents { get; set; }
        public virtual DbSet<UserInfoView> UserInfoViews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TNBSHA4;Initial Catalog=CarRentDB;User ID=Dmytro;Password=salman;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.AddressId).HasColumnName("addressId");

                entity.Property(e => e.AddressName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("addressName")
                    .IsFixedLength();

                entity.Property(e => e.AddressNumber).HasColumnName("addressNumber");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("city")
                    .HasDefaultValueSql("('Kek')")
                    .IsFixedLength();

                entity.Property(e => e.PostCode).HasColumnName("postCode");
            });

            modelBuilder.Entity<AutoPark>(entity =>
            {
                entity.ToTable("autoPark");

                entity.Property(e => e.AutoParkId).HasColumnName("autoParkId");

                entity.Property(e => e.AddressId).HasColumnName("addressId");

                entity.Property(e => e.CurrentCarCount).HasColumnName("currentCarCount");

                entity.Property(e => e.MaxCarCount).HasColumnName("maxCarCount");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.AutoParks)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_autoPark_address");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("booking");

                entity.Property(e => e.BookingId).HasColumnName("bookingId");

                entity.Property(e => e.ActualEndDate).HasColumnName("actualEndDate");

                entity.Property(e => e.ActualReturnAddressId).HasColumnName("actualReturnAddressId");

                entity.Property(e => e.EndDate).HasColumnName("endDate");

                entity.Property(e => e.ReceivingAddressId).HasColumnName("receivingAddressId");

                entity.Property(e => e.ReturnAddressId).HasColumnName("returnAddressId");

                entity.Property(e => e.StartDate).HasColumnName("startDate");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("car");

                entity.HasIndex(e => e.Brand, "NCLIX_brand");

                entity.Property(e => e.CarId).HasColumnName("carId");

                entity.Property(e => e.AutoParkId).HasColumnName("autoParkId");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("brand")
                    .IsFixedLength();

                entity.Property(e => e.CarServiceId).HasColumnName("carServiceId");

                entity.Property(e => e.DriveType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("driveType")
                    .IsFixedLength();

                entity.Property(e => e.EngineVolume).HasColumnName("engineVolume");

                entity.Property(e => e.FuelType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fuelType")
                    .IsFixedLength();

                entity.Property(e => e.Geerbox)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("geerbox")
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("type")
                    .IsFixedLength();

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("vin")
                    .IsFixedLength();

                entity.HasOne(d => d.AutoPark)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.AutoParkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_car_autoPark");

                entity.HasOne(d => d.CarService)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CarServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_car_carService");
            });

            modelBuilder.Entity<CarClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("car_client");

                entity.Property(e => e.CarId).HasColumnName("carId");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.HasOne(d => d.Car)
                    .WithMany()
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_car_owner_car");

                entity.HasOne(d => d.Client)
                    .WithMany()
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_car_client_client");
            });

            modelBuilder.Entity<CarInfoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CarInfoView");

                entity.Property(e => e.AddressName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("addressName")
                    .IsFixedLength();

                entity.Property(e => e.AddressNumber).HasColumnName("addressNumber");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("brand")
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("city")
                    .IsFixedLength();

                entity.Property(e => e.Deposit).HasColumnName("deposit");

                entity.Property(e => e.DistanceLimit).HasColumnName("distanceLimit");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("firstName")
                    .IsFixedLength();

                entity.Property(e => e.IsOccupied).HasColumnName("isOccupied");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("lastName")
                    .IsFixedLength();

                entity.Property(e => e.PricePerDay).HasColumnName("pricePerDay");
            });

            modelBuilder.Entity<CarInsurance>(entity =>
            {
                entity.ToTable("carInsurance");

                entity.Property(e => e.CarInsuranceId).HasColumnName("carInsuranceId");

                entity.Property(e => e.EffectiveDate).HasColumnName("effectiveDate");

                entity.Property(e => e.ExpirationDate).HasColumnName("expirationDate");

                entity.Property(e => e.InsuranceCompanyAddressId).HasColumnName("insuranceCompanyAddressId");

                entity.Property(e => e.InsuranceCompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("insuranceCompanyName")
                    .IsFixedLength();

                entity.Property(e => e.PolicyNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("policyNumber")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CarService>(entity =>
            {
                entity.ToTable("carService");

                entity.Property(e => e.CarServiceId).HasColumnName("carServiceId");

                entity.Property(e => e.CarInsuranceId).HasColumnName("carInsuranceId");

                entity.Property(e => e.Deposit).HasColumnName("deposit");

                entity.Property(e => e.DistanceLimit).HasColumnName("distanceLimit");

                entity.Property(e => e.IsOccupied).HasColumnName("isOccupied");

                entity.Property(e => e.PricePerDay).HasColumnName("pricePerDay");

                entity.HasOne(d => d.CarInsurance)
                    .WithMany(p => p.CarServices)
                    .HasForeignKey(d => d.CarInsuranceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_carService_carInsurance");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.HasIndex(e => e.FirstName, "NCLIX_firstName");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.AddressId).HasColumnName("addressId");

                entity.Property(e => e.BookingId).HasColumnName("bookingId");

                entity.Property(e => e.ClientServiceId).HasColumnName("clientServiceId");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("dateOfBirth");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("firstName")
                    .IsFixedLength();

                entity.Property(e => e.IdentificationCode)
                    .HasMaxLength(30)
                    .HasColumnName("identificationCode")
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("lastName")
                    .IsFixedLength();

                entity.Property(e => e.LicenseCode)
                    .HasMaxLength(30)
                    .HasColumnName("licenseCode")
                    .IsFixedLength();

                entity.Property(e => e.PassportCode)
                    .HasMaxLength(30)
                    .HasColumnName("passportCode")
                    .IsFixedLength();

                entity.Property(e => e.PaymentId).HasColumnName("paymentId");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("phoneNumber")
                    .IsFixedLength();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_client_address");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_client_booking");

                entity.HasOne(d => d.ClientService)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ClientServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_client_service");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_client_payment");
            });

            modelBuilder.Entity<ClientService>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK_service");

                entity.ToTable("clientService");

                entity.Property(e => e.ServiceId).HasColumnName("serviceId");

                entity.Property(e => e.HasChildSeat).HasColumnName("hasChildSeat");

                entity.Property(e => e.HasDriver).HasColumnName("hasDriver");

                entity.Property(e => e.HasWiFi).HasColumnName("hasWiFi");

                entity.Property(e => e.OneWay).HasColumnName("oneWay");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoice");

                entity.Property(e => e.InvoiceId).HasColumnName("invoiceId");

                entity.Property(e => e.ClientServiceId).HasColumnName("clientServiceId");

                entity.Property(e => e.InvioceStatus).HasColumnName("invioceStatus");

                entity.Property(e => e.InvoiceAmount).HasColumnName("invoiceAmount");

                entity.HasOne(d => d.ClientService)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.ClientServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_invoice_service");
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.ToTable("owner");

                entity.Property(e => e.OwnerId).HasColumnName("ownerId");

                entity.Property(e => e.CarId).HasColumnName("carId");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("firstName")
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("lastName")
                    .IsFixedLength();

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("phoneNumber")
                    .IsFixedLength();

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Owners)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_owner_car");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("payment");

                entity.Property(e => e.PaymentId).HasColumnName("paymentId");

                entity.Property(e => e.InvoiceId).HasColumnName("invoiceId");

                entity.Property(e => e.PaymentAmount).HasColumnName("paymentAmount");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("paymentDate");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("paymentMethod")
                    .IsFixedLength();

                entity.Property(e => e.PaymentStatus).HasColumnName("paymentStatus");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_payment_invoice");
            });

            modelBuilder.Entity<RoadAccident>(entity =>
            {
                entity.ToTable("roadAccident");

                entity.Property(e => e.RoadAccidentId).HasColumnName("roadAccidentId");

                entity.Property(e => e.CarId).HasColumnName("carId");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.ProtocolNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("protocolNumber")
                    .IsFixedLength();

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.RoadAccidents)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_roadAccident_car");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.RoadAccidents)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_roadAccident_client");
            });

            modelBuilder.Entity<UserInfoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UserInfoView");

                entity.Property(e => e.CarBrand)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("car brand")
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("city")
                    .IsFixedLength();

                entity.Property(e => e.Deposit).HasColumnName("deposit");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("first name")
                    .IsFixedLength();

                entity.Property(e => e.HadAccidents)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("had accidents");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("last name")
                    .IsFixedLength();

                entity.Property(e => e.PaymentAmount).HasColumnName("payment amount");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("phone number")
                    .IsFixedLength();

                entity.Property(e => e.PricePerDay).HasColumnName("price per day");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
