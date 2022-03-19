namespace Rns_092.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        speciality = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.patientdbs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        temp = c.Single(nullable: false),
                        allergies = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.patientdbs");
            DropTable("dbo.Doctors");
        }
    }
}
