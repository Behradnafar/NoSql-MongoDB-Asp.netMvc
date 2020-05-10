using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MongoDB_MVC_Example.Data
{
    public class MongoDB_MVC_ExampleContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MongoDB_MVC_ExampleContext() : base("name=MongoDB_MVC_ExampleContext")
        {
        }

        public System.Data.Entity.DbSet<MongoDB_MVC_Example.Models.Person> People { get; set; }
    }
}
