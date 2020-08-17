namespace ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookItems", "Book_Id", "dbo.Books");
            DropIndex("dbo.BookItems", new[] { "Book_Id" });
            DropIndex("dbo.BookItems", new[] { "Barcode" });
            AlterColumn("dbo.BookItems", "Barcode", c => c.String(maxLength: 32));
            DropColumn("dbo.BookItems", "Book_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookItems", "Book_Id", c => c.Int());
            AlterColumn("dbo.BookItems", "Barcode", c => c.String(nullable: false, maxLength: 32));
            CreateIndex("dbo.BookItems", "Barcode", unique: true);
            CreateIndex("dbo.BookItems", "Book_Id");
            AddForeignKey("dbo.BookItems", "Book_Id", "dbo.Books", "Id");
        }
    }
}
