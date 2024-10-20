﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Urgent_2k_Finance.Models;

namespace Urgent_2k_Finance.Data
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions option) :base(option) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           

            var user1 = new ApplicationUser
            {
                Id = "1",
                UserName = "ade1@gmail.com",
                Email = "ade1@example.com",
                FullName = "Ademola Adeola",
                
                DateOfBirth = new DateTime(1993, 2, 1),
                
                KYCStatus = "Verified"
            };

            var user2 = new ApplicationUser
            {
                Id = "2",
                UserName = "audu@gmail.com",
                Email = "audu@gmail.com",
                FullName = "Ibrahim Audu",
               
                DateOfBirth = new DateTime(1985, 5, 15),
            
                KYCStatus = "Pending"
            };
            modelBuilder.Entity<ApplicationUser>().HasData(user1, user2);

            modelBuilder.Entity<BankAccount>().HasData
           (
           new BankAccount { AccountId = 1, AccountNumber = "1234567890", Balance = 5000, AccountType = "Savings", ApplicationUserId = user1.Id },

           new BankAccount { AccountId = 2, AccountNumber = "1429083782", Balance = 2000, AccountType = "Savings", ApplicationUserId = user2.Id },

           new BankAccount { AccountId = 3, AccountNumber = "1228778914", Balance = 10000, AccountType = "Current", ApplicationUserId = user1.Id }

          );

      }
    }
}
