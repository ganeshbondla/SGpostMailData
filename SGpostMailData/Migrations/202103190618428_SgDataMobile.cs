namespace SGpostMailData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SgDataMobile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SgDatas", "MobileNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SgDatas", "MobileNumber");
        }
    }
}
