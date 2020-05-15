namespace PMSShopping.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_tbl_slide : DbMigration
    {
        public override void Up()
        {
           
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 256),
                        Image = c.String(maxLength: 256),
                        Url = c.String(maxLength: 256),
                        DisplayOrder = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
          
            
        }
        
        public override void Down()
        {
          
            DropTable("dbo.Slides");
       
        }
    }
}
