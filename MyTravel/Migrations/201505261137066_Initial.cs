namespace MyTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationID = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.DestinationID);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        TripID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Year = c.Int(nullable: false),
                        Destination_DestinationID = c.Int(),
                    })
                .PrimaryKey(t => t.TripID)
                .ForeignKey("dbo.Destinations", t => t.Destination_DestinationID)
                .Index(t => t.Destination_DestinationID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trips", "Destination_DestinationID", "dbo.Destinations");
            DropIndex("dbo.Trips", new[] { "Destination_DestinationID" });
            DropTable("dbo.Trips");
            DropTable("dbo.Destinations");
        }
    }
}
