using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyTravel.Models
{
    public class MyTravelContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyTravelContext() : base("name=MyTravelContext")
        {
            Database.SetInitializer(new MyTravelDatabaseInitializer());
        }

        public System.Data.Entity.DbSet<MyTravel.Models.Destination> Destinations { get; set; }

        public System.Data.Entity.DbSet<MyTravel.Models.Trip> Trips { get; set; }

        
    }
}
