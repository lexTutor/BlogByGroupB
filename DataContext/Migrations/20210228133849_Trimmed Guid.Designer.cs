﻿// <auto-generated />
using System;
using DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataContext.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20210228133849_Trimmed Guid")]
    partial class TrimmedGuid
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("KingdomBlog.Models.BlogRole", b =>
                {
                    b.Property<int>("BlogRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BlogRoleId");

                    b.ToTable("BlogRoles");

                    b.HasData(
                        new
                        {
                            BlogRoleId = 1,
                            UserRole = "Admin"
                        },
                        new
                        {
                            BlogRoleId = 2,
                            UserRole = "Pro-Editor"
                        },
                        new
                        {
                            BlogRoleId = 3,
                            UserRole = "Editor"
                        },
                        new
                        {
                            BlogRoleId = 4,
                            UserRole = "Member"
                        });
                });

            modelBuilder.Entity("KingdomBlog.Models.BlogUser", b =>
                {
                    b.Property<string>("BlogUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfilePhoto")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserRoleBlogRoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserStory")
                        .HasColumnType("TEXT");

                    b.HasKey("BlogUserId");

                    b.HasIndex("UserRoleBlogRoleId");

                    b.ToTable("BlogUser");

                    b.HasData(
                        new
                        {
                            BlogUserId = "7607f9",
                            EmailAddress = "Holyspirit@Kingdom.God",
                            FirstName = "Christ",
                            LastName = "Jesus",
                            PhoneNumber = "+2348166807840",
                            RoleId = 1,
                            UserStory = "I am the way the truth and the life"
                        },
                        new
                        {
                            BlogUserId = "5c38f2",
                            EmailAddress = "Peter@decagon.dev",
                            FirstName = "Peter",
                            LastName = "",
                            PhoneNumber = "+2348123456789",
                            RoleId = 2,
                            UserStory = ""
                        },
                        new
                        {
                            BlogUserId = "fdb0fa",
                            EmailAddress = "chukwuemekaokereke@decagon.dev",
                            FirstName = "Chukwuemeka",
                            LastName = "Okereke",
                            PhoneNumber = "+2348168360932",
                            RoleId = 2,
                            UserStory = ""
                        },
                        new
                        {
                            BlogUserId = "8a003d",
                            EmailAddress = "Chibuikemakapakar@decagon.dev",
                            FirstName = "Chibuikem",
                            LastName = "Akpaka",
                            PhoneNumber = "+2348166807840",
                            RoleId = 2,
                            UserStory = "Do not be decieved, Love is not blind, it just makes you close your eyes"
                        });
                });

            modelBuilder.Entity("KingdomBlog.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Christianity"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Technology"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "LifeStyle"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Food"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Social"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Architecture"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Adventure"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Politics"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Health"
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryName = "General"
                        });
                });

            modelBuilder.Entity("KingdomBlog.Models.Post", b =>
                {
                    b.Property<string>("PostId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ApprovalState")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArticleCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("LikeCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Picture")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostCreatorBlogUserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("PostCreatorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PostDetails")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostTitle")
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.HasIndex("PostCreatorBlogUserId");

                    b.ToTable("Post");

                    b.HasData(
                        new
                        {
                            PostId = "16ac8",
                            ApprovalState = 1,
                            ArticleCategoryId = 1,
                            CreationDate = new DateTime(2021, 2, 28, 14, 38, 48, 23, DateTimeKind.Local).AddTicks(4459),
                            LikeCount = 33,
                            PostCreatorId = 1,
                            PostDetails = "I remember a conversation during college in which a friend confessed to me that he did not think it was necessary, or even possible, for a believer to gain assurance of their salvation. I was surprised by his comments, especially because we were attending a Christian college that emphasized all the biblical truths related to assurance of salvation: election, grace, faith, repentance, substitutionary atonement, the fully deity and humanity of Christ, and eternal security.As it turns out,this was not an isolated incident.Over the past several years as I’ve wrestled personally with the issue of assurance and had opportunity to speak to others about it,I’ve found that many Christians do not rightly understand the biblical basis or importance of this doctrine.Assurance is essential to genuine Christianity and central to the New Testament’s theological framework, yet plenty of Christians are content to walk through life without the sure knowledge that they belong to Christ.There are, of course, those who claim assurance who have no right to do so; but it seems that there are an equal number of professing Christians who have either resigned to the fact they will never have assurance or that they don’t really need it.",
                            PostTitle = "Salvation"
                        },
                        new
                        {
                            PostId = "b1a3f",
                            ApprovalState = 1,
                            ArticleCategoryId = 2,
                            CreationDate = new DateTime(2021, 2, 28, 14, 38, 48, 23, DateTimeKind.Local).AddTicks(8203),
                            LikeCount = 31,
                            PostCreatorId = 2,
                            PostDetails = "Future of C# Today, C# is not only a Windows development programming language but can be used to build Web applications, Windows store apps, and mobile apps including iOS and Android. C# can also do more than that. If you’ve not already read my article, I highly recommend going and reading What C# Can Do For You.At the Build 2016 event, Microsoft made several exciting announcements and one of them was integrating Xamarin as a part of Visual Studio “15” and beyond. Now C# developers can build iOS and Android apps that can spit out native iOS and Android code....the future of C# is very bright.In the following Channel 9 video, Microsoft’s Dustin Campbell and Mads Torgersen talk about the future of C#.Here are some of the bullet points from the video: You can write C# in any editor you want.C# is open source nowC# runs on Windows, Mac, and LinuxC# can be used to build Windows client apps, Windows Store apps, iOS apps, and Android aps and can also be used to build backend and middle-tier frameworks and libraries.C# (via Roslyn, the C# engine):Supports all IDEs and editorsAll the linters and analysis toolsAll the fixing and refactoring and code generation toolsAll the scripting and all the REPLsC# 7 comes with new features including tuples, record types, and pattern matching.C# is young and evolving.Unlike other programming languages, C# is still young and evolving. Now being open sourced, C# is getting community involvement and new features are being decided by community.The following table summarizes the improvements made in each newer version of the language.",
                            PostTitle = "Seeing Sharp"
                        },
                        new
                        {
                            PostId = "f1438",
                            ApprovalState = 1,
                            ArticleCategoryId = 2,
                            CreationDate = new DateTime(2021, 2, 28, 14, 38, 48, 23, DateTimeKind.Local).AddTicks(8833),
                            LikeCount = 31,
                            PostCreatorId = 2,
                            PostDetails = "It’s 2020, four years from now. The campaign is under way to succeed the president, who is retiring after a single wretched term.Voters are angrier than ever—at politicians, at compromisers, at the establishment. Congress and the White House seem incapable of working together on anything, even when their interests align. With lawmaking at a standstill, the president’s use of executive orders and regulatory discretion has reached a level that Congress views as dictatorial—not that Congress can do anything about it, except file lawsuits that the divided Supreme Court, its three vacancies unfilled, has been unable to resolve.On Capitol Hill, Speaker Paul Ryan resigned after proving unable to pass a budget, or much else.The House burned through two more speakers and one “acting” speaker, a job invented following four speakerless months.The Senate, meanwhile, is tied in knots by wannabe presidents and aspiring talk - show hosts, who use the chamber as a social - media platform to build their brands by obstructing—well, everything.The Defense Department is among hundreds of agencies that have not been reauthorized, the government has shut down three times, and, yes, it finally happened: The United States briefly defaulted on the national debt, precipitating a market collapse and an economic downturn. No one wanted that outcome, but no one was able to prevent it.As the presidential primaries unfold, Kanye West is leading a fractured field of Democrats. The Republican front - runner is Phil Robertson, of Duck Dynasty fame. Elected governor of Louisiana only a few months ago, he is promising to defy the Washington establishment by never trimming his beard.Party elders have given up all pretense of being more than spectators, and most of the candidates have given up all pretense of party loyalty. On the debate stages, and everywhere else, anything goes.",
                            PostTitle = "Seeing Sharp"
                        });
                });

            modelBuilder.Entity("KingdomBlog.Models.PostActivity", b =>
                {
                    b.Property<int>("PostActivityiD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ActivityTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("PostActivityTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PostComment")
                        .HasColumnType("TEXT");

                    b.Property<int>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PostId1")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserFullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PostActivityiD");

                    b.HasIndex("PostActivityTypeId");

                    b.HasIndex("PostId1");

                    b.ToTable("PostActivities");
                });

            modelBuilder.Entity("KingdomBlog.Models.PostActivityType", b =>
                {
                    b.Property<int>("PostActivityTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PostActivity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PostActivityTypeId");

                    b.ToTable("PostActivityTypes");

                    b.HasData(
                        new
                        {
                            PostActivityTypeId = 1,
                            PostActivity = "Like"
                        },
                        new
                        {
                            PostActivityTypeId = 2,
                            PostActivity = "Comment"
                        });
                });

            modelBuilder.Entity("KingdomBlog.Models.PostCategories", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PostId1")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId", "PostId");

                    b.HasIndex("PostId1");

                    b.ToTable("PostCategories");
                });

            modelBuilder.Entity("KingdomBlog.Models.UserActivity", b =>
                {
                    b.Property<int>("UserActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActivityTypeUserActivityTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeletedUserDetails")
                        .HasColumnType("TEXT");

                    b.Property<int>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PostId1")
                        .HasColumnType("TEXT");

                    b.HasKey("UserActivityId");

                    b.HasIndex("ActivityTypeUserActivityTypeId");

                    b.HasIndex("BlogUserId");

                    b.HasIndex("PostId1");

                    b.ToTable("UserActivities");
                });

            modelBuilder.Entity("KingdomBlog.Models.UserActivityType", b =>
                {
                    b.Property<int>("UserActivityTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ActivityTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserActivityTypeId");

                    b.ToTable("UserActivityTypes");

                    b.HasData(
                        new
                        {
                            UserActivityTypeId = 1,
                            ActivityTypeName = "Like"
                        },
                        new
                        {
                            UserActivityTypeId = 2,
                            ActivityTypeName = "Comment"
                        },
                        new
                        {
                            UserActivityTypeId = 3,
                            ActivityTypeName = "AddPost"
                        },
                        new
                        {
                            UserActivityTypeId = 4,
                            ActivityTypeName = "ViewPost"
                        },
                        new
                        {
                            UserActivityTypeId = 5,
                            ActivityTypeName = "EditPost"
                        },
                        new
                        {
                            UserActivityTypeId = 6,
                            ActivityTypeName = "DeletePPost"
                        },
                        new
                        {
                            UserActivityTypeId = 7,
                            ActivityTypeName = "DeleteComment"
                        },
                        new
                        {
                            UserActivityTypeId = 8,
                            ActivityTypeName = "DeleteUser"
                        },
                        new
                        {
                            UserActivityTypeId = 9,
                            ActivityTypeName = "Sign-Up"
                        },
                        new
                        {
                            UserActivityTypeId = 10,
                            ActivityTypeName = "Log-in"
                        },
                        new
                        {
                            UserActivityTypeId = 11,
                            ActivityTypeName = "Log-Out"
                        });
                });

            modelBuilder.Entity("KingdomBlog.Models.BlogUser", b =>
                {
                    b.HasOne("KingdomBlog.Models.BlogRole", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleBlogRoleId");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("KingdomBlog.Models.Post", b =>
                {
                    b.HasOne("KingdomBlog.Models.BlogUser", "PostCreator")
                        .WithMany("Posts")
                        .HasForeignKey("PostCreatorBlogUserId");

                    b.Navigation("PostCreator");
                });

            modelBuilder.Entity("KingdomBlog.Models.PostActivity", b =>
                {
                    b.HasOne("KingdomBlog.Models.PostActivityType", "PostActivityType")
                        .WithMany("PostActivities")
                        .HasForeignKey("PostActivityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KingdomBlog.Models.Post", "Post")
                        .WithMany("PostActivities")
                        .HasForeignKey("PostId1");

                    b.Navigation("Post");

                    b.Navigation("PostActivityType");
                });

            modelBuilder.Entity("KingdomBlog.Models.PostCategories", b =>
                {
                    b.HasOne("KingdomBlog.Models.Category", "Category")
                        .WithMany("PostCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KingdomBlog.Models.Post", "Post")
                        .WithMany("PostCategories")
                        .HasForeignKey("PostId1");

                    b.Navigation("Category");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("KingdomBlog.Models.UserActivity", b =>
                {
                    b.HasOne("KingdomBlog.Models.UserActivityType", "ActivityType")
                        .WithMany("UserActivities")
                        .HasForeignKey("ActivityTypeUserActivityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KingdomBlog.Models.BlogUser", null)
                        .WithMany("UserActivity")
                        .HasForeignKey("BlogUserId");

                    b.HasOne("KingdomBlog.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId1");

                    b.Navigation("ActivityType");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("KingdomBlog.Models.BlogRole", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("KingdomBlog.Models.BlogUser", b =>
                {
                    b.Navigation("Posts");

                    b.Navigation("UserActivity");
                });

            modelBuilder.Entity("KingdomBlog.Models.Category", b =>
                {
                    b.Navigation("PostCategories");
                });

            modelBuilder.Entity("KingdomBlog.Models.Post", b =>
                {
                    b.Navigation("PostActivities");

                    b.Navigation("PostCategories");
                });

            modelBuilder.Entity("KingdomBlog.Models.PostActivityType", b =>
                {
                    b.Navigation("PostActivities");
                });

            modelBuilder.Entity("KingdomBlog.Models.UserActivityType", b =>
                {
                    b.Navigation("UserActivities");
                });
#pragma warning restore 612, 618
        }
    }
}
