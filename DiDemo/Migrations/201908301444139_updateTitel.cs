namespace DiDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTitel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Artikals", newName: "Artikels");
            AddColumn("dbo.Artikels", "Ueberschrift", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artikels", "Ueberschrift");
            RenameTable(name: "dbo.Artikels", newName: "Artikals");
        }
    }
}
