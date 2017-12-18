namespace Proy.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingForaingKeyEmployeeInOrder : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Employee_ID", "dbo.Employees");
            DropIndex("dbo.Orders", new[] { "Employee_ID" });
            RenameColumn(table: "dbo.Orders", name: "Employee_ID", newName: "EmployeeId");
            AlterColumn("dbo.Orders", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "EmployeeId");
            AddForeignKey("dbo.Orders", "EmployeeId", "dbo.Employees", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Orders", new[] { "EmployeeId" });
            AlterColumn("dbo.Orders", "EmployeeId", c => c.Int());
            RenameColumn(table: "dbo.Orders", name: "EmployeeId", newName: "Employee_ID");
            CreateIndex("dbo.Orders", "Employee_ID");
            AddForeignKey("dbo.Orders", "Employee_ID", "dbo.Employees", "ID");
        }
    }
}
