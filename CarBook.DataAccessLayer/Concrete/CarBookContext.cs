using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.DataAccessLayer.Concrete
{
    public class CarBookContext:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YUSUF;initial catalog=DBCarBook;integrated Security=true");
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<CarStatus> CarStatuses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<HowItWorksStep> HowItWorksSteps { get; set; }
        public DbSet<CarDetail> CarDetails { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<CarRant> CarRants { get; set; }
    }
}
