using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataContext.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogRoles",
                columns: table => new
                {
                    BlogRoleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserRole = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogRoles", x => x.BlogRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "PostActivityTypes",
                columns: table => new
                {
                    PostActivityTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PostActivity = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostActivityTypes", x => x.PostActivityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "UserActivityTypes",
                columns: table => new
                {
                    UserActivityTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActivityTypeName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivityTypes", x => x.UserActivityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "BlogUser",
                columns: table => new
                {
                    BlogUserId = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: true),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserRoleBlogRoleId = table.Column<int>(type: "INTEGER", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    UserStory = table.Column<string>(type: "TEXT", nullable: true),
                    ProfilePhoto = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogUser", x => x.BlogUserId);
                    table.ForeignKey(
                        name: "FK_BlogUser_BlogRoles_UserRoleBlogRoleId",
                        column: x => x.UserRoleBlogRoleId,
                        principalTable: "BlogRoles",
                        principalColumn: "BlogRoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostId = table.Column<string>(type: "TEXT", nullable: false),
                    PostCreatorBlogUserId = table.Column<string>(type: "TEXT", nullable: true),
                    PostCreatorId = table.Column<int>(type: "INTEGER", nullable: false),
                    PostTitle = table.Column<string>(type: "TEXT", nullable: true),
                    PostDetails = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ApprovalState = table.Column<int>(type: "INTEGER", nullable: false),
                    LikeCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Picture = table.Column<string>(type: "TEXT", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Post_BlogUser_PostCreatorBlogUserId",
                        column: x => x.PostCreatorBlogUserId,
                        principalTable: "BlogUser",
                        principalColumn: "BlogUserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostActivities",
                columns: table => new
                {
                    PostActivityiD = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PostId1 = table.Column<string>(type: "TEXT", nullable: true),
                    PostId = table.Column<int>(type: "INTEGER", nullable: false),
                    PostActivityTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivityTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserFullName = table.Column<string>(type: "TEXT", nullable: false),
                    PostComment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostActivities", x => x.PostActivityiD);
                    table.ForeignKey(
                        name: "FK_PostActivities_Post_PostId1",
                        column: x => x.PostId1,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostActivities_PostActivityTypes_PostActivityTypeId",
                        column: x => x.PostActivityTypeId,
                        principalTable: "PostActivityTypes",
                        principalColumn: "PostActivityTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    PostId = table.Column<int>(type: "INTEGER", nullable: false),
                    PostId1 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategories", x => new { x.CategoryId, x.PostId });
                    table.ForeignKey(
                        name: "FK_PostCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostCategories_Post_PostId1",
                        column: x => x.PostId1,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserActivities",
                columns: table => new
                {
                    UserActivityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActivityTypeUserActivityTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PostId1 = table.Column<string>(type: "TEXT", nullable: true),
                    PostId = table.Column<int>(type: "INTEGER", nullable: false),
                    DeletedUserDetails = table.Column<string>(type: "TEXT", nullable: true),
                    BlogUserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivities", x => x.UserActivityId);
                    table.ForeignKey(
                        name: "FK_UserActivities_BlogUser_BlogUserId",
                        column: x => x.BlogUserId,
                        principalTable: "BlogUser",
                        principalColumn: "BlogUserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserActivities_Post_PostId1",
                        column: x => x.PostId1,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserActivities_UserActivityTypes_ActivityTypeUserActivityTypeId",
                        column: x => x.ActivityTypeUserActivityTypeId,
                        principalTable: "UserActivityTypes",
                        principalColumn: "UserActivityTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BlogRoles",
                columns: new[] { "BlogRoleId", "UserRole" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "BlogRoles",
                columns: new[] { "BlogRoleId", "UserRole" },
                values: new object[] { 2, "Pro-Editor" });

            migrationBuilder.InsertData(
                table: "BlogRoles",
                columns: new[] { "BlogRoleId", "UserRole" },
                values: new object[] { 3, "Editor" });

            migrationBuilder.InsertData(
                table: "BlogRoles",
                columns: new[] { "BlogRoleId", "UserRole" },
                values: new object[] { 4, "Member" });

            migrationBuilder.InsertData(
                table: "BlogUser",
                columns: new[] { "BlogUserId", "EmailAddress", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePhoto", "RoleId", "UserRoleBlogRoleId", "UserStory" },
                values: new object[] { "f18173-", "Holyspirit@Kingdom.God", "Christ", "Jesus", null, null, "+2348166807840", null, 1, null, "I am the way the truth and the life" });

            migrationBuilder.InsertData(
                table: "BlogUser",
                columns: new[] { "BlogUserId", "EmailAddress", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePhoto", "RoleId", "UserRoleBlogRoleId", "UserStory" },
                values: new object[] { "92fa01-", "Peter@decagon.dev", "Peter", "", null, null, "+2348123456789", null, 2, null, "" });

            migrationBuilder.InsertData(
                table: "BlogUser",
                columns: new[] { "BlogUserId", "EmailAddress", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePhoto", "RoleId", "UserRoleBlogRoleId", "UserStory" },
                values: new object[] { "45a714-", "chukwuemekaokereke@decagon.dev", "Chukwuemeka", "Okereke", null, null, "+2348168360932", null, 2, null, "" });

            migrationBuilder.InsertData(
                table: "BlogUser",
                columns: new[] { "BlogUserId", "EmailAddress", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePhoto", "RoleId", "UserRoleBlogRoleId", "UserStory" },
                values: new object[] { "2dd314-", "Chibuikemakapakar@decagon.dev", "Chibuikem", "Akpaka", null, null, "+2348166807840", null, 2, null, "Do not be decieved, Love is not blind, it just makes you close your eyes" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 10, "General" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 8, "Politics" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 7, "Adventure" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 6, "Architecture" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 9, "Health" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Food" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "LifeStyle" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Technology" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Christianity" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 5, "Social" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "PostId", "ApprovalState", "ArticleCategoryId", "CreationDate", "LikeCount", "Picture", "PostCreatorBlogUserId", "PostCreatorId", "PostDetails", "PostTitle" },
                values: new object[] { "52561", 1, 1, new DateTime(2021, 2, 28, 14, 30, 23, 154, DateTimeKind.Local).AddTicks(4717), 33, null, null, 1, "I remember a conversation during college in which a friend confessed to me that he did not think it was necessary, or even possible, for a believer to gain assurance of their salvation. I was surprised by his comments, especially because we were attending a Christian college that emphasized all the biblical truths related to assurance of salvation: election, grace, faith, repentance, substitutionary atonement, the fully deity and humanity of Christ, and eternal security.As it turns out,this was not an isolated incident.Over the past several years as I’ve wrestled personally with the issue of assurance and had opportunity to speak to others about it,I’ve found that many Christians do not rightly understand the biblical basis or importance of this doctrine.Assurance is essential to genuine Christianity and central to the New Testament’s theological framework, yet plenty of Christians are content to walk through life without the sure knowledge that they belong to Christ.There are, of course, those who claim assurance who have no right to do so; but it seems that there are an equal number of professing Christians who have either resigned to the fact they will never have assurance or that they don’t really need it.", "Salvation" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "PostId", "ApprovalState", "ArticleCategoryId", "CreationDate", "LikeCount", "Picture", "PostCreatorBlogUserId", "PostCreatorId", "PostDetails", "PostTitle" },
                values: new object[] { "84097", 1, 2, new DateTime(2021, 2, 28, 14, 30, 23, 154, DateTimeKind.Local).AddTicks(7484), 31, null, null, 2, "Future of C# Today, C# is not only a Windows development programming language but can be used to build Web applications, Windows store apps, and mobile apps including iOS and Android. C# can also do more than that. If you’ve not already read my article, I highly recommend going and reading What C# Can Do For You.At the Build 2016 event, Microsoft made several exciting announcements and one of them was integrating Xamarin as a part of Visual Studio “15” and beyond. Now C# developers can build iOS and Android apps that can spit out native iOS and Android code....the future of C# is very bright.In the following Channel 9 video, Microsoft’s Dustin Campbell and Mads Torgersen talk about the future of C#.Here are some of the bullet points from the video: You can write C# in any editor you want.C# is open source nowC# runs on Windows, Mac, and LinuxC# can be used to build Windows client apps, Windows Store apps, iOS apps, and Android aps and can also be used to build backend and middle-tier frameworks and libraries.C# (via Roslyn, the C# engine):Supports all IDEs and editorsAll the linters and analysis toolsAll the fixing and refactoring and code generation toolsAll the scripting and all the REPLsC# 7 comes with new features including tuples, record types, and pattern matching.C# is young and evolving.Unlike other programming languages, C# is still young and evolving. Now being open sourced, C# is getting community involvement and new features are being decided by community.The following table summarizes the improvements made in each newer version of the language.", "Seeing Sharp" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "PostId", "ApprovalState", "ArticleCategoryId", "CreationDate", "LikeCount", "Picture", "PostCreatorBlogUserId", "PostCreatorId", "PostDetails", "PostTitle" },
                values: new object[] { "7d2c7", 1, 2, new DateTime(2021, 2, 28, 14, 30, 23, 154, DateTimeKind.Local).AddTicks(7569), 31, null, null, 2, "It’s 2020, four years from now. The campaign is under way to succeed the president, who is retiring after a single wretched term.Voters are angrier than ever—at politicians, at compromisers, at the establishment. Congress and the White House seem incapable of working together on anything, even when their interests align. With lawmaking at a standstill, the president’s use of executive orders and regulatory discretion has reached a level that Congress views as dictatorial—not that Congress can do anything about it, except file lawsuits that the divided Supreme Court, its three vacancies unfilled, has been unable to resolve.On Capitol Hill, Speaker Paul Ryan resigned after proving unable to pass a budget, or much else.The House burned through two more speakers and one “acting” speaker, a job invented following four speakerless months.The Senate, meanwhile, is tied in knots by wannabe presidents and aspiring talk - show hosts, who use the chamber as a social - media platform to build their brands by obstructing—well, everything.The Defense Department is among hundreds of agencies that have not been reauthorized, the government has shut down three times, and, yes, it finally happened: The United States briefly defaulted on the national debt, precipitating a market collapse and an economic downturn. No one wanted that outcome, but no one was able to prevent it.As the presidential primaries unfold, Kanye West is leading a fractured field of Democrats. The Republican front - runner is Phil Robertson, of Duck Dynasty fame. Elected governor of Louisiana only a few months ago, he is promising to defy the Washington establishment by never trimming his beard.Party elders have given up all pretense of being more than spectators, and most of the candidates have given up all pretense of party loyalty. On the debate stages, and everywhere else, anything goes.", "Seeing Sharp" });

            migrationBuilder.InsertData(
                table: "PostActivityTypes",
                columns: new[] { "PostActivityTypeId", "PostActivity" },
                values: new object[] { 1, "Like" });

            migrationBuilder.InsertData(
                table: "PostActivityTypes",
                columns: new[] { "PostActivityTypeId", "PostActivity" },
                values: new object[] { 2, "Comment" });

            migrationBuilder.InsertData(
                table: "UserActivityTypes",
                columns: new[] { "UserActivityTypeId", "ActivityTypeName" },
                values: new object[] { 9, "Sign-Up" });

            migrationBuilder.InsertData(
                table: "UserActivityTypes",
                columns: new[] { "UserActivityTypeId", "ActivityTypeName" },
                values: new object[] { 8, "DeleteUser" });

            migrationBuilder.InsertData(
                table: "UserActivityTypes",
                columns: new[] { "UserActivityTypeId", "ActivityTypeName" },
                values: new object[] { 7, "DeleteComment" });

            migrationBuilder.InsertData(
                table: "UserActivityTypes",
                columns: new[] { "UserActivityTypeId", "ActivityTypeName" },
                values: new object[] { 6, "DeletePPost" });

            migrationBuilder.InsertData(
                table: "UserActivityTypes",
                columns: new[] { "UserActivityTypeId", "ActivityTypeName" },
                values: new object[] { 1, "Like" });

            migrationBuilder.InsertData(
                table: "UserActivityTypes",
                columns: new[] { "UserActivityTypeId", "ActivityTypeName" },
                values: new object[] { 4, "ViewPost" });

            migrationBuilder.InsertData(
                table: "UserActivityTypes",
                columns: new[] { "UserActivityTypeId", "ActivityTypeName" },
                values: new object[] { 3, "AddPost" });

            migrationBuilder.InsertData(
                table: "UserActivityTypes",
                columns: new[] { "UserActivityTypeId", "ActivityTypeName" },
                values: new object[] { 2, "Comment" });

            migrationBuilder.InsertData(
                table: "UserActivityTypes",
                columns: new[] { "UserActivityTypeId", "ActivityTypeName" },
                values: new object[] { 10, "Log-in" });

            migrationBuilder.InsertData(
                table: "UserActivityTypes",
                columns: new[] { "UserActivityTypeId", "ActivityTypeName" },
                values: new object[] { 5, "EditPost" });

            migrationBuilder.InsertData(
                table: "UserActivityTypes",
                columns: new[] { "UserActivityTypeId", "ActivityTypeName" },
                values: new object[] { 11, "Log-Out" });

            migrationBuilder.CreateIndex(
                name: "IX_BlogUser_UserRoleBlogRoleId",
                table: "BlogUser",
                column: "UserRoleBlogRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_PostCreatorBlogUserId",
                table: "Post",
                column: "PostCreatorBlogUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostActivities_PostActivityTypeId",
                table: "PostActivities",
                column: "PostActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PostActivities_PostId1",
                table: "PostActivities",
                column: "PostId1");

            migrationBuilder.CreateIndex(
                name: "IX_PostCategories_PostId1",
                table: "PostCategories",
                column: "PostId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_ActivityTypeUserActivityTypeId",
                table: "UserActivities",
                column: "ActivityTypeUserActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_BlogUserId",
                table: "UserActivities",
                column: "BlogUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_PostId1",
                table: "UserActivities",
                column: "PostId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostActivities");

            migrationBuilder.DropTable(
                name: "PostCategories");

            migrationBuilder.DropTable(
                name: "UserActivities");

            migrationBuilder.DropTable(
                name: "PostActivityTypes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "UserActivityTypes");

            migrationBuilder.DropTable(
                name: "BlogUser");

            migrationBuilder.DropTable(
                name: "BlogRoles");
        }
    }
}
