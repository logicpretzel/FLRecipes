namespace FLRecipes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Recipes",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Name = c.String(),
            //            ShortDescription = c.String(),
            //            IngredientString = c.String(),
            //            Preparation = c.String(),
            //            CookingInstructions = c.String(),
            //            ServingInstructions = c.String(),
            //            NutritionInformation = c.String(),
            //            NumberOfReviews = c.Int(nullable: false),
            //            Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            SubmittedBy = c.Int(nullable: false),
            //            SubmittedInitials = c.String(),
            //            PictureURL = c.String(),
            //            PictureCaption = c.String(),
            //            PicWidth = c.Int(nullable: false),
            //            PicHeight = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.Ingredients",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            RecipeID = c.Int(nullable: false),
            //            Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            UnitsID = c.Int(nullable: false),
            //            Description = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Recipes", t => t.RecipeID, cascadeDelete: true)
            //    .Index(t => t.RecipeID);
            
            //CreateTable(
            //    "dbo.Reviews",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            RecipeID = c.Int(nullable: false),
            //            ReviewerDisplayName = c.String(),
            //            ReviewText = c.String(),
            //            Rating = c.Int(nullable: false),
            //            TriedRecipe = c.Boolean(nullable: false),
            //            IsUser = c.Boolean(nullable: false),
            //            UserID = c.Int(nullable: false),
            //            IsValidated = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Recipes", t => t.RecipeID, cascadeDelete: true)
            //    .Index(t => t.RecipeID);
            
            CreateTable(
                "dbo.Subscribers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Email = c.String(),
                        AccountCd = c.Int(nullable: false),
                        MemberSince = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GroceryCarts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubscriberID = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Subscribers", t => t.SubscriberID, cascadeDelete: true)
                .Index(t => t.SubscriberID);
            
            CreateTable(
                "dbo.GCartItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GroceryCartID = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GroceryCarts", t => t.GroceryCartID, cascadeDelete: true)
                .Index(t => t.GroceryCartID);
            
            CreateTable(
                "dbo.MealPlans",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubscriberID = c.Int(nullable: false),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Subscribers", t => t.SubscriberID, cascadeDelete: true)
                .Index(t => t.SubscriberID);
            
            CreateTable(
                "dbo.MPlanItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MealPlanID = c.Int(nullable: false),
                        Description = c.String(),
                        MealDate = c.DateTime(nullable: false),
                        MealDay = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MealPlans", t => t.MealPlanID, cascadeDelete: true)
                .Index(t => t.MealPlanID);
            
            //CreateTable(
            //    "dbo.UnitMeasures",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            TypeCd = c.String(),
            //            Description = c.String(),
            //            Abbrev = c.String(),
            //            EquivalentValue = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            EquivalentMeasure = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MealPlans", "SubscriberID", "dbo.Subscribers");
            DropForeignKey("dbo.MPlanItems", "MealPlanID", "dbo.MealPlans");
            DropForeignKey("dbo.GroceryCarts", "SubscriberID", "dbo.Subscribers");
            DropForeignKey("dbo.GCartItems", "GroceryCartID", "dbo.GroceryCarts");
            DropForeignKey("dbo.Reviews", "RecipeID", "dbo.Recipes");
            DropForeignKey("dbo.Ingredients", "RecipeID", "dbo.Recipes");
            DropIndex("dbo.MPlanItems", new[] { "MealPlanID" });
            DropIndex("dbo.MealPlans", new[] { "SubscriberID" });
            DropIndex("dbo.GCartItems", new[] { "GroceryCartID" });
            DropIndex("dbo.GroceryCarts", new[] { "SubscriberID" });
            DropIndex("dbo.Reviews", new[] { "RecipeID" });
            DropIndex("dbo.Ingredients", new[] { "RecipeID" });
            DropTable("dbo.UnitMeasures");
            DropTable("dbo.MPlanItems");
            DropTable("dbo.MealPlans");
            DropTable("dbo.GCartItems");
            DropTable("dbo.GroceryCarts");
            DropTable("dbo.Subscribers");
            DropTable("dbo.Reviews");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Recipes");
        }
    }
}
