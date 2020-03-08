using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace T1809E_Corona.Models
{
    public class T1809E_CoronaDbContext: DbContext
    {
        public T1809E_CoronaDbContext() :
            base("MyDbContext")
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}