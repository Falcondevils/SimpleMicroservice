using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServices.Database.Entities;

namespace UserServices.Database
{
    public class DataBaseContext :DbContext

    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=Sample;Integrated Security=True;");
            //optionsBuilder.UseSqlServer(@"Data Source=SEA-FDSQLNP01\LANE07,10.50.6560;Database=Sample;User Id=data_exchange;Password=swapit;");
            optionsBuilder.UseSqlServer(@"Data Source = 10.10.56.61; Initial Catalog = Sample; User ID = data_exchange; Password = swapit;MultipleActiveResultSets=True");
            
        }
    }
}
