using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication2.Models
{
    public partial class TestDBContext : DbContext
    {
        public TestDBContext()
        {
        }

        public TestDBContext(DbContextOptions<TestDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Tarif> Tarif { get; set; }
        public virtual DbSet<UsingService> UsingService { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.NumberPhone);

                entity.Property(e => e.NumberPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateBirthday).HasColumnType("date");

                entity.Property(e => e.DatePassport).HasColumnType("date");

                entity.Property(e => e.FirstName).HasMaxLength(30);

                entity.Property(e => e.LastName).HasMaxLength(30);

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.PassportNumber).HasMaxLength(6);

                entity.Property(e => e.PassportSerial).HasMaxLength(4);

                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.PatronymicName).HasMaxLength(30);

                entity.HasOne(d => d.IdTarifNavigation)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.IdTarif)
                    .HasConstraintName("FK_Client_Tarif");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.CodeService);

                entity.Property(e => e.CodeService)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectPrice).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SalaryService).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ServiceName).HasMaxLength(20);
            });

            modelBuilder.Entity<Tarif>(entity =>
            {
                entity.HasKey(e => e.IdTarif);

                entity.Property(e => e.CountSms).HasColumnName("CountSMS");

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TarifName).HasMaxLength(50);

                entity.Property(e => e.TariffImage).HasColumnType("image");
            });

            modelBuilder.Entity<UsingService>(entity =>
            {
                entity.Property(e => e.CodeService)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateConnection).HasColumnType("date");

                entity.Property(e => e.NumberPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeServiceNavigation)
                    .WithMany(p => p.UsingService)
                    .HasForeignKey(d => d.CodeService)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UsingService_Services");

                entity.HasOne(d => d.NumberPhoneNavigation)
                    .WithMany(p => p.UsingService)
                    .HasForeignKey(d => d.NumberPhone)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UsingService_UsingService");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
