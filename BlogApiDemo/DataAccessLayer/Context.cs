using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-E3U56DH\\SQLEXPRESS;database=CoreBlogApiDb123; integrated security=true;");
        }
        public DbSet<Employee1> Employees { get; set; }
    }
}
