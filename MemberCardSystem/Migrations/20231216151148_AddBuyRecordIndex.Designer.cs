﻿// <auto-generated />
using System;
using MemberCardSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MemberCardSystem.Migrations
{
    [DbContext(typeof(MemberCardContext))]
    [Migration("20231216151148_AddBuyRecordIndex")]
    partial class AddBuyRecordIndex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("MemberCardSystem.Models.BuyRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CardId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Record")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RecordTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("BuyRecords");
                });

            modelBuilder.Entity("MemberCardSystem.Models.Card", b =>
                {
                    b.Property<string>("CardId")
                        .HasColumnType("TEXT");

                    b.Property<int>("CardType")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Money")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("CardId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("MemberCardSystem.Models.Config", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.ToTable("Configs");
                });

            modelBuilder.Entity("MemberCardSystem.Models.Gift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GiftName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Gifts");
                });

            modelBuilder.Entity("MemberCardSystem.Models.OldShoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CardId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Record")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RecordTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("OldShoes");
                });
#pragma warning restore 612, 618
        }
    }
}
