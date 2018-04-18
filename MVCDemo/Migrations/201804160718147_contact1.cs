namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contact", "FullName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Contact", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.Contact", "Message", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Contact", "PhoneNumber", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contact", "PhoneNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Contact", "Message", c => c.String());
            AlterColumn("dbo.Contact", "Email", c => c.String());
            AlterColumn("dbo.Contact", "FullName", c => c.String());
        }
    }
}
