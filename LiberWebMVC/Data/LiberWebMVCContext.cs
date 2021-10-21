using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LiberWebMVC.Models;

namespace LiberWebMVC.Data
{
    public class LiberWebMVCContext : DbContext
    {
        public LiberWebMVCContext (DbContextOptions<LiberWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<LiberWebMVC.Models.Department> Department { get; set; }
    }
}
