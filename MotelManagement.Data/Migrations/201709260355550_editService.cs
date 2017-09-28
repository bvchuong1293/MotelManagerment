namespace MotelManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editService : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImportGoodss", "Unit", c => c.String());
            AlterColumn("dbo.Services", "UnitPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Services", "UnitPrice", c => c.String(nullable: false, maxLength: 10));
            DropColumn("dbo.ImportGoodss", "Unit");
        }
    }
}
