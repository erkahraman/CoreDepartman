using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=CorePersonel; integrated security=true;");
            //base.OnConfiguring(optionsBuilder);
        }
        public DbSet<departmanlar> departmanlars { get; set; }
        public DbSet<personel> personels { get; set; }
    }
}
