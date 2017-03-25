// ======================================
// Author: Ebenezer Monney
// Email:  info@ebenmonney.com
// Copyright (c) 2017 www.ebenmonney.com
// ======================================

using DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OpenIddict;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Appointement> Appointements { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Laborantin> laborantins { get; set; }



        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
//patient
            builder.Entity<Patient>().Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Entity<Patient>().HasIndex(c => c.Name);
            builder.Entity<Patient>().Property(c => c.Email).HasMaxLength(100);
            builder.Entity<Patient>().Property(c => c.PhoneNumber).IsUnicode(false).HasMaxLength(30);
            builder.Entity<Patient>().Property(c => c.City).HasMaxLength(50);
            builder.Entity<Patient>().ToTable($"App{nameof(this.Patients)}");
            //provider
            builder.Entity<Provider>().Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Entity<Provider>().HasIndex(c => c.Name);
            builder.Entity<Provider>().Property(c => c.Email).HasMaxLength(100);
            builder.Entity<Provider>().Property(c => c.PhoneNumber).IsUnicode(false).HasMaxLength(30);
            builder.Entity<Provider>().Property(c => c.City).HasMaxLength(50);
            builder.Entity<Provider>().ToTable($"App{nameof(this.Providers)}");
            //Appointements

            builder.Entity<Appointement>().ToTable($"App{nameof(this.Appointements)}");
            //Consultation

            builder.Entity<Consultation>().ToTable($"App{nameof(this.Consultations)}");
            //Lborantin
            builder.Entity<Laborantin>().Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Entity<Laborantin>().HasIndex(c => c.Name);
            builder.Entity<Laborantin>().Property(c => c.Email).HasMaxLength(100);
            builder.Entity<Laborantin>().Property(c => c.PhoneNumber).IsUnicode(false).HasMaxLength(30);
            builder.Entity<Laborantin>().Property(c => c.City).HasMaxLength(50);
            builder.Entity<Laborantin>().ToTable($"App{nameof(this.laborantins)}");
        }
    }
}
