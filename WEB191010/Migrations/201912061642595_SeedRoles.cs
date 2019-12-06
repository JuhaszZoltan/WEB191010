namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using WEB191010.Models;
    
    public partial class SeedRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'531c3edc-5596-4bad-aad9-dabdaa25f495', N'admin@film.hu', 0, N'AO8bWVvb9tj2vP74ziE/VoJBG0aFcKYGgpdnsYvdVpriMVHnRaryoTQiWDQMYJQWig==', N'f408416b-d741-4db0-9e1b-e3162f553d8c', NULL, 0, 0, NULL, 1, 0, N'admin@film.hu');");
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd2c13a3a-cef4-46ff-9fac-c89b4eb5c18e', N'vendeg@film.hu', 0, N'ANJCLIe8euzzgp3sgeqLP77IZ1p5hWWfTj8HwkFN3+gKFqhCsW3bJXrY5/NlqE03Vw==', N'd87bbe21-2708-4103-b969-f0059073543a', NULL, 0, 0, NULL, 1, 0, N'vendeg@film.hu');");
            Sql($@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1bfeec69-03c9-4417-9548-af28cfe5cb74', N'{RoleNevek.Admin}');");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'531c3edc-5596-4bad-aad9-dabdaa25f495', N'1bfeec69-03c9-4417-9548-af28cfe5cb74');");
        }
        
        public override void Down()
        {
        }
    }
}
