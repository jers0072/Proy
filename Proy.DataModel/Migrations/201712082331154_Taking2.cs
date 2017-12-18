namespace Proy.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Taking2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "EmployeeId", newName: "Employee_Id");
            RenameIndex(table: "dbo.Orders", name: "IX_EmployeeId", newName: "IX_Employee_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Orders", name: "IX_Employee_Id", newName: "IX_EmployeeId");
            RenameColumn(table: "dbo.Orders", name: "Employee_Id", newName: "EmployeeId");
        }
    }
}
