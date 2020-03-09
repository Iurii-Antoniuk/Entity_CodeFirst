using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORM_Saving_Forms
{
    public class SavingAccount
    {
        public Guid SavingAccountId { get; set; }
        public double Rate { get; set; }
        public double StartAmount { get; set; }
    }
}
