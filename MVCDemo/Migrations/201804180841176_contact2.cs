namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contact", "FullName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Contact", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Contact", "Message", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Contact", "PhoneNumber", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contact", "PhoneNumber", c => c.String(maxLength: 15));
            AlterColumn("dbo.Contact", "Message", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Contact", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.Contact", "FullName", c => c.String(maxLength: 100));
        }
    }
}
