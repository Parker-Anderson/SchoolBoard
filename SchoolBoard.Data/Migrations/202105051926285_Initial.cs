using System;
using System.Data.Entity.Migrations;

public partial class Initial : DbMigration
{
    public override void Up()
    {
        CreateTable(
            "dbo.Course",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CourseName = c.String(),
                    InstructorId = c.String(maxLength: 128),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.ApplicationUser", t => t.InstructorId)
            .Index(t => t.InstructorId);
        
        CreateTable(
            "dbo.ApplicationUser",
            c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    FullName = c.String(),
                    Email = c.String(),
                    EmailConfirmed = c.Boolean(nullable: false),
                    PasswordHash = c.String(),
                    SecurityStamp = c.String(),
                    PhoneNumber = c.String(),
                    PhoneNumberConfirmed = c.Boolean(nullable: false),
                    TwoFactorEnabled = c.Boolean(nullable: false),
                    LockoutEndDateUtc = c.DateTime(),
                    LockoutEnabled = c.Boolean(nullable: false),
                    AccessFailedCount = c.Int(nullable: false),
                    UserName = c.String(),
                })
            .PrimaryKey(t => t.Id);
        
        CreateTable(
            "dbo.IdentityUserClaim",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserId = c.String(),
                    ClaimType = c.String(),
                    ClaimValue = c.String(),
                    ApplicationUser_Id = c.String(maxLength: 128),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
            .Index(t => t.ApplicationUser_Id);
        
        CreateTable(
            "dbo.IdentityUserLogin",
            c => new
                {
                    UserId = c.String(nullable: false, maxLength: 128),
                    LoginProvider = c.String(),
                    ProviderKey = c.String(),
                    ApplicationUser_Id = c.String(maxLength: 128),
                })
            .PrimaryKey(t => t.UserId)
            .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
            .Index(t => t.ApplicationUser_Id);
        
        CreateTable(
            "dbo.IdentityUserRole",
            c => new
                {
                    UserId = c.String(nullable: false, maxLength: 128),
                    RoleId = c.String(),
                    ApplicationUser_Id = c.String(maxLength: 128),
                    IdentityRole_Id = c.String(maxLength: 128),
                })
            .PrimaryKey(t => t.UserId)
            .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
            .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
            .Index(t => t.ApplicationUser_Id)
            .Index(t => t.IdentityRole_Id);
        
        CreateTable(
            "dbo.Student",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    GPA = c.Double(nullable: false),
                    ApplicationUser_Id = c.String(maxLength: 128),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
            .Index(t => t.ApplicationUser_Id);
        
        CreateTable(
            "dbo.Post",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    StudentId = c.Int(nullable: false),
                    InstructorId = c.String(maxLength: 128),
                    MyName = c.String(),
                    Title = c.String(),
                    Body = c.String(),
                    Created = c.DateTime(nullable: false),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.ApplicationUser", t => t.InstructorId)
            .ForeignKey("dbo.Student", t => t.StudentId, cascadeDelete: true)
            .Index(t => t.StudentId)
            .Index(t => t.InstructorId);
        
        CreateTable(
            "dbo.IdentityRole",
            c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(),
                })
            .PrimaryKey(t => t.Id);
        
        CreateTable(
            "dbo.CourseStudent",
            c => new
                {
                    CourseId = c.Int(nullable: false),
                    StudentId = c.Int(nullable: false),
                })
            .PrimaryKey(t => new { t.CourseId, t.StudentId })
            .ForeignKey("dbo.Course", t => t.CourseId, cascadeDelete: true)
            .ForeignKey("dbo.Student", t => t.StudentId, cascadeDelete: true)
            .Index(t => t.CourseId)
            .Index(t => t.StudentId);
        
    }
    
    public override void Down()
    {
        DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
        DropForeignKey("dbo.CourseStudent", "StudentId", "dbo.Student");
        DropForeignKey("dbo.CourseStudent", "CourseId", "dbo.Course");
        DropForeignKey("dbo.Course", "InstructorId", "dbo.ApplicationUser");
        DropForeignKey("dbo.Student", "ApplicationUser_Id", "dbo.ApplicationUser");
        DropForeignKey("dbo.Post", "StudentId", "dbo.Student");
        DropForeignKey("dbo.Post", "InstructorId", "dbo.ApplicationUser");
        DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
        DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
        DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
        DropIndex("dbo.CourseStudent", new[] { "StudentId" });
        DropIndex("dbo.CourseStudent", new[] { "CourseId" });
        DropIndex("dbo.Post", new[] { "InstructorId" });
        DropIndex("dbo.Post", new[] { "StudentId" });
        DropIndex("dbo.Student", new[] { "ApplicationUser_Id" });
        DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
        DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
        DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
        DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
        DropIndex("dbo.Course", new[] { "InstructorId" });
        DropTable("dbo.CourseStudent");
        DropTable("dbo.IdentityRole");
        DropTable("dbo.Post");
        DropTable("dbo.Student");
        DropTable("dbo.IdentityUserRole");
        DropTable("dbo.IdentityUserLogin");
        DropTable("dbo.IdentityUserClaim");
        DropTable("dbo.ApplicationUser");
        DropTable("dbo.Course");
    }
}