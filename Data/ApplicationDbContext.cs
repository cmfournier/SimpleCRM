
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleCRM.Models;

namespace SimpleCRM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}