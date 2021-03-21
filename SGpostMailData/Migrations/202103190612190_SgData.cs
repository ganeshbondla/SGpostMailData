namespace SGpostMailData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SgData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SgDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Timestamp = c.String(),
                        Smtp_id = c.String(),
                        Event = c.String(),
                        Category = c.String(),
                        Sg_event_id = c.String(),
                        sg_message_id = c.String(),
                        reason = c.String(),
                        status = c.String(),
                        EndPointId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SgDatas");
        }
    }
}
