using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onlinechildrenbookstore.Models;

namespace onlinechildrenbookstore.Data
{
    public class onlinechildrenbookstoreContext : DbContext
    {
        public onlinechildrenbookstoreContext (DbContextOptions<onlinechildrenbookstoreContext> options)
            : base(options)
        {
        }

        public DbSet<onlinechildrenbookstore.Models.book> book { get; set; }

        public DbSet<onlinechildrenbookstore.Models.usersaccounts> usersaccounts { get; set; }

        public DbSet<onlinechildrenbookstore.Models.orders> orders { get; set; }

        public DbSet<onlinechildrenbookstore.Models.report> report { get; set; }
    }
}
