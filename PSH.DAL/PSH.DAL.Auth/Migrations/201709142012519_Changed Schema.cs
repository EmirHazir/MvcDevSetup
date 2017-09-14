namespace PSH.DAL.Auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedSchema : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.RefreshTokens", newSchema: "Auth");
        }
        
        public override void Down()
        {
            MoveTable(name: "Auth.RefreshTokens", newSchema: "dbo");
        }
    }
}
