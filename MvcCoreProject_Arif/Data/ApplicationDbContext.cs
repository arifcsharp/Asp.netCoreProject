using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcCoreProject_Arif.Models;

namespace MvcCoreProject_Arif.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public virtual DbSet<AccountHolder> AccountHolders { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Branch> Branches  { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FDR> FDRs { get; set; }
    }
}
