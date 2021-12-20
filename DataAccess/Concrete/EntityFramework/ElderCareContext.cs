using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ElderCareContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ElderCareDB;Trusted_Connection=true");
        }
        public DbSet<Elder> Elders { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
    }
}
