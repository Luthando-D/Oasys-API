﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OaSys.API.Data;

#nullable disable

namespace OaSys.API.Migrations
{
    [DbContext(typeof(OasysDBContext))]
    [Migration("20220522194822_Supplier")]
    partial class Supplier
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OaSys.API.Models.Employee", b =>
                {
                    b.Property<int>("EMPLOYEE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EMPLOYEE_ID"), 1L, 1);

                    b.Property<string>("ADDRESS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CONTACT_NUMBER")
                        .HasColumnType("bigint");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("EMPLOYEE_ID_NUMBER")
                        .HasColumnType("bigint");

                    b.Property<int>("EMPLOYEE_STATUS_ID")
                        .HasColumnType("int");

                    b.Property<int>("EMPLOYEE_TYPE_ID")
                        .HasColumnType("int");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PROVINCE_ID")
                        .HasColumnType("int");

                    b.Property<string>("SURNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TITLE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WARNING_ID")
                        .HasColumnType("int");

                    b.HasKey("EMPLOYEE_ID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("OaSys.API.Models.Employee_Type", b =>
                {
                    b.Property<int>("EMPLOYEE_TYPE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EMPLOYEE_TYPE_ID"), 1L, 1);

                    b.Property<string>("POSITION_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("USER_ROLE_ID")
                        .HasColumnType("int");

                    b.HasKey("EMPLOYEE_TYPE_ID");

                    b.ToTable("Employee_Type");
                });

            modelBuilder.Entity("OaSys.API.Models.Rate", b =>
                {
                    b.Property<int>("RATE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RATE_ID"), 1L, 1);

                    b.Property<float>("RATE_AMOUNT")
                        .HasColumnType("real");

                    b.Property<string>("RATE_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RATE_ID");

                    b.ToTable("Rate");
                });

            modelBuilder.Entity("OaSys.API.Models.Supplier", b =>
                {
                    b.Property<int>("SUPPLIER_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SUPPLIER_ID"), 1L, 1);

                    b.Property<int>("ALT_NUMBER")
                        .HasColumnType("int");

                    b.Property<int>("CONTACT_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VAT_NUMBER")
                        .HasColumnType("int");

                    b.HasKey("SUPPLIER_ID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("OaSys.API.Models.User", b =>
                {
                    b.Property<int>("USER_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("USER_ID"), 1L, 1);

                    b.Property<int>("EMPLOYEE_ID")
                        .HasColumnType("int");

                    b.Property<string>("USERNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USER_PASSWORD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("USER_ROLE_ID")
                        .HasColumnType("int");

                    b.Property<int>("USER_STATUS_ID")
                        .HasColumnType("int");

                    b.HasKey("USER_ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("OaSys.API.Models.Warning", b =>
                {
                    b.Property<int>("WARNING_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WARNING_ID"), 1L, 1);

                    b.Property<string>("EMPLOYEE_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("REASON")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WARINING_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WARNING_TYPE_ID")
                        .HasColumnType("int");

                    b.HasKey("WARNING_ID");

                    b.ToTable("Warning");
                });

            modelBuilder.Entity("OaSys.API.Models.Warning_Type", b =>
                {
                    b.Property<int>("WARNING_TYPE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WARNING_TYPE_ID"), 1L, 1);

                    b.Property<string>("DESCRIPTION")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WARNING_TYPE_ID");

                    b.ToTable("Warning_Type");
                });
#pragma warning restore 612, 618
        }
    }
}
