﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tictactoe.Entities;

#nullable disable

namespace Tictactoe.Migrations
{
    [DbContext(typeof(GameDBcontext))]
    [Migration("20230610114008_GameDB-Init")]
    partial class GameDBInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Tictactoe.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PlayerXid")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PlayerYid")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("board")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("winner")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });
#pragma warning restore 612, 618
        }
    }
}