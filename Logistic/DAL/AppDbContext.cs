using Logistic.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Logistic.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser> 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<Barcode> Barcodes { get; set; }
        public DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        public DbSet<StaticNumberAndQuantity> StaticNumberAndQuantities { get; set; }
        public DbSet<StatusOfShipment> StatusOfShipments { get; set; }
        public DbSet<DirectionOfTransportation> DirectionOfTransportations { get; set; }
        public DbSet<TypeOfTransportation> TypeOfTransportations { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<PersonnelType> PersonnelTypes { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<BankGroup> BankGroups { get; set; }
        public DbSet<CorrespondentBankGroup> CorrespondentBankGroups { get; set; }

        public DbSet<EnterpriseType> EnterpriseTypes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<ConditionOfCarriage> ConditionOfCarriages { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<UnofficialClient> UnofficialClients { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<CorrespondentBank> CorrespondentBanks { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<TypeOfActivity> TypeOfActivities { get; set; }
        public DbSet<Valyuta> Valyutas { get; set; }
        public DbSet<CustomerLegalPerson> CustomerLegalPeople { get; set; }
        public DbSet<CustomerLegalPersonTable> CustomerLegalPersonTables { get; set; }
        public DbSet<TransportDocument> TransportDocuments { get; set; }
        public DbSet<TransportDocumentTable> TransportDocumentTables { get; set; }
        public DbSet<ApportionmentOfCostTable> ApportionmentOfCostTables { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceTable> InvoiceTables { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            this.SeedUsers(builder);
            this.SeedRoles(builder);
            this.SeedUserRoles(builder);
        }

        private void SeedUsers(ModelBuilder builder)
        {
            var user = new AppUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Emil-Admin",
                Fullname = "Emil-Admin",
                Email = "admin@admin.az",
                LockoutEnabled = true,
                NormalizedUserName = "EMIL-ADMIN",
                NormalizedEmail = "ADMIN@ADMIN.AZ"
            };

            var Vugar = new AppUser()
            {
                Id = "1",
                UserName = "Vugar",
                Fullname = "Vugar",
                Email = "Vugar@logistic.az",
                LockoutEnabled = true,
                NormalizedUserName = "Vugar",
                NormalizedEmail = "Vugar@LOGISTIC.AZ"
            };
            var Hesen = new AppUser()
            {
                Id = "2",
                UserName = "Hesen",
                Fullname = "Hesen",
                Email = "Hesen2@logistic.az",
                LockoutEnabled = true,
                NormalizedUserName = "Hesen",
                NormalizedEmail = "Hesen@LOGISTIC.AZ"
            };


            var Aladdin = new AppUser()
            {
                Id = "3",
                UserName = "Aladdin",
                Fullname = "Aladdin",
                Email = "Aladdin@logistic.az",
                LockoutEnabled = true,
                NormalizedUserName = "Aladdin",
                NormalizedEmail = "Aladdin@LOGISTIC.AZ"
            };
            var Xezer = new AppUser()
            {
                Id = "4",
                UserName = "Xezer",
                Fullname = "Xezer",
                Email = "Xezer@logistic.az",
                LockoutEnabled = true,
                NormalizedUserName = "Xezer",
                NormalizedEmail = "Xezer@LOGISTIC.AZ"
            };
            var Veli = new AppUser()
            {
                Id = "5",
                UserName = "Veli",
                Fullname = "Veli",
                Email = "Veli@logistic.az",
                LockoutEnabled = true,
                NormalizedUserName = "Veli",
                NormalizedEmail = "Veli@LOGISTIC.AZ"
            };
            var Cavid = new AppUser()
            {
                Id = "6",
                UserName = "Cavid",
                Fullname = "Cavid",
                Email = "Cavid@logistic.az",
                LockoutEnabled = true,
                NormalizedUserName = "Cavid",
                NormalizedEmail = "Cavid@LOGISTIC.AZ"
            };
            var Cabbar = new AppUser()
            {
                Id = "7",
                UserName = "Cabbar",
                Fullname = "Cabbar",
                Email = "Cabbar@logistic.az",
                LockoutEnabled = true,
                NormalizedUserName = "Cabbar",
                NormalizedEmail = "Cabbar@LOGISTIC.AZ"
            };


            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, "Admin123!@#");
            Vugar.PasswordHash = passwordHasher.HashPassword(Vugar, "Vug@R2023@)@#");
            Hesen.PasswordHash = passwordHasher.HashPassword(Hesen, "H@s@n123!@#");
            Aladdin.PasswordHash = passwordHasher.HashPassword(Aladdin, "Al@DDin20@#");
            Xezer.PasswordHash = passwordHasher.HashPassword(Xezer, "X@Z@R111@@@###");
            Veli.PasswordHash = passwordHasher.HashPassword(Veli, "V@Li12!@");
            Cavid.PasswordHash = passwordHasher.HashPassword(Cavid, "C@ViD32@#");
            Cabbar.PasswordHash = passwordHasher.HashPassword(Cabbar, "C@BB@R#!%%!$");

            builder.Entity<AppUser>().HasData(user);
            builder.Entity<AppUser>().HasData(Vugar);
            builder.Entity<AppUser>().HasData(Hesen);
            builder.Entity<AppUser>().HasData(Aladdin);
            builder.Entity<AppUser>().HasData(Xezer);
            builder.Entity<AppUser>().HasData(Veli);
            builder.Entity<AppUser>().HasData(Cavid);
            builder.Entity<AppUser>().HasData(Cabbar);

        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Id = "1", Name = "Moderator", ConcurrencyStamp = "1", NormalizedName = "Moderator" }
                );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "1" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "2" },
                new IdentityUserRole<string>() { RoleId = "1", UserId = "3" },
                new IdentityUserRole<string>() { RoleId = "1", UserId = "4" },
                new IdentityUserRole<string>() { RoleId = "1", UserId = "5" },
                new IdentityUserRole<string>() { RoleId = "1", UserId = "6" },
                new IdentityUserRole<string>() { RoleId = "1", UserId = "7" }
                );
        }
    }
}

