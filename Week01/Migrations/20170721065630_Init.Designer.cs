﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Week01.Services;

namespace Week01.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20170721065630_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("Week01.Models.Data.Post", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Password");

                    b.Property<string>("Title");

                    b.Property<DateTimeOffset?>("UpdatedAt");

                    b.Property<long?>("WriterId");

                    b.Property<string>("WriterName");

                    b.HasKey("Id");

                    b.HasIndex("WriterId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Week01.Models.Data.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("NickName");

                    b.Property<string>("Password");

                    b.Property<DateTimeOffset?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Week01.Models.Data.Post", b =>
                {
                    b.HasOne("Week01.Models.Data.User", "Writer")
                        .WithMany("Posts")
                        .HasForeignKey("WriterId");
                });
        }
    }
}
