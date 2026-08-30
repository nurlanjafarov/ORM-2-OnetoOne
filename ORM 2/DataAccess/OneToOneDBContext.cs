using Microsoft.EntityFrameworkCore;
using ORM_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_2.DataAccess
{
    public class OneToOneDBContext:DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
        "Data Source=STHQ012D-06;" +
        "Initial Catalog=OneToOneDb;" +
        "Integrated Security=False;" +
        "User Id=admin;" +
        "Password=admin;" +
        "TrustServerCertificate=True;" +
        "Encrypt=True;");

        }
    }
}
