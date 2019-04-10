namespace KudosCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Superman : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Wish", name: "PsiogUser_PsiogUserID", newName: "PsiogUserID");
            RenameIndex(table: "dbo.Wish", name: "IX_PsiogUser_PsiogUserID", newName: "IX_PsiogUserID");
            DropColumn("dbo.Wish", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Wish", "UserID", c => c.Int());
            RenameIndex(table: "dbo.Wish", name: "IX_PsiogUserID", newName: "IX_PsiogUser_PsiogUserID");
            RenameColumn(table: "dbo.Wish", name: "PsiogUserID", newName: "PsiogUser_PsiogUserID");
        }
    }
}
