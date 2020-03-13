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
            //optionsBuilder.UseSqlServer(@"Data Source=SEA-FDSQLNP01\LANE07,1433;Database=Sample;User Id=data_exchange;Password=swapit;");
           //optionsBuilder.UseSqlServer(@"Data Source=localhost,1433; Initial Catalog=Product;User Id=sa;Password=BigPassw0rd");
            optionsBuilder.UseSqlServer(@"Data Source=10.13.32.149,1433; Initial Catalog=Product;User Id=sa;Password=BigPassw0rd");

        }
    }
}
