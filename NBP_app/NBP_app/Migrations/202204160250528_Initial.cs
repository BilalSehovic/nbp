namespace NBP_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        ZipCode = c.Int(nullable: false),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Places");
        }
    }
}
