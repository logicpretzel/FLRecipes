namespace FLRecipes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class recipes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipes", "CookingMethod", c => c.Int(nullable: false));
            AddColumn("dbo.Recipes", "SubscriberID", c => c.Int(nullable: false));
            AddColumn("dbo.Recipes", "ReleasedFlag", c => c.Int(nullable: false));
            CreateIndex("dbo.Images", "SubscriberID");
            CreateIndex("dbo.Recipes", "SubscriberID");
            AddForeignKey("dbo.Images", "SubscriberID", "dbo.Subscribers", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Recipes", "SubscriberID", "dbo.Subscribers", "ID", cascadeDelete: true);
            DropColumn("dbo.Recipes", "SubmittedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Recipes", "SubmittedBy", c => c.Int(nullable: false));
            DropForeignKey("dbo.Recipes", "SubscriberID", "dbo.Subscribers");
            DropForeignKey("dbo.Images", "SubscriberID", "dbo.Subscribers");
            DropIndex("dbo.Recipes", new[] { "SubscriberID" });
            DropIndex("dbo.Images", new[] { "SubscriberID" });
            DropColumn("dbo.Recipes", "ReleasedFlag");
            DropColumn("dbo.Recipes", "SubscriberID");
            DropColumn("dbo.Recipes", "CookingMethod");
        }
    }
}
