﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TotoStatistics.Data;

namespace TotoStatistics.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TotoStatistics.Models.FiveOutOfTthirty_five", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Draw")
                        .HasColumnType("int");

                    b.Property<int>("Eight")
                        .HasColumnType("int");

                    b.Property<int>("Eighteen")
                        .HasColumnType("int");

                    b.Property<int>("Eleven")
                        .HasColumnType("int");

                    b.Property<int>("Fifteen")
                        .HasColumnType("int");

                    b.Property<int>("Five")
                        .HasColumnType("int");

                    b.Property<int>("Four")
                        .HasColumnType("int");

                    b.Property<int>("Fourteen")
                        .HasColumnType("int");

                    b.Property<int>("Nine")
                        .HasColumnType("int");

                    b.Property<int>("Nineteen")
                        .HasColumnType("int");

                    b.Property<int>("One")
                        .HasColumnType("int");

                    b.Property<int>("Seven")
                        .HasColumnType("int");

                    b.Property<int>("Seventeen")
                        .HasColumnType("int");

                    b.Property<int>("Six")
                        .HasColumnType("int");

                    b.Property<int>("Sixteen")
                        .HasColumnType("int");

                    b.Property<int>("Ten")
                        .HasColumnType("int");

                    b.Property<int>("Thirteen")
                        .HasColumnType("int");

                    b.Property<int>("Thirty")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_five")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_four")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_one")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_three")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_two")
                        .HasColumnType("int");

                    b.Property<int>("Three")
                        .HasColumnType("int");

                    b.Property<int>("Twelve")
                        .HasColumnType("int");

                    b.Property<int>("Twenty")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_eight")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_five")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_four")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_nine")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_one")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_seventwo")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_six")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_three")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_two")
                        .HasColumnType("int");

                    b.Property<int>("Two")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FiveOutOfTthirtyFive");
                });

            modelBuilder.Entity("TotoStatistics.Models.SixOutOfForty_nine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Draw")
                        .HasColumnType("int");

                    b.Property<int>("Eight")
                        .HasColumnType("int");

                    b.Property<int>("Eighteen")
                        .HasColumnType("int");

                    b.Property<int>("Eleven")
                        .HasColumnType("int");

                    b.Property<int>("Fifteen")
                        .HasColumnType("int");

                    b.Property<int>("Five")
                        .HasColumnType("int");

                    b.Property<int>("Forty")
                        .HasColumnType("int");

                    b.Property<int>("Forty_eight")
                        .HasColumnType("int");

                    b.Property<int>("Forty_five")
                        .HasColumnType("int");

                    b.Property<int>("Forty_four")
                        .HasColumnType("int");

                    b.Property<int>("Forty_nine")
                        .HasColumnType("int");

                    b.Property<int>("Forty_one")
                        .HasColumnType("int");

                    b.Property<int>("Forty_seventwo")
                        .HasColumnType("int");

                    b.Property<int>("Forty_six")
                        .HasColumnType("int");

                    b.Property<int>("Forty_three")
                        .HasColumnType("int");

                    b.Property<int>("Forty_two")
                        .HasColumnType("int");

                    b.Property<int>("Four")
                        .HasColumnType("int");

                    b.Property<int>("Fourteen")
                        .HasColumnType("int");

                    b.Property<int>("Nine")
                        .HasColumnType("int");

                    b.Property<int>("Nineteen")
                        .HasColumnType("int");

                    b.Property<int>("One")
                        .HasColumnType("int");

                    b.Property<int>("Seven")
                        .HasColumnType("int");

                    b.Property<int>("Seventeen")
                        .HasColumnType("int");

                    b.Property<int>("Six")
                        .HasColumnType("int");

                    b.Property<int>("Sixteen")
                        .HasColumnType("int");

                    b.Property<int>("Ten")
                        .HasColumnType("int");

                    b.Property<int>("Thirteen")
                        .HasColumnType("int");

                    b.Property<int>("Thirty")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_eight")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_five")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_four")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_nine")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_one")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_seventwo")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_six")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_three")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_two")
                        .HasColumnType("int");

                    b.Property<int>("Three")
                        .HasColumnType("int");

                    b.Property<int>("Twelve")
                        .HasColumnType("int");

                    b.Property<int>("Twenty")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_eight")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_five")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_four")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_nine")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_one")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_seventwo")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_six")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_three")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_two")
                        .HasColumnType("int");

                    b.Property<int>("Two")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SixOutOfFortyNine");
                });

            modelBuilder.Entity("TotoStatistics.Models.SixOutOfForty_two", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Draw")
                        .HasColumnType("int");

                    b.Property<int>("Eight")
                        .HasColumnType("int");

                    b.Property<int>("Eighteen")
                        .HasColumnType("int");

                    b.Property<int>("Eleven")
                        .HasColumnType("int");

                    b.Property<int>("Fifteen")
                        .HasColumnType("int");

                    b.Property<int>("Five")
                        .HasColumnType("int");

                    b.Property<int>("Forty")
                        .HasColumnType("int");

                    b.Property<int>("Forty_one")
                        .HasColumnType("int");

                    b.Property<int>("Forty_two")
                        .HasColumnType("int");

                    b.Property<int>("Four")
                        .HasColumnType("int");

                    b.Property<int>("Fourteen")
                        .HasColumnType("int");

                    b.Property<int>("Nine")
                        .HasColumnType("int");

                    b.Property<int>("Nineteen")
                        .HasColumnType("int");

                    b.Property<int>("One")
                        .HasColumnType("int");

                    b.Property<int>("Seven")
                        .HasColumnType("int");

                    b.Property<int>("Seventeen")
                        .HasColumnType("int");

                    b.Property<int>("Six")
                        .HasColumnType("int");

                    b.Property<int>("Sixteen")
                        .HasColumnType("int");

                    b.Property<int>("Ten")
                        .HasColumnType("int");

                    b.Property<int>("Thirteen")
                        .HasColumnType("int");

                    b.Property<int>("Thirty")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_eight")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_five")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_four")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_nine")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_one")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_seventwo")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_six")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_three")
                        .HasColumnType("int");

                    b.Property<int>("Thirty_two")
                        .HasColumnType("int");

                    b.Property<int>("Three")
                        .HasColumnType("int");

                    b.Property<int>("Twelve")
                        .HasColumnType("int");

                    b.Property<int>("Twenty")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_eight")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_five")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_four")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_nine")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_one")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_seventwo")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_six")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_three")
                        .HasColumnType("int");

                    b.Property<int>("Twenty_two")
                        .HasColumnType("int");

                    b.Property<int>("Two")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SixOutOfFortyTwo");
                });

            modelBuilder.Entity("TotoStatistics.Models.Statistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AverageSumOfNumber")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ChangeOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Isdelete")
                        .HasColumnType("bit");

                    b.Property<string>("PopularNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SumOfBonusEdition")
                        .HasColumnType("int");

                    b.Property<int>("SumOfFirstEdition")
                        .HasColumnType("int");

                    b.Property<int>("SumOfNumber")
                        .HasColumnType("int");

                    b.Property<int>("SumOfSecandEdition")
                        .HasColumnType("int");

                    b.Property<string>("UnpopularNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("TotoStatistics.Models.Toto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChangeOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DownloadedNumbers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Draw")
                        .HasColumnType("int");

                    b.Property<int>("Edition")
                        .HasColumnType("int");

                    b.Property<bool>("Isdelete")
                        .HasColumnType("bit");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Toto");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
