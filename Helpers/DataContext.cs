using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//use EF Core
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
//use Entities
using simpleusermanagement.Entities;

namespace simpleusermanagement.Helpers
{
    public class DataContext : DbContext    
    {
        protected readonly IConfiguration configuration;
        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration1;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqllite
            //options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }
        //get me some users
        public DbSet<User> Users { get; set; }
    }
}
