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
        public virtual DbSet<CarInsurance> CarInsurances { get; set; }
        public virtual DbSet<CarRentInfo> CarRentInfos { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientOption> ClientOptions { get; set; }
        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<RoadAccident> RoadAccidents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.AddressId).HasColumnName("AddressId");

                entity.Property(e => e.AddressName)
                    .IsRequired()
                    .HasColumnName("AddressName");

                entity.Property(e => e.AddressNumber).HasColumnName("AddressNumber");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("City");

                entity.Property(e => e.PostCode).HasColumnName("PostCode");
            });

            modelBuilder.Entity<AutoPark>(entity =>
            {
                entity.ToTable("AutoPark");

                entity.Property(e => e.AutoParkId).HasColumnName("AutoParkId");

                entity.Property(e => e.AddressId).HasColumnName("AddressId");

                entity.Property(e => e.CurrentCarCount).HasColumnName("CurrentCarCount");

                entity.Property(e => e.MaxCarCount).HasColumnName("MaxCarCount");

            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("Booking");

                entity.Property(e => e.BookingId).HasColumnName("BookingId");

                entity.Property(e => e.ActualEndDate).HasColumnName("ActualEndDate");

                entity.Property(e => e.ActualReturnAddressId).HasColumnName("ActualReturnAddressId");

                entity.Property(e => e.EndDate).HasColumnName("EndDate");

                entity.Property(e => e.ReceivingAddressId).HasColumnName("ReceivingAddressId");

                entity.Property(e => e.ReturnAddressId).HasColumnName("ReturnAddressId");

                entity.Property(e => e.StartDate).HasColumnName("StartDate");

                entity.Property(e => e.ClientId).HasColumnName("ClientId");

                entity.Property(e => e.CarId).HasColumnName("CarId");

            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Car");

                entity.Property(e => e.CarId).HasColumnName("CarId");

                entity.Property(e => e.AutoParkId).HasColumnName("AutoParkId");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasColumnName("Brand");

                entity.Property(e => e.DriveType).HasColumnName("DriveType");

                entity.Property(e => e.EngineVolume).HasColumnName("EngineVolume");

                entity.Property(e => e.FuelType).HasColumnName("FuelType");

                entity.Property(e => e.Geerbox).HasColumnName("Geerbox");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("Type");

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("Vin");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("Model");

                entity.Property(e => e.Class).HasColumnName("Class");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerId");

            });

            modelBuilder.Entity<CarInsurance>(entity =>
            {
                entity.ToTable("CarInsurance");

                entity.Property(e => e.CarInsuranceId).HasColumnName("CarInsuranceId");

                entity.Property(e => e.EffectiveDate).HasColumnName("EffectiveDate");

                entity.Property(e => e.ExpirationDate).HasColumnName("ExpirationDate");

                entity.Property(e => e.InsuranceCompanyName)
                    .IsRequired()
                    .HasColumnName("InsuranceCompanyName");

                entity.Property(e => e.PolicyNumber)
                    .IsRequired()
                    .HasColumnName("PolicyNumber");

                entity.Property(e => e.CarRentInfoId).HasColumnName("CarRentInfoId");

            });

            modelBuilder.Entity<CarRentInfo>(entity =>
            {
                entity.ToTable("CarRentInfo");

                entity.Property(e => e.Deposit).HasColumnName("Deposit");

                entity.Property(e => e.DistanceLimit).HasColumnName("DistanceLimit");

                entity.Property(e => e.IsOccupied).HasColumnName("IsOccupied");

                entity.Property(e => e.PricePerDay).HasColumnName("PricePerDay");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.ClientId).HasColumnName("ClientId");

                entity.Property(e => e.AddressId).HasColumnName("AddressId");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("DateOfBirth");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FirstName");

                entity.Property(e => e.IdentificationCode)
                    .HasColumnName("IdentificationCode");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("LastName");

                entity.Property(e => e.LicenseCode)
                    .HasColumnName("LicenseCode");

                entity.Property(e => e.PassportCode)
                    .HasColumnName("PassportCode");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("PhoneNumber");
            });

            modelBuilder.Entity<ClientOption>(entity =>
            {
                entity.ToTable("ClientOption");

                entity.Property(e => e.ClientOptionId).HasColumnName("ClientOptionId");

                entity.Property(e => e.Name).HasColumnName("Name");

                entity.Property(e => e.Price).HasColumnName("Price");

                entity.Property(e => e.Description).HasColumnName("Description");
          
            });

            modelBuilder.Entity<Billing>(entity =>
            {
                entity.ToTable("Billing");


                entity.Property(e => e.Status).HasColumnName("Status");

                entity.Property(e => e.PaymentDate).HasColumnName("PaymentDate");

                entity.Property(e => e.Method).HasColumnName("Method");

                entity.Property(e => e.TotalAmount).HasColumnName("TotalAmount");
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.ToTable("Owner");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerId");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FirstName");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("LastName");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("PhoneNumber");
            });

            modelBuilder.Entity<RoadAccident>(entity =>
            {
                entity.ToTable("RoadAccident");

                entity.Property(e => e.RoadAccidentId).HasColumnName("RoadAccidentId");

                entity.Property(e => e.CarId).HasColumnName("CarId");

                entity.Property(e => e.ClientId).HasColumnName("ClientId");

                entity.Property(e => e.ProtocolNumber)
                    .IsRequired()
                    .HasColumnName("ProtocolNumber");
            });

            modelBuilder.Entity<Address>().HasData(new Address()
            {
                AddressId = 1,
                City = "City",
                AddressName = "Address Name",
                AddressNumber = 0,
                PostCode = 0
            });

            modelBuilder.Entity<AutoPark>().HasData(new AutoPark()
            {
                AutoParkId = 1,
                MaxCarCount = 10,
                CurrentCarCount = 0,
                AddressId = 1
            });

            modelBuilder.Entity<Car>().HasData(new Car()
            {
                CarId = 1,
                Type = "Type",
                EngineVolume = 1.0,
                Geerbox = Enums.Geerbox.Automatic,
                FuelType = Enums.FuelType.Petrol,
                DriveType = Enums.DriveType.FWD,
                Brand = "Brand",
                Vin = "1234567890",
                Model = "Model",
                Class = Enums.Class.Middle,
                AutoParkId = 1

            });

            modelBuilder.Entity<CarRentInfo>().HasData(new CarRentInfo()
            {
                CarId = 1,
                DistanceLimit = 100,
                IsOccupied = false,
                PricePerDay = 20,
                Deposit = 200
            });

            modelBuilder.Entity<ClientOption>().HasData(new List<ClientOption>()
            {
                new ClientOption()
                {
                    ClientOptionId = 1,
                    Name = "WI-FI",
                    Price = 20,
                    Description = "Some WIFI"
                },
                new ClientOption()
                {
                    ClientOptionId = 2,
                    Name = "Video recorder",
                    Price = 15,
                    Description = "Some recorder"
                },
                new ClientOption()
                {
                    ClientOptionId = 3,
                    Name = "Child seat",
                    Price = 15,
                    Description = "Some child seat"
                },
                new ClientOption()
                {
                    ClientOptionId = 4,
                    Name = "Unlimited mileage",
                    Price = 30,
                    Description = "Some mileage"
                },
                new ClientOption()
                {
                    ClientOptionId = 5,
                    Name = "Phone holder with power charge",
                    Price = 10,
                    Description = "Some phone holder"
                }
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
