namespace ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BookReturnings", "BookLendingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookReturnings", "BookLendingId", c => c.Int(nullable: false));
        }
    }
}
