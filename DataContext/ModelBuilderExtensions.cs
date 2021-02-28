using KingdomBlog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataContext
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            string user1Guid;
            string user2Guid;
            string user3Guid;


            modelBuilder.Entity<BlogUser>().HasData(
            new BlogUser
            {
                FirstName = "Christ",
                LastName = "Jesus",
                EmailAddress = "Holyspirit@Kingdom.God",
                RoleId = 1,
                PhoneNumber = "+2348166807840",
                UserStory = "I am the way the truth and the life",
                BlogUserId = user1Guid = Guid.NewGuid().ToString().Substring(2,6)
            },
             new BlogUser
             {
                 FirstName = "Peter",
                 LastName = "",
                 EmailAddress = "Peter@decagon.dev",
                 RoleId = 2,
                 PhoneNumber = "+2348123456789",
                 UserStory = "",
                 BlogUserId = user2Guid = Guid.NewGuid().ToString().Substring(2, 6)
             },
             new BlogUser
             {
                 FirstName = "Chukwuemeka",
                 LastName = "Okereke",
                 EmailAddress = "chukwuemekaokereke@decagon.dev",
                 RoleId = 2,
                 PhoneNumber = "+2348168360932",
                 UserStory = "",
                 BlogUserId = user3Guid = Guid.NewGuid().ToString().Substring(2, 6)
             },
              new BlogUser
              {
                  FirstName = "Chibuikem",
                  LastName = "Akpaka",
                  EmailAddress = "Chibuikemakapakar@decagon.dev",
                  RoleId = 2,
                  PhoneNumber = "+2348166807840",
                  UserStory = "Do not be decieved, Love is not blind, it just makes you close your eyes",
                  BlogUserId = Guid.NewGuid().ToString().Substring(2, 6)
              }
            );

            modelBuilder.Entity<BlogRole>().HasData(
            new BlogRole
            {
                UserRole = "Admin",
                BlogRoleId = 1
            },
            new BlogRole
            {
                UserRole = "Pro-Editor",
                BlogRoleId = 2
            },
            new BlogRole
            {
                UserRole = "Editor",
                BlogRoleId = 3
            },
            new BlogRole
            {
                UserRole = "Member",
                BlogRoleId = 4
            }
           );

            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryName = "Christianity",
                CategoryId = 1
            },
            new Category
            {
                CategoryName = "Technology",
                CategoryId = 2
            },
            new Category
            {
                CategoryName = "LifeStyle",
                CategoryId = 3
            },
            new Category
            {
                CategoryName = "Food",
                CategoryId = 4
            },
            new Category
            {
                CategoryName = "Social",
                CategoryId = 5
            },
            new Category
            {
                CategoryName = "Architecture",
                CategoryId = 6
            },
            new Category
            {
                CategoryName = "Adventure",
                CategoryId = 7
            },
            new Category
            {
                CategoryName = "Politics",
                CategoryId = 8
            },
            new Category
            {
                CategoryName = "Health",
                CategoryId = 9
            },
            new Category
            {
                CategoryName = "General",
                CategoryId = 10
            }
            );

            modelBuilder.Entity<Post>().HasData(
            new Post
            {
                PostId = Guid.NewGuid().ToString().Substring(1, 5),
                PostCreatorId = user1Guid,
                PostTitle = "Salvation",
                ApprovalState = 1,
                LikeCount = 33,
                CreationDate = DateTime.Now,
                ArticleCategoryId = 1,
                PostDetails = "I remember a conversation during college in which a friend confessed to me that he did not think it was necessary, or even possible, for a " +
                "believer to gain assurance of their salvation. I was surprised by his comments, especially because we were attending a Christian college that emphasized all the biblical truths " +
                "related to assurance of salvation: election, grace, faith, repentance, substitutionary atonement, the fully deity and humanity of Christ, and eternal security." +
                "As it turns out," +
                "this was not an isolated incident.Over the past several years as I’ve wrestled personally with the issue of assurance and had opportunity to speak to others about it," +
                "I’ve found that many Christians do not rightly understand the biblical basis or importance of this doctrine.Assurance is essential to genuine " +
                "Christianity and central to the New Testament’s theological framework, yet plenty of Christians are content to walk through life without the sure knowledge that they belong to Christ." +
                "There are, of course, those who claim assurance who have no right to do so; but it seems that there are an equal number of professing Christians who have either resigned to the fact they will never have assurance" +
                " or that they don’t really need it."
            },
             new Post
             {
                 PostId = Guid.NewGuid().ToString().Substring(1, 5),
                 PostCreatorId = user2Guid,
                 PostTitle = "Seeing Sharp",
                 ApprovalState = 1,
                 LikeCount = 31,
                 CreationDate = DateTime.Now,
                 ArticleCategoryId = 2,
                 PostDetails = "Future of C# Today, C# is not only a Windows development programming language but can be used to build Web applications, " +
                 "Windows store apps, and mobile apps including iOS and Android. C# can also do more than that. If you’ve not already read my article, " +
                 "I highly recommend going and reading What C# Can Do For You.At the Build 2016 event, Microsoft made several exciting announcements and one of them was " +
                 "integrating Xamarin as a part of Visual Studio “15” and beyond. Now C# developers can build iOS and Android apps that can spit out native iOS and Android" +
                 " code....the future of C# is very bright.In the following Channel 9 video, Microsoft’s Dustin Campbell and Mads Torgersen talk about the future of C#.Here are some of the bullet points from the video: " +
                 "You can write C# in any editor you want." +
                 "C# is open source now" +
                 "C# runs on Windows, Mac, and Linux" +
                 "C# can be used to build Windows client apps, Windows Store apps, iOS apps, and Android aps and can also be used to build backend and middle-tier frameworks and libraries." +
                 "C# (via Roslyn, the C# engine):" +
                 "Supports all IDEs and editors" +
                 "All the linters and analysis tools" +
                 "All the fixing and refactoring and code generation tools" +
                 "All the scripting and all the REPLs" +
                 "C# 7 comes with new features including tuples, record types, and pattern matching." +
                 "C# is young and evolving." +
                 "Unlike other programming languages, C# is still young and evolving. Now being open sourced, C# is getting community involvement and " +
                 "new features are being decided by community." +
                 "The following table summarizes the improvements made in each newer version of the language."
             },
              new Post
              {
                  PostId = Guid.NewGuid().ToString().Substring(1, 5),
                  PostCreatorId = user3Guid,
                  PostTitle = "Seeing Sharp",
                  ApprovalState = 1,
                  LikeCount = 31,
                  CreationDate = DateTime.Now,
                  ArticleCategoryId = 2,
                  PostDetails = "It’s 2020, four years from now. The campaign is under way to succeed the president, who is retiring after a single wretched term." +
                  "Voters are angrier than ever—at politicians, at compromisers, at the establishment. Congress and the White House seem incapable of working together on anything, " +
                 "even when their interests align. With lawmaking at a standstill, the president’s use of executive orders and regulatory discretion has reached a level that Congress views" +
                 " as dictatorial—not that Congress can do anything about it, except file lawsuits that the divided Supreme Court, its three vacancies unfilled, has been unable to resolve." +
                 "On Capitol Hill, Speaker Paul Ryan resigned after proving unable to pass a budget, or much else.The House burned through two more speakers and one “acting” speaker, " +
                 "a job invented following four speakerless months.The Senate, meanwhile, is tied in knots by wannabe presidents and aspiring talk - show hosts, who use the chamber as a social - media " +
                 "platform to build their brands by obstructing—well, everything.The Defense Department is among hundreds of agencies that have not been reauthorized, the government has shut down three times," +
                 " and, yes, it finally happened: The United States briefly defaulted on the national debt, precipitating a market collapse and an economic downturn. No one wanted that outcome, " +
                 "but no one was able to prevent it." +
                 "As the presidential primaries unfold, Kanye West is leading a fractured field of Democrats. The Republican front - runner is Phil Robertson, " +
                 "of Duck Dynasty fame. Elected governor of Louisiana only a few months ago, he is promising to defy the Washington establishment by never trimming his beard" +
                 ".Party elders have given up all pretense of being more than spectators, and most of the candidates have given up all pretense of party loyalty. On the debate stages," +
                 " and everywhere else, anything goes."
              }
             );

            modelBuilder.Entity<PostActivityType>().HasData(
            new PostActivityType
            {
                PostActivityTypeId = 1,
                PostActivity = "Like",
            },
            new PostActivityType
            {
                PostActivityTypeId = 2,
                PostActivity = "Comment",
            }
            );

            modelBuilder.Entity<UserActivityType>().HasData(
            new UserActivityType
            {
                UserActivityTypeId = 1,
                ActivityTypeName = "Like"
            },
            new UserActivityType
            {
                UserActivityTypeId = 2,
                ActivityTypeName = "Comment"
            },
            new UserActivityType
            {
                UserActivityTypeId = 3,
                ActivityTypeName = "AddPost"
            },
            new UserActivityType
            {
                UserActivityTypeId = 4,
                ActivityTypeName = "ViewPost"
            },
            new UserActivityType
            {
                UserActivityTypeId = 5,
                ActivityTypeName = "EditPost"
            },
            new UserActivityType
            {
                UserActivityTypeId = 6,
                ActivityTypeName = "DeletePPost"
            },
            new UserActivityType
            {
                UserActivityTypeId = 7,
                ActivityTypeName = "DeleteComment"
            },
            new UserActivityType
            {
                UserActivityTypeId = 8,
                ActivityTypeName = "DeleteUser"
            }, 
            new UserActivityType
            {
                UserActivityTypeId = 9,
                ActivityTypeName ="Sign-Up"
            },
            new UserActivityType
            {
                UserActivityTypeId = 10,
                ActivityTypeName = "Log-in"
            },
            new UserActivityType
            {
                UserActivityTypeId = 11,
                ActivityTypeName = "Log-Out"
            }
            );
        }
    }
}
