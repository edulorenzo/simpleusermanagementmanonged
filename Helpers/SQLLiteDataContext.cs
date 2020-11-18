using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//i hope this works
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace simpleusermanagement.Helpers
{
    public class SQLLiteDataContext : DataContext
    {
        public SqliteDataContext(IConfiguration configuration) : base(configuration) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        }
    }
}
