namespace SGpostMailData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newSgClass1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SgDatas", "mobile", c => c.String());
            AddColumn("dbo.SgDatas", "end_point_id", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SgDatas", "end_point_id");
            DropColumn("dbo.SgDatas", "mobile");
        }
    }
}
