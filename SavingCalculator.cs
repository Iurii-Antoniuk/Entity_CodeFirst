using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ORM_Saving_Forms
{
    public class SavingCalculator
    {
        public static double CalculateTotalSaved(DateTime begin, DateTime end)
        {
            using (var context = new SavingContext())
            {
                var Accounts = context.SavAccounts.ToList();
                double interestsGenerated = 0;
                int monthsPassed = Math.Abs((end.Month - begin.Month) + 12 * (end.Year - begin.Year));
                foreach (SavingAccount acc in Accounts)
                {
                    double interest = acc.StartAmount * Math.Pow(1 + acc.Rate, monthsPassed);
                    interestsGenerated += interest;
                }
                return interestsGenerated;
            }
        }
    }
}
