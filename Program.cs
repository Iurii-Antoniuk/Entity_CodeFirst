using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ORM_Saving_Forms
{
    static class Program
    {
        public static void Main()
        {
            DateTime date1 = new DateTime(2015, 10, 1);
            DateTime date2 = new DateTime(2016, 2, 1);
            double totalInterest = SavingCalculator.CalculateTotalSaved(date2, date1);
            MessageBox.Show(totalInterest.ToString(), "Total interests generated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            //using (var context  = new SavingContext())
            //{
            //    context.Database.EnsureDeleted();
            //    context.Database.EnsureCreated();

            //    var person = new Person
            //    {
            //        Name = "Richard"
            //    };

            //    person.Accounts = new List<SavingAccount>
            //    {
            //        new SavingAccount {Rate = 0.05, StartAmount = 2000000},
            //        new SavingAccount {Rate = 0.15, StartAmount = 250000},
            //        new SavingAccount {Rate = 0.02, StartAmount = 10000000},
            //    };

            //    context.Add(person);
            //    context.SaveChanges();
            //}
        }
    }
}
