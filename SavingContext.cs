using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ORM_Saving_Forms
{
    public class SavingContext : DbContext
    {
        public virtual DbSet<SavingAccount> SavAccounts { get; set; }
        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                 @"Data Source=DESKTOP-AUGLKCC\SQLEXPRESS;Initial Catalog=SavingShit;Integrated Security=True");
        }
    }
}
