
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testmysqlapi.Models;

namespace testmysqlapi.DBContexts
{
    public class MyDBContext : DbContext
    {
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<User> Users { get; set; }
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }
    }
}
