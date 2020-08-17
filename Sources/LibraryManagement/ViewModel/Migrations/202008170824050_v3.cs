namespace ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.BookItems", "Barcode", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.BookItems", new[] { "Barcode" });
        }
    }
}
