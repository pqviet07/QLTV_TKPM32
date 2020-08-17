namespace ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NotificationAccounts", "Notification_Id", "dbo.Notifications");
            DropIndex("dbo.NotificationAccounts", new[] { "Notification_Id" });
            DropPrimaryKey("dbo.Notifications");
            DropPrimaryKey("dbo.NotificationAccounts");
            AlterColumn("dbo.Notifications", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.NotificationAccounts", "Notification_Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Notifications", "Id");
            AddPrimaryKey("dbo.NotificationAccounts", new[] { "Notification_Id", "Account_Id" });
            CreateIndex("dbo.NotificationAccounts", "Notification_Id");
            AddForeignKey("dbo.NotificationAccounts", "Notification_Id", "dbo.Notifications", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotificationAccounts", "Notification_Id", "dbo.Notifications");
            DropIndex("dbo.NotificationAccounts", new[] { "Notification_Id" });
            DropPrimaryKey("dbo.NotificationAccounts");
            DropPrimaryKey("dbo.Notifications");
            AlterColumn("dbo.NotificationAccounts", "Notification_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Notifications", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.NotificationAccounts", new[] { "Notification_Id", "Account_Id" });
            AddPrimaryKey("dbo.Notifications", "Id");
            CreateIndex("dbo.NotificationAccounts", "Notification_Id");
            AddForeignKey("dbo.NotificationAccounts", "Notification_Id", "dbo.Notifications", "Id", cascadeDelete: true);
        }
    }
}
