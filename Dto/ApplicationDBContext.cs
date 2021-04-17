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
        public DbSet<UsersModel> Users { get; set; }
        public ApplicationDBContext() : base()
        { 

        }
    }
}
