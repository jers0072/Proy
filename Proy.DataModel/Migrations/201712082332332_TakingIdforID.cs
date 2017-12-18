namespace Proy.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TakingIdforID : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Orders", new[] { "Employee_Id" });
            CreateIndex("dbo.Orders", "Employee_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Orders", new[] { "Employee_ID" });
            CreateIndex("dbo.Orders", "Employee_Id");
        }
    }
}
