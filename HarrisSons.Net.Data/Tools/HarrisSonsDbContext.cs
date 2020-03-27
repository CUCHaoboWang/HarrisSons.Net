using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarrisSons.Net.Data.Tools
{
    public class HarrisSonsDbContext : DbContext
    {

        public DbSet<PayRate> PayRates { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PersonalContact> PersonalContacts { get; set; }
        public  DbSet<BusinessContact> BusinessContacts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbQuery<vwPersonalContact> vwPersonalContacts { get; set; }
        public DbQuery<vwPersonalContactDetail> vwPersonalContactDetails { get; set; }
        public DbQuery<vwBusinessContact> vwBusinessContacts { get; set; }
        public DbQuery<vwBusinessContactDetail> vwBusinessContactDetails { get; set; }


        //public virtual DbSet<UserRoleClaim> AspNetRoleClaims { get; set; }
        //public virtual DbSet<UserRole> UserRoles { get; set; }
        //public virtual DbSet<UserClaim> UserClaims { get; set; }
        //public virtual DbSet<UserLogin> UserLogins { get; set; }
        //public virtual DbSet<User> Users { get; set; }
        //public virtual DbSet<UserToken> UserTokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=harrissonsdb.cewsoho8wmni.us-east-1.rds.amazonaws.com;database=HarrisSonsDB;uid=admin;pwd=HarrisSons2020", x => x.ServerVersion("8.0.16-mysql"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PayRate>().ToTable("tblPayRate");
            modelBuilder.Entity<Department>().ToTable("tblDepartment");
            modelBuilder.Entity<Position>().ToTable("tblPosition");
            modelBuilder.Entity<Address>().ToTable("tblAddress");
            modelBuilder.Entity<PersonalContact>().ToTable("tblPersonalContact");
            modelBuilder.Entity<BusinessContact>().ToTable("tblBusinessContact");
            modelBuilder.Entity<Client>().ToTable("tblClient");
            modelBuilder.Entity<Employee>().ToTable("tblEmployee");

            //modelBuilder.Entity<UserRole>()
            //    .HasMany(e => e.UserRoleClaims)
            //    .WithRequired(e => e.AspNetRole)
            //    .HasForeignKey(e => e.RoleId);

            //modelBuilder.Entity<UserRole>()
            //    .HasMany(e => e.Users)
            //    .WithMany(e => e.AspNetRoles)
            //    .Map(m => m.ToTable("UserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            //modelBuilder.Entity<User>()
            //    .HasMany(e => e.UserClaims)
            //    .WithRequired(e => e.AspNetUser)
            //    .HasForeignKey(e => e.UserId);

            //modelBuilder.Entity<User>()
            //    .HasMany(e => e.UserLogins)
            //    .WithRequired(e => e.AspNetUser)
            //    .HasForeignKey(e => e.UserId);

            //modelBuilder.Entity<User>()
            //    .HasMany(e => e.UserTokens)
            //    .WithRequired(e => e.AspNetUser)
            //    .HasForeignKey(e => e.UserId);
        }
    }
}
