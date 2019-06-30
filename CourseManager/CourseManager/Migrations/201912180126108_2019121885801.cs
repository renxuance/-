namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2019121885801 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ActionLinks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ActionLinks",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 20),
                        Controller = c.String(nullable: false, maxLength: 20),
                        Action = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
