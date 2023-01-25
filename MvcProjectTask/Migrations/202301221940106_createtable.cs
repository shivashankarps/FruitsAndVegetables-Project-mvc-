namespace MvcProjectTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FruitsAndVegetables", "PackSize", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FruitsAndVegetables", "PackSize", c => c.Int(nullable: false));
        }
    }
}
