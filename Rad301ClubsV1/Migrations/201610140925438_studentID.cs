namespace Rad301ClubsV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "StudentID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "StudentID");
        }
    }
}
