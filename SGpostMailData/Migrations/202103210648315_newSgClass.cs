namespace SGpostMailData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newSgClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SgDatas", "SmtpId", c => c.String());
            AddColumn("dbo.SgDatas", "useragent", c => c.String());
            AddColumn("dbo.SgDatas", "ip", c => c.String());
            AddColumn("dbo.SgDatas", "url", c => c.String());
            AddColumn("dbo.SgDatas", "asm_group_id", c => c.Int(nullable: false));
            AlterColumn("dbo.SgDatas", "timestamp", c => c.Int(nullable: false));
            DropColumn("dbo.SgDatas", "Smtp_id");
            DropColumn("dbo.SgDatas", "Category");
            DropColumn("dbo.SgDatas", "reason");
            DropColumn("dbo.SgDatas", "status");
            DropColumn("dbo.SgDatas", "EndPointId");
            DropColumn("dbo.SgDatas", "MobileNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SgDatas", "MobileNumber", c => c.String());
            AddColumn("dbo.SgDatas", "EndPointId", c => c.String());
            AddColumn("dbo.SgDatas", "status", c => c.String());
            AddColumn("dbo.SgDatas", "reason", c => c.String());
            AddColumn("dbo.SgDatas", "Category", c => c.String());
            AddColumn("dbo.SgDatas", "Smtp_id", c => c.String());
            AlterColumn("dbo.SgDatas", "timestamp", c => c.String());
            DropColumn("dbo.SgDatas", "asm_group_id");
            DropColumn("dbo.SgDatas", "url");
            DropColumn("dbo.SgDatas", "ip");
            DropColumn("dbo.SgDatas", "useragent");
            DropColumn("dbo.SgDatas", "SmtpId");
        }
    }
}
