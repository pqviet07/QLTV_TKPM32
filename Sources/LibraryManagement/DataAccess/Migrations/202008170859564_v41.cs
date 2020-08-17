namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v41 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Books", newName: "BookDummys");
            DropForeignKey("dbo.BookDummyAuthors", "BookDummy_Id", "dbo.Books");
            DropForeignKey("dbo.BookItems", "Id", "dbo.Books");
            DropForeignKey("dbo.BookItems", "BookDummy_Id", "dbo.Books");
            DropPrimaryKey("dbo.BookDummys");
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ISBN = c.String(nullable: false),
                        BookName = c.String(nullable: false),
                        BookType = c.Int(nullable: false),
                        Publisher = c.String(nullable: false),
                        Language = c.String(nullable: false),
                        NumsOfPages = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.BookDummys", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.BookDummys", "Id");
            CreateIndex("dbo.BookDummys", "Id");
            AddForeignKey("dbo.BookDummys", "Id", "dbo.Books", "Id");
            AddForeignKey("dbo.BookDummyAuthors", "BookDummy_Id", "dbo.BookDummys", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BookItems", "BookDummy_Id", "dbo.BookDummys", "Id");
            DropColumn("dbo.BookDummys", "ISBN");
            DropColumn("dbo.BookDummys", "BookName");
            DropColumn("dbo.BookDummys", "BookType");
            DropColumn("dbo.BookDummys", "Publisher");
            DropColumn("dbo.BookDummys", "Language");
            DropColumn("dbo.BookDummys", "NumsOfPages");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookDummys", "NumsOfPages", c => c.Int(nullable: false));
            AddColumn("dbo.BookDummys", "Language", c => c.String(nullable: false));
            AddColumn("dbo.BookDummys", "Publisher", c => c.String(nullable: false));
            AddColumn("dbo.BookDummys", "BookType", c => c.Int(nullable: false));
            AddColumn("dbo.BookDummys", "BookName", c => c.String(nullable: false));
            AddColumn("dbo.BookDummys", "ISBN", c => c.String(nullable: false));
            DropForeignKey("dbo.BookItems", "BookDummy_Id", "dbo.BookDummys");
            DropForeignKey("dbo.BookDummyAuthors", "BookDummy_Id", "dbo.BookDummys");
            DropForeignKey("dbo.BookDummys", "Id", "dbo.Books");
            DropIndex("dbo.BookDummys", new[] { "Id" });
            DropPrimaryKey("dbo.BookDummys");
            AlterColumn("dbo.BookDummys", "Id", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.Books");
            AddPrimaryKey("dbo.BookDummys", "Id");
            AddForeignKey("dbo.BookItems", "BookDummy_Id", "dbo.Books", "Id");
            AddForeignKey("dbo.BookItems", "Id", "dbo.Books", "Id");
            AddForeignKey("dbo.BookDummyAuthors", "BookDummy_Id", "dbo.Books", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.BookDummys", newName: "Books");
        }
    }
}
