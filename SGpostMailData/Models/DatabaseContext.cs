using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SGpostMailData.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Admin> admins { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<SgData> sgDatas { get; set; }
    }
}