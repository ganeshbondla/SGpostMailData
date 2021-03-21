namespace SGpostMailData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAddUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "EndpointId", c => c.String());
            DropColumn("dbo.Users", "EndpointUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "EndpointUrl", c => c.String());
            DropColumn("dbo.Users", "EndpointId");
        }
    }
}
