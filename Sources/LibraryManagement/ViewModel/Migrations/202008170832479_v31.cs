namespace ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v31 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.BookItems", new[] { "Barcode" });
            AlterColumn("dbo.BookItems", "Barcode", c => c.String(nullable: false, maxLength: 32));
            CreateIndex("dbo.BookItems", "Barcode", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.BookItems", new[] { "Barcode" });
            AlterColumn("dbo.BookItems", "Barcode", c => c.String(maxLength: 32));
            CreateIndex("dbo.BookItems", "Barcode", unique: true);
        }
    }
}
