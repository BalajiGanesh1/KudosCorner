namespace KudosCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kudo",
                c => new
                    {
                        KudoID = c.Int(nullable: false, identity: true),
                        Image_Link = c.String(),
                        Description = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.KudoID);
            
            CreateTable(
                "dbo.PsiogUser",
                c => new
                    {
                        PsiogUserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        EMail = c.String(),
                    })
                .PrimaryKey(t => t.PsiogUserID);
            
            CreateTable(
                "dbo.Wish",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        KudoID = c.Int(nullable: false),
                        Message = c.String(),
                        PsiogUserID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PsiogUser", t => t.PsiogUserID)
                .ForeignKey("dbo.Kudo", t => t.KudoID, cascadeDelete: true)
                .Index(t => t.KudoID)
                .Index(t => t.PsiogUserID);
            
            CreateTable(
                "dbo.PsiogUserKudo",
                c => new
                    {
                        PsiogUserID = c.Int(nullable: false),
                        KudoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PsiogUserID, t.KudoID })
                .ForeignKey("dbo.PsiogUser", t => t.PsiogUserID, cascadeDelete: true)
                .ForeignKey("dbo.Kudo", t => t.KudoID, cascadeDelete: true)
                .Index(t => t.PsiogUserID)
                .Index(t => t.KudoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wish", "KudoID", "dbo.Kudo");
            DropForeignKey("dbo.Wish", "PsiogUserID", "dbo.PsiogUser");
            DropForeignKey("dbo.PsiogUserKudo", "KudoID", "dbo.Kudo");
            DropForeignKey("dbo.PsiogUserKudo", "PsiogUserID", "dbo.PsiogUser");
            DropIndex("dbo.PsiogUserKudo", new[] { "KudoID" });
            DropIndex("dbo.PsiogUserKudo", new[] { "PsiogUserID" });
            DropIndex("dbo.Wish", new[] { "PsiogUserID" });
            DropIndex("dbo.Wish", new[] { "KudoID" });
            DropTable("dbo.PsiogUserKudo");
            DropTable("dbo.Wish");
            DropTable("dbo.PsiogUser");
            DropTable("dbo.Kudo");
        }
    }
}
