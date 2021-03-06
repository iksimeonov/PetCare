﻿using AnimalsCare.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnimalsCare.Data
{
  public  class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,string>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Veterinarian> Veterinarians { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Comment> Comment { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Consultation> Consultations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-HBTCL7L\SQLEXPRESS01;Database=AnimalsCare;Integrated Security=true;");
            }
        }

    }
}
