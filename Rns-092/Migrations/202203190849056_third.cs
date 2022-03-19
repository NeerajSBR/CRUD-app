namespace Rns_092.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        appointDate = c.DateTime(nullable: false),
                        ptID = c.Int(nullable: false),
                        docid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Doctors", t => t.docid, cascadeDelete: true)
                .ForeignKey("dbo.patientdbs", t => t.ptID, cascadeDelete: true)
                .Index(t => t.ptID)
                .Index(t => t.docid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "ptID", "dbo.patientdbs");
            DropForeignKey("dbo.Appointments", "docid", "dbo.Doctors");
            DropIndex("dbo.Appointments", new[] { "docid" });
            DropIndex("dbo.Appointments", new[] { "ptID" });
            DropTable("dbo.Appointments");
        }
    }
}
