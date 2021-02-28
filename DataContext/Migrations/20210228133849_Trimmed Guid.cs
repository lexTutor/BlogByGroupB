using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataContext.Migrations
{
    public partial class TrimmedGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogUser",
                keyColumn: "BlogUserId",
                keyValue: "2dd314-");

            migrationBuilder.DeleteData(
                table: "BlogUser",
                keyColumn: "BlogUserId",
                keyValue: "45a714-");

            migrationBuilder.DeleteData(
                table: "BlogUser",
                keyColumn: "BlogUserId",
                keyValue: "92fa01-");

            migrationBuilder.DeleteData(
                table: "BlogUser",
                keyColumn: "BlogUserId",
                keyValue: "f18173-");

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: "52561");

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: "7d2c7");

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: "84097");

            migrationBuilder.InsertData(
                table: "BlogUser",
                columns: new[] { "BlogUserId", "EmailAddress", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePhoto", "RoleId", "UserRoleBlogRoleId", "UserStory" },
                values: new object[] { "7607f9", "Holyspirit@Kingdom.God", "Christ", "Jesus", null, null, "+2348166807840", null, 1, null, "I am the way the truth and the life" });

            migrationBuilder.InsertData(
                table: "BlogUser",
                columns: new[] { "BlogUserId", "EmailAddress", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePhoto", "RoleId", "UserRoleBlogRoleId", "UserStory" },
                values: new object[] { "5c38f2", "Peter@decagon.dev", "Peter", "", null, null, "+2348123456789", null, 2, null, "" });

            migrationBuilder.InsertData(
                table: "BlogUser",
                columns: new[] { "BlogUserId", "EmailAddress", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePhoto", "RoleId", "UserRoleBlogRoleId", "UserStory" },
                values: new object[] { "fdb0fa", "chukwuemekaokereke@decagon.dev", "Chukwuemeka", "Okereke", null, null, "+2348168360932", null, 2, null, "" });

            migrationBuilder.InsertData(
                table: "BlogUser",
                columns: new[] { "BlogUserId", "EmailAddress", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePhoto", "RoleId", "UserRoleBlogRoleId", "UserStory" },
                values: new object[] { "8a003d", "Chibuikemakapakar@decagon.dev", "Chibuikem", "Akpaka", null, null, "+2348166807840", null, 2, null, "Do not be decieved, Love is not blind, it just makes you close your eyes" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "PostId", "ApprovalState", "ArticleCategoryId", "CreationDate", "LikeCount", "Picture", "PostCreatorBlogUserId", "PostCreatorId", "PostDetails", "PostTitle" },
                values: new object[] { "16ac8", 1, 1, new DateTime(2021, 2, 28, 14, 38, 48, 23, DateTimeKind.Local).AddTicks(4459), 33, null, null, 1, "I remember a conversation during college in which a friend confessed to me that he did not think it was necessary, or even possible, for a believer to gain assurance of their salvation. I was surprised by his comments, especially because we were attending a Christian college that emphasized all the biblical truths related to assurance of salvation: election, grace, faith, repentance, substitutionary atonement, the fully deity and humanity of Christ, and eternal security.As it turns out,this was not an isolated incident.Over the past several years as I’ve wrestled personally with the issue of assurance and had opportunity to speak to others about it,I’ve found that many Christians do not rightly understand the biblical basis or importance of this doctrine.Assurance is essential to genuine Christianity and central to the New Testament’s theological framework, yet plenty of Christians are content to walk through life without the sure knowledge that they belong to Christ.There are, of course, those who claim assurance who have no right to do so; but it seems that there are an equal number of professing Christians who have either resigned to the fact they will never have assurance or that they don’t really need it.", "Salvation" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "PostId", "ApprovalState", "ArticleCategoryId", "CreationDate", "LikeCount", "Picture", "PostCreatorBlogUserId", "PostCreatorId", "PostDetails", "PostTitle" },
                values: new object[] { "b1a3f", 1, 2, new DateTime(2021, 2, 28, 14, 38, 48, 23, DateTimeKind.Local).AddTicks(8203), 31, null, null, 2, "Future of C# Today, C# is not only a Windows development programming language but can be used to build Web applications, Windows store apps, and mobile apps including iOS and Android. C# can also do more than that. If you’ve not already read my article, I highly recommend going and reading What C# Can Do For You.At the Build 2016 event, Microsoft made several exciting announcements and one of them was integrating Xamarin as a part of Visual Studio “15” and beyond. Now C# developers can build iOS and Android apps that can spit out native iOS and Android code....the future of C# is very bright.In the following Channel 9 video, Microsoft’s Dustin Campbell and Mads Torgersen talk about the future of C#.Here are some of the bullet points from the video: You can write C# in any editor you want.C# is open source nowC# runs on Windows, Mac, and LinuxC# can be used to build Windows client apps, Windows Store apps, iOS apps, and Android aps and can also be used to build backend and middle-tier frameworks and libraries.C# (via Roslyn, the C# engine):Supports all IDEs and editorsAll the linters and analysis toolsAll the fixing and refactoring and code generation toolsAll the scripting and all the REPLsC# 7 comes with new features including tuples, record types, and pattern matching.C# is young and evolving.Unlike other programming languages, C# is still young and evolving. Now being open sourced, C# is getting community involvement and new features are being decided by community.The following table summarizes the improvements made in each newer version of the language.", "Seeing Sharp" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "PostId", "ApprovalState", "ArticleCategoryId", "CreationDate", "LikeCount", "Picture", "PostCreatorBlogUserId", "PostCreatorId", "PostDetails", "PostTitle" },
                values: new object[] { "f1438", 1, 2, new DateTime(2021, 2, 28, 14, 38, 48, 23, DateTimeKind.Local).AddTicks(8833), 31, null, null, 2, "It’s 2020, four years from now. The campaign is under way to succeed the president, who is retiring after a single wretched term.Voters are angrier than ever—at politicians, at compromisers, at the establishment. Congress and the White House seem incapable of working together on anything, even when their interests align. With lawmaking at a standstill, the president’s use of executive orders and regulatory discretion has reached a level that Congress views as dictatorial—not that Congress can do anything about it, except file lawsuits that the divided Supreme Court, its three vacancies unfilled, has been unable to resolve.On Capitol Hill, Speaker Paul Ryan resigned after proving unable to pass a budget, or much else.The House burned through two more speakers and one “acting” speaker, a job invented following four speakerless months.The Senate, meanwhile, is tied in knots by wannabe presidents and aspiring talk - show hosts, who use the chamber as a social - media platform to build their brands by obstructing—well, everything.The Defense Department is among hundreds of agencies that have not been reauthorized, the government has shut down three times, and, yes, it finally happened: The United States briefly defaulted on the national debt, precipitating a market collapse and an economic downturn. No one wanted that outcome, but no one was able to prevent it.As the presidential primaries unfold, Kanye West is leading a fractured field of Democrats. The Republican front - runner is Phil Robertson, of Duck Dynasty fame. Elected governor of Louisiana only a few months ago, he is promising to defy the Washington establishment by never trimming his beard.Party elders have given up all pretense of being more than spectators, and most of the candidates have given up all pretense of party loyalty. On the debate stages, and everywhere else, anything goes.", "Seeing Sharp" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogUser",
                keyColumn: "BlogUserId",
                keyValue: "5c38f2");

            migrationBuilder.DeleteData(
                table: "BlogUser",
                keyColumn: "BlogUserId",
                keyValue: "7607f9");

            migrationBuilder.DeleteData(
                table: "BlogUser",
                keyColumn: "BlogUserId",
                keyValue: "8a003d");

            migrationBuilder.DeleteData(
                table: "BlogUser",
                keyColumn: "BlogUserId",
                keyValue: "fdb0fa");

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: "16ac8");

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: "b1a3f");

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: "f1438");

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
        }
    }
}
