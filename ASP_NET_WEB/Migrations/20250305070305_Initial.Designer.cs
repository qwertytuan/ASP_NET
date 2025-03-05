﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP_NET_WEB.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250305070305_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ASP_NET_WEB.Models.tblMenu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MenuID"));

                    b.Property<string>("ActionName")
                        .HasColumnType("longtext");

                    b.Property<string>("ControllerName")
                        .HasColumnType("longtext");

                    b.Property<string>("IsActive")
                        .HasColumnType("longtext");

                    b.Property<int>("Levels")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("longtext");

                    b.Property<string>("MenuName")
                        .HasColumnType("longtext");

                    b.Property<int>("MenuOrder")
                        .HasColumnType("int");

                    b.Property<int>("ParentID")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("MenuID");

                    b.ToTable("tblMenu");
                });
#pragma warning restore 612, 618
        }
    }
}
