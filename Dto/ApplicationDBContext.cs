using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestfulProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RestfulProject.Dto
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Users> Users { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=Test.db");*/
    }
}
