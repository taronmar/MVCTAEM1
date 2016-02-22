using MVCHelloWorldTeam1.DbModels;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCHelloWorldTeam1.Ef
{

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class WarehouseContext : DbContext
    {
        public WarehouseContext() : base("MyContext")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}