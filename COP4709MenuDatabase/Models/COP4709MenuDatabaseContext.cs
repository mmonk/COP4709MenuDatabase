using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace COP4709MenuDatabase.Models
{
    public class COP4709MenuDatabaseContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public COP4709MenuDatabaseContext() : base("name=COP4709MenuDatabaseContext")
        {
        }

        public System.Data.Entity.DbSet<COP4709MenuDatabase.Models.Menu> Menus { get; set; }

        public System.Data.Entity.DbSet<COP4709MenuDatabase.Models.MenuGroup> MenuGroups { get; set; }

        public System.Data.Entity.DbSet<COP4709MenuDatabase.Models.MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<MenuGroup>().HasOptional(m => m.Menu).WithOptionalDependent().WillCascadeOnDelete(false);

           // modelBuilder.Entity<MenuItem>().HasOptional(m => m.Menu).WithOptionalDependent().WillCascadeOnDelete(false);
           // modelBuilder.Entity<MenuItem>().HasOptional(m => m.MenuGroup).WithOptionalDependent().WillCascadeOnDelete(false);


            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

      
    }
}
