namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b504027a-1087-44f3-92bd-694e95365877', N'guest@vidly.com', 0, N'AEv9ZQbP/zNCbTZvA/U5DENao88IQFoTf9hGdhYWBQZ28wqPDYof9x3Gw3Fc9nzNNQ==', N'5b0c4642-4eaa-48ca-9fae-eb89341d226b', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd54f3592-2e04-4508-8af3-dbe7dd4826b1', N'admin@vidly.com', 0, N'AEBYnfz0IBCB+g8osGb7U3AV0czFRaVBSQohzHFjyLl7/LU6o8+Of8+n7sa8ggERkQ==', N'7163fdf3-c02a-49fd-9e9d-3b21bae67a99', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b881788e-2fce-43a0-b7c1-eb71c056eda1', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd54f3592-2e04-4508-8af3-dbe7dd4826b1', N'b881788e-2fce-43a0-b7c1-eb71c056eda1')
");
        }
        
        public override void Down()
        {
        }
    }
}
