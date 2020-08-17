namespace ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookAuthors", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "Author_Id", "dbo.Authors");
            DropIndex("dbo.BookAuthors", new[] { "Book_Id" });
            DropIndex("dbo.BookAuthors", new[] { "Author_Id" });
            CreateTable(
                "dbo.BookDummyAuthors",
                c => new
                    {
                        BookDummy_Id = c.Int(nullable: false),
                        Author_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BookDummy_Id, t.Author_Id })
                .ForeignKey("dbo.Books", t => t.BookDummy_Id, cascadeDelete: true)
                .ForeignKey("dbo.Authors", t => t.Author_Id, cascadeDelete: true)
                .Index(t => t.BookDummy_Id)
                .Index(t => t.Author_Id);
            
            AddColumn("dbo.BookItems", "BookDummy_Id", c => c.Int());
            AlterColumn("dbo.BookItems", "Barcode", c => c.String(nullable: false, maxLength: 32));
            CreateIndex("dbo.BookItems", "BookDummy_Id");
            CreateIndex("dbo.BookItems", "Barcode", unique: true);
            AddForeignKey("dbo.BookItems", "BookDummy_Id", "dbo.Books", "Id");
            DropTable("dbo.BookAuthors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Book_Id = c.Int(nullable: false),
                        Author_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_Id, t.Author_Id });
            
            DropForeignKey("dbo.BookItems", "BookDummy_Id", "dbo.Books");
            DropForeignKey("dbo.BookDummyAuthors", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.BookDummyAuthors", "BookDummy_Id", "dbo.Books");
            DropIndex("dbo.BookItems", new[] { "Barcode" });
            DropIndex("dbo.BookItems", new[] { "BookDummy_Id" });
            DropIndex("dbo.BookDummyAuthors", new[] { "Author_Id" });
            DropIndex("dbo.BookDummyAuthors", new[] { "BookDummy_Id" });
            AlterColumn("dbo.BookItems", "Barcode", c => c.String(nullable: false));
            DropColumn("dbo.BookItems", "BookDummy_Id");
            DropTable("dbo.BookDummyAuthors");
            CreateIndex("dbo.BookAuthors", "Author_Id");
            CreateIndex("dbo.BookAuthors", "Book_Id");
            AddForeignKey("dbo.BookAuthors", "Author_Id", "dbo.Authors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BookAuthors", "Book_Id", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
