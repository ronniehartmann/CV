﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(CvContext))]
    [Migration("20240619215849_AddSettingShowVersion")]
    partial class AddSettingShowVersion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Content", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Key");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Key = "PROFILE_FULLNAME",
                            Value = "Max Mustermann"
                        },
                        new
                        {
                            Key = "PROFILE_EMPLOYMENT",
                            Value = "Applikationsentwickler"
                        },
                        new
                        {
                            Key = "ABOUT_TEXT",
                            Value = "Hello!"
                        },
                        new
                        {
                            Key = "ABOUT_BIRTHDATE",
                            Value = "25/10/2004"
                        },
                        new
                        {
                            Key = "ABOUT_EMAIL",
                            Value = "max@ronniehartmann.ch"
                        },
                        new
                        {
                            Key = "ABOUT_EMAIL_LINK",
                            Value = "mailto:max@ronniehartmann.ch"
                        },
                        new
                        {
                            Key = "ABOUT_PHONE",
                            Value = "012 345 67 89"
                        },
                        new
                        {
                            Key = "ABOUT_PHONE_LINK",
                            Value = "tel:0123456789"
                        },
                        new
                        {
                            Key = "ABOUT_GITHUB",
                            Value = "ronniehartmann"
                        },
                        new
                        {
                            Key = "ABOUT_GITHUB_LINK",
                            Value = "https://github.com/ronniehartmann"
                        },
                        new
                        {
                            Key = "ABOUT_RESIDENCE",
                            Value = "9999 Musterstadt, Switzerland"
                        });
                });

            modelBuilder.Entity("Domain.Models.Education", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            School = "BMS Zürich",
                            StartDate = new DateOnly(2020, 8, 1),
                            Title = "Technische Maturität"
                        });
                });

            modelBuilder.Entity("Domain.Models.Experience", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("CompanyLink")
                        .HasColumnType("longtext");

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Text")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Company = "Contoso",
                            StartDate = new DateOnly(2020, 8, 1),
                            Text = "Hello!"
                        },
                        new
                        {
                            Id = 2L,
                            Company = "Musterfirma",
                            EndDate = new DateOnly(2020, 7, 31),
                            StartDate = new DateOnly(2016, 1, 1),
                            Text = "Hey"
                        });
                });

            modelBuilder.Entity("Domain.Models.Hobby", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Icon")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Hobbies");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Icon = "skateboarding",
                            Text = "Skating"
                        },
                        new
                        {
                            Id = 2L,
                            Icon = "code",
                            Text = "Coding"
                        });
                });

            modelBuilder.Entity("Domain.Models.Reference", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Employment")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("References");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Employment = "Applikationsentwickler",
                            Text = "Hey!",
                            Title = "Max Mustermann"
                        });
                });

            modelBuilder.Entity("Domain.Models.Settings", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("BackgroundImageFileName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PortraitImageFileName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("ShowFooter")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ShowPoweredByNetCv")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ShowVersion")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            BackgroundImageFileName = "profile-background.jpg",
                            PortraitImageFileName = "portrait.jpg",
                            ShowFooter = false,
                            ShowPoweredByNetCv = true,
                            ShowVersion = true
                        });
                });

            modelBuilder.Entity("Domain.Models.Skill", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Skills", t =>
                        {
                            t.HasCheckConstraint("CK_Skill_Level", "'Level' >= 0 AND 'Level' <= 100");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Level = 80,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2L,
                            Level = 50,
                            Name = "Java"
                        },
                        new
                        {
                            Id = 3L,
                            Level = 70,
                            Name = ".NET Framework"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}