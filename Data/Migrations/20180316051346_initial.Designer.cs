﻿// <auto-generated />
using HangMan.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace HangMan.Data.Migrations
{
    [DbContext(typeof(HangManContext))]
    [Migration("20180316051346_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("HangMan.Models.Words", b =>
                {
                    b.Property<int>("WordsId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Word");

                    b.HasKey("WordsId");

                    b.ToTable("Words");
                });
#pragma warning restore 612, 618
        }
    }
}
