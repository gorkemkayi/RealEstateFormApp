using Microsoft.EntityFrameworkCore;
using RealEstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infrastructure.Context
{
    public class RealEstateDbContext : DbContext
    {
        public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options) : base(options)
        {

        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<SessionUser> SessionUsers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<EstateImage> EstateImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Estate>()
                .HasOne(e => e.Customer)
                 .WithMany(c => c.Estates)
       .HasForeignKey(e => e.CustomerId)
       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Estate>()
                .HasOne(e => e.AppUser)
                .WithMany(x=>x.Estates)
                .HasForeignKey(e => e.AppUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.AppUser)
                .WithMany(x=>x.Customers)
                .HasForeignKey(c => c.AppUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EstateImage>()
                .HasOne(i => i.Estate)
                .WithMany(e => e.EstateImages)
                .HasForeignKey(i => i.EstateId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
