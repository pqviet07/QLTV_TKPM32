namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookItems", "Book_Id", c => c.Int());
            CreateIndex("dbo.BookItems", "Book_Id");
            AddForeignKey("dbo.BookItems", "Book_Id", "dbo.Books", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookItems", "Book_Id", "dbo.Books");
            DropIndex("dbo.BookItems", new[] { "Book_Id" });
            DropColumn("dbo.BookItems", "Book_Id");
        }
    }
}
