﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WelfareSurveySystem.Data;

#nullable disable

namespace WelfareSurveySystem.Data.Migrations
{
    [DbContext(typeof(WelfareSurveySystemDBContext))]
    partial class WelfareSurveySystemDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("PersonSequence");

            modelBuilder.HasSequence("WelfareFormSequence");

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Village")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresss");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"));

                    b.Property<string>("DocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int?>("TaskRequestID")
                        .HasColumnType("int");

                    b.HasKey("DocumentId");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("TaskRequestID");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourtName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCard")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeceased")
                        .HasColumnType("bit");

                    b.Property<bool>("Retired")
                        .HasColumnType("bit");

                    b.Property<string>("ServiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShekhName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SysDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeID");

                    b.HasIndex("AddressId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [PersonSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("PersonId"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("HealthStatues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCard")
                        .HasColumnType("int");

                    b.Property<bool>("IsEligibleToSharePensionAmount")
                        .HasColumnType("bit");

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.HasIndex("AddressId");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.RealEstate", b =>
                {
                    b.Property<int>("RealEstateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RealEstateId"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("OwnOrRent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RealEstateDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RealEstateNumber")
                        .HasColumnType("int");

                    b.Property<int?>("RealEstateTypeId")
                        .HasColumnType("int");

                    b.HasKey("RealEstateId");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("RealEstateTypeId");

                    b.ToTable("RealEstates");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.RealEstateType", b =>
                {
                    b.Property<int>("RealEstateTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RealEstateTypeId"));

                    b.Property<string>("RealEstateTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RealEstateTypeId");

                    b.ToTable("RealEstateTypes");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.TaskRequest", b =>
                {
                    b.Property<int>("TaskRequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskRequestID"));

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateRequested")
                        .HasColumnType("datetime2");

                    b.Property<string>("FromServiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UploadFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WelfareFormId")
                        .HasColumnType("int");

                    b.HasKey("TaskRequestID");

                    b.HasIndex("WelfareFormId");

                    b.ToTable("TaskRequests");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.TaskStatus", b =>
                {
                    b.Property<int>("TaskStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskStatusID"));

                    b.Property<string>("CompletedByServiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCompleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskRequestID")
                        .HasColumnType("int");

                    b.HasKey("TaskStatusID");

                    b.HasIndex("TaskRequestID")
                        .IsUnique();

                    b.ToTable("TaskStatuses");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.WelfareForm", b =>
                {
                    b.Property<int>("WelfareFormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [WelfareFormSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("WelfareFormId"));

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("FormName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WelfareFormId");

                    b.HasIndex("EmployeeID");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Children", b =>
                {
                    b.HasBaseType("WelfareSurveySystem.Domain.Entities.Person");

                    b.Property<int>("ChildrenId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Childrens");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Parent", b =>
                {
                    b.HasBaseType("WelfareSurveySystem.Domain.Entities.Person");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Sibling", b =>
                {
                    b.HasBaseType("WelfareSurveySystem.Domain.Entities.Person");

                    b.Property<string>("BrotherOrStepBrother")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("SiblingId")
                        .HasColumnType("int");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Siblings");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Spouse", b =>
                {
                    b.HasBaseType("WelfareSurveySystem.Domain.Entities.Person");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("SpouseId")
                        .HasColumnType("int");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Spouses");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.DeceasedForm", b =>
                {
                    b.HasBaseType("WelfareSurveySystem.Domain.Entities.WelfareForm");

                    b.Property<DateTime>("DateOfDeceased")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeceasedFormID")
                        .HasColumnType("int");

                    b.Property<string>("ReasonOfDeceased")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("DeceasedForms");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Document", b =>
                {
                    b.HasOne("WelfareSurveySystem.Domain.Entities.Employee", null)
                        .WithMany("Documents")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("WelfareSurveySystem.Domain.Entities.TaskRequest", null)
                        .WithMany("Attachments")
                        .HasForeignKey("TaskRequestID");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Employee", b =>
                {
                    b.HasOne("WelfareSurveySystem.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Person", b =>
                {
                    b.HasOne("WelfareSurveySystem.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.RealEstate", b =>
                {
                    b.HasOne("WelfareSurveySystem.Domain.Entities.Employee", null)
                        .WithMany("RealEstates")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WelfareSurveySystem.Domain.Entities.RealEstateType", "RealEstateType")
                        .WithMany()
                        .HasForeignKey("RealEstateTypeId");

                    b.Navigation("RealEstateType");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.TaskRequest", b =>
                {
                    b.HasOne("WelfareSurveySystem.Domain.Entities.WelfareForm", "WelfareForm")
                        .WithMany()
                        .HasForeignKey("WelfareFormId");

                    b.Navigation("WelfareForm");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.TaskStatus", b =>
                {
                    b.HasOne("WelfareSurveySystem.Domain.Entities.TaskRequest", null)
                        .WithOne("TaskStatus")
                        .HasForeignKey("WelfareSurveySystem.Domain.Entities.TaskStatus", "TaskRequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.WelfareForm", b =>
                {
                    b.HasOne("WelfareSurveySystem.Domain.Entities.Employee", null)
                        .WithMany("ResearchedWelfareForms")
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Children", b =>
                {
                    b.HasOne("WelfareSurveySystem.Domain.Entities.Employee", null)
                        .WithMany("Childrens")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Parent", b =>
                {
                    b.HasOne("WelfareSurveySystem.Domain.Entities.Employee", null)
                        .WithMany("Parents")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Sibling", b =>
                {
                    b.HasOne("WelfareSurveySystem.Domain.Entities.Employee", null)
                        .WithMany("Siblings")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Spouse", b =>
                {
                    b.HasOne("WelfareSurveySystem.Domain.Entities.Employee", null)
                        .WithMany("Spouses")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Childrens");

                    b.Navigation("Documents");

                    b.Navigation("Parents");

                    b.Navigation("RealEstates");

                    b.Navigation("ResearchedWelfareForms");

                    b.Navigation("Siblings");

                    b.Navigation("Spouses");
                });

            modelBuilder.Entity("WelfareSurveySystem.Domain.Entities.TaskRequest", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("TaskStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
