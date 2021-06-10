﻿// <auto-generated />
using System;
using FromSqlToExcel.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FromSqlToExcel.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(FromSqlToExcelDbContext))]
    [Migration("20210610122412_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FromSqlToExcel.Domain.Models.Izdel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Izdels");
                });

            modelBuilder.Entity("FromSqlToExcel.Domain.Models.Links", b =>
                {
                    b.Property<int?>("IzdelId")
                        .HasColumnType("int");

                    b.Property<int?>("IzdelUpId")
                        .HasColumnType("int");

                    b.Property<int>("Kol")
                        .HasColumnType("int");

                    b.HasIndex("IzdelId");

                    b.HasIndex("IzdelUpId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("FromSqlToExcel.Domain.Models.Links", b =>
                {
                    b.HasOne("FromSqlToExcel.Domain.Models.Izdel", "Izdel")
                        .WithMany()
                        .HasForeignKey("IzdelId");

                    b.HasOne("FromSqlToExcel.Domain.Models.Izdel", "IzdelUp")
                        .WithMany()
                        .HasForeignKey("IzdelUpId");

                    b.Navigation("Izdel");

                    b.Navigation("IzdelUp");
                });
#pragma warning restore 612, 618
        }
    }
}
