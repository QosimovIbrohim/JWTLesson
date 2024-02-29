using JWT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT.Infrastruct.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
         : base (options)
        {
            Database.Migrate();        
        }

        public DbSet<User> Users { get; set; }
        public DbSet<GuidSaver> GuidSavers { get; set; }
    }
}
