using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplication1.IServices;

namespace WebApplication1.Entity
{
    public partial class Trading_operationsContext : DbContext, ITrading_operationsContext
    {
        public Trading_operationsContext()
        {
        }

        public Trading_operationsContext(DbContextOptions<Trading_operationsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Checks> Checks { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-1KJUBR1\\SQLEXPRESS;Database=Trading_operations;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Checks>(entity =>
            {
                entity.HasKey(e => e.IdChecks);

                entity.Property(e => e.IdChecks).HasColumnName("id_Checks");

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<Goods>(entity =>
            {
                entity.HasKey(e => e.IdGoods);

                entity.Property(e => e.IdGoods).HasColumnName("id_Goods");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Goods1)
                    .IsRequired()
                    .HasColumnName("Goods");

                entity.Property(e => e.Unit).IsRequired();
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.HasKey(e => e.IdOrganization);

                entity.Property(e => e.IdOrganization).HasColumnName("id_Organization");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Director).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("Phone_number");
            });
        }
    }
}
