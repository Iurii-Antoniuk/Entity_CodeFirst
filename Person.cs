using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORM_Saving_Forms
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SavingAccount> Accounts { get; set; }
    }
}
