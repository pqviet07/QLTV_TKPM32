namespace ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v6 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.BookLendingDetails");
            AlterColumn("dbo.BookLendingDetails", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.BookLendingDetails", "Barcode", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.BookLendingDetails", "Barcode");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.BookLendingDetails");
            AlterColumn("dbo.BookLendingDetails", "Barcode", c => c.String(nullable: false));
            AlterColumn("dbo.BookLendingDetails", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.BookLendingDetails", "Id");
        }
    }
}
