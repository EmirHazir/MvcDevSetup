namespace PSH.DAL.Auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Auth.Accounts",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        UserId = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Auth.Clients",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        ClientSecret = c.String(),
                        ClientName = c.String(maxLength: 150),
                        ClientDescription = c.String(maxLength: 200),
                        RefreshTokenLifespan = c.Int(nullable: false),
                        AllowedOrigin = c.String(maxLength: 200),
                        TimeStamp = c.DateTime(nullable: false),
                        Account_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Auth.Accounts", t => t.Account_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.RefreshTokens",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        HashedId = c.String(),
                        Subject = c.String(maxLength: 50),
                        ClientId = c.String(),
                        IssuedUTC = c.DateTime(nullable: false),
                        ExpiresUTC = c.DateTime(nullable: false),
                        ProtectedTicket = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Auth.Clients", "Account_Id", "Auth.Accounts");
            DropIndex("Auth.Clients", new[] { "Account_Id" });
            DropTable("dbo.RefreshTokens");
            DropTable("Auth.Clients");
            DropTable("Auth.Accounts");
        }
    }
}
