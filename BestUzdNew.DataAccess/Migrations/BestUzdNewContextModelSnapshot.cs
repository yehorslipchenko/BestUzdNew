﻿// <auto-generated />
using System;
using BestUzdNew.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BestUzdNew.DataAccess.Migrations
{
    [DbContext(typeof(BestUzdNewContext))]
    partial class BestUzdNewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Latin1_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BestUzdNew.Domain.Entities.DiscountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("NameAlias")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("DiscountType");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ServiceId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("NameAlias")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceDiscount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiscountTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("NameAlias")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DiscountTypeId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceDiscount");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameAlias")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("ServiceGroup");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceGroupDiscount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiscountTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("NameAlias")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ServiceGroupId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DiscountTypeId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ServiceGroupId");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceGroupDiscount");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceGroupToService", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("ServiceGroupId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ServiceGroupId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceGroupToService");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceSetDiscount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DiscountTypeId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceSetDiscount");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceSetDiscountToService", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceSetDiscountId")
                        .HasColumnType("int");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ServiceId");

                    b.HasIndex("ServiceSetDiscountId");

                    b.ToTable("ServiceSetDiscountToService");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Translation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Translation1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Translation");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("LanguageId");

                    b.ToTable("Translation");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("UserInformationId")
                        .HasColumnType("int");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("UserInformationId");

                    b.HasIndex("UserRoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.UserInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FamilyName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("UserInformation");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("NameAlias")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Order", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.Service", "Service")
                        .WithMany("Orders")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("Order_ServiceFK")
                        .IsRequired();

                    b.Navigation("Service");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceDiscount", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.DiscountType", "DiscountType")
                        .WithMany("ServiceDiscounts")
                        .HasForeignKey("DiscountTypeId")
                        .HasConstraintName("ServiceDiscount_DiscountTypeFK")
                        .IsRequired();

                    b.HasOne("BestUzdNew.Domain.Entities.Service", "Service")
                        .WithMany("ServiceDiscounts")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("ServiceDiscount_ServiceFK");

                    b.HasOne("BestUzdNew.Domain.Entities.User", "User")
                        .WithMany("ServiceDiscounts")
                        .HasForeignKey("UserId")
                        .HasConstraintName("ServiceDiscount_UserFK");

                    b.Navigation("DiscountType");

                    b.Navigation("Service");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceGroupDiscount", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.DiscountType", "DiscountType")
                        .WithMany("ServiceGroupDiscounts")
                        .HasForeignKey("DiscountTypeId")
                        .HasConstraintName("ServiceGroupDiscount_DiscountTypeFK")
                        .IsRequired();

                    b.HasOne("BestUzdNew.Domain.Entities.ServiceGroup", "ServiceGroup")
                        .WithMany("ServiceGroupDiscounts")
                        .HasForeignKey("ServiceGroupId")
                        .HasConstraintName("ServiceGroupDiscount_ServiceGroupFK");

                    b.HasOne("BestUzdNew.Domain.Entities.User", "User")
                        .WithMany("ServiceGroupDiscounts")
                        .HasForeignKey("UserId")
                        .HasConstraintName("ServiceGroupDiscount_UserFK");

                    b.Navigation("DiscountType");

                    b.Navigation("ServiceGroup");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceGroupToService", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.ServiceGroup", "ServiceGroup")
                        .WithMany()
                        .HasForeignKey("ServiceGroupId")
                        .HasConstraintName("ServiceGroupToService_ServiceGroupFK")
                        .IsRequired();

                    b.HasOne("BestUzdNew.Domain.Entities.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("ServiceGroupToService_ServiceFK")
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("ServiceGroup");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceSetDiscount", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.DiscountType", "DiscountType")
                        .WithMany("ServiceSetDiscounts")
                        .HasForeignKey("DiscountTypeId")
                        .HasConstraintName("ServiceSetDiscount_DiscountTypeFK")
                        .IsRequired();

                    b.HasOne("BestUzdNew.Domain.Entities.User", "User")
                        .WithMany("ServiceSetDiscounts")
                        .HasForeignKey("UserId")
                        .HasConstraintName("ServiceSetDiscount_UserFK");

                    b.Navigation("DiscountType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceSetDiscountToService", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("ServiceSetDiscountToService_ServiceFK")
                        .IsRequired();

                    b.HasOne("BestUzdNew.Domain.Entities.ServiceSetDiscount", "ServiceSetDiscount")
                        .WithMany()
                        .HasForeignKey("ServiceSetDiscountId")
                        .HasConstraintName("ServiceSetDiscountToService_ServiceSetDiscountFK")
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("ServiceSetDiscount");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Translation", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.Language", "Language")
                        .WithMany("Translations")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("Translation_LanguageFK")
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.User", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.UserInformation", "UserInformation")
                        .WithMany("Users")
                        .HasForeignKey("UserInformationId")
                        .HasConstraintName("User_UserInformationFK")
                        .IsRequired();

                    b.HasOne("BestUzdNew.Domain.Entities.UserRole", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleId")
                        .HasConstraintName("FK_User_UserRole")
                        .IsRequired();

                    b.Navigation("UserInformation");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.DiscountType", b =>
                {
                    b.Navigation("ServiceDiscounts");

                    b.Navigation("ServiceGroupDiscounts");

                    b.Navigation("ServiceSetDiscounts");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Language", b =>
                {
                    b.Navigation("Translations");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Service", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ServiceDiscounts");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceGroup", b =>
                {
                    b.Navigation("ServiceGroupDiscounts");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.User", b =>
                {
                    b.Navigation("ServiceDiscounts");

                    b.Navigation("ServiceGroupDiscounts");

                    b.Navigation("ServiceSetDiscounts");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.UserInformation", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
