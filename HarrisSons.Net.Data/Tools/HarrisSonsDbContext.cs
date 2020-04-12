using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarrisSons.Net.Data.Tools
{
    public class HarrisSonsDbContext : DbContext
    {
        private DbContextOptions<HarrisSonsDbContext> _options = null;

        public HarrisSonsDbContext()
        {

        }

        public HarrisSonsDbContext(DbContextOptions<HarrisSonsDbContext> options) : base(options)
        {
            _options = options;
        }

        public DbSet<PayRate> PayRates { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PersonalContact> PersonalContacts { get; set; }
        public  DbSet<BusinessContact> BusinessContacts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<vwPersonalContact> vwPersonalContacts { get; set; }
        public DbSet<vwPersonalContactDetail> vwPersonalContactDetails { get; set; }
        public DbSet<vwBusinessContact> vwBusinessContacts { get; set; }
        public DbSet<vwBusinessContactDetail> vwBusinessContactDetails { get; set; }
        public DbSet<vwPosition> vwPositions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_options == null)
            {
                optionsBuilder.UseMySql("server=harrissonsdb.cewsoho8wmni.us-east-1.rds.amazonaws.com;database=HarrisSonsDB;uid=admin;pwd=HarrisSons2020", x => x.ServerVersion("8.0.16-mysql"));
            }
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
        }
    }
}
