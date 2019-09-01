namespace DiDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initials : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artikals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShortArtikel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Artikals");
        }
    }
}
