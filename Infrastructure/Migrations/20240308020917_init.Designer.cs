﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(RelationalDbContext))]
    [Migration("20240308020917_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Code");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Code = "be",
                            Name = "Belgium"
                        },
                        new
                        {
                            Code = "bg",
                            Name = "Bulgaria"
                        },
                        new
                        {
                            Code = "br",
                            Name = "Brazil"
                        },
                        new
                        {
                            Code = "ca",
                            Name = "Canada"
                        },
                        new
                        {
                            Code = "ch",
                            Name = "Switzerland"
                        },
                        new
                        {
                            Code = "cl",
                            Name = "Chile"
                        },
                        new
                        {
                            Code = "co",
                            Name = "Colombia"
                        },
                        new
                        {
                            Code = "cy",
                            Name = "Cyprus"
                        },
                        new
                        {
                            Code = "cz",
                            Name = "Czech Republic"
                        },
                        new
                        {
                            Code = "de",
                            Name = "Germany"
                        },
                        new
                        {
                            Code = "dk",
                            Name = "Denmark"
                        },
                        new
                        {
                            Code = "ec",
                            Name = "Ecuador"
                        },
                        new
                        {
                            Code = "ee",
                            Name = "Estonia"
                        },
                        new
                        {
                            Code = "es",
                            Name = "Spain"
                        },
                        new
                        {
                            Code = "fi",
                            Name = "Finland"
                        },
                        new
                        {
                            Code = "fr",
                            Name = "France"
                        },
                        new
                        {
                            Code = "gb",
                            Name = "United Kingdom"
                        },
                        new
                        {
                            Code = "gr",
                            Name = "Greece"
                        },
                        new
                        {
                            Code = "hk",
                            Name = "Hong Kong"
                        },
                        new
                        {
                            Code = "hr",
                            Name = "Croatia"
                        },
                        new
                        {
                            Code = "hu",
                            Name = "Hungary"
                        },
                        new
                        {
                            Code = "id",
                            Name = "Indonesia"
                        },
                        new
                        {
                            Code = "ie",
                            Name = "Ireland"
                        },
                        new
                        {
                            Code = "il",
                            Name = "Israel"
                        },
                        new
                        {
                            Code = "in",
                            Name = "India"
                        },
                        new
                        {
                            Code = "is",
                            Name = "Iceland"
                        },
                        new
                        {
                            Code = "it",
                            Name = "Italy"
                        },
                        new
                        {
                            Code = "jp",
                            Name = "Japan"
                        },
                        new
                        {
                            Code = "kr",
                            Name = "South Korea"
                        },
                        new
                        {
                            Code = "lt",
                            Name = "Lithuania"
                        },
                        new
                        {
                            Code = "md",
                            Name = "Moldova"
                        },
                        new
                        {
                            Code = "mk",
                            Name = "North Macedonia"
                        },
                        new
                        {
                            Code = "mx",
                            Name = "Mexico"
                        },
                        new
                        {
                            Code = "my",
                            Name = "Malaysia"
                        },
                        new
                        {
                            Code = "nl",
                            Name = "Netherlands"
                        },
                        new
                        {
                            Code = "no",
                            Name = "Norway"
                        },
                        new
                        {
                            Code = "nz",
                            Name = "New Zealand"
                        },
                        new
                        {
                            Code = "pa",
                            Name = "Panama"
                        },
                        new
                        {
                            Code = "pe",
                            Name = "Peru"
                        },
                        new
                        {
                            Code = "ph",
                            Name = "Philippines"
                        },
                        new
                        {
                            Code = "pl",
                            Name = "Poland"
                        },
                        new
                        {
                            Code = "pt",
                            Name = "Portugal"
                        },
                        new
                        {
                            Code = "ro",
                            Name = "Romania"
                        },
                        new
                        {
                            Code = "rs",
                            Name = "Serbia"
                        },
                        new
                        {
                            Code = "ru",
                            Name = "Russia"
                        },
                        new
                        {
                            Code = "se",
                            Name = "Sweden"
                        },
                        new
                        {
                            Code = "sg",
                            Name = "Singapore"
                        },
                        new
                        {
                            Code = "si",
                            Name = "Slovenia"
                        },
                        new
                        {
                            Code = "th",
                            Name = "Thailand"
                        },
                        new
                        {
                            Code = "tr",
                            Name = "Turkey"
                        },
                        new
                        {
                            Code = "ua",
                            Name = "Ukraine"
                        },
                        new
                        {
                            Code = "us",
                            Name = "United States"
                        },
                        new
                        {
                            Code = "vn",
                            Name = "Vietnam"
                        },
                        new
                        {
                            Code = "za",
                            Name = "South Africa"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("68486913-dfb4-4675-bf1f-33f05a0b3bbf"),
                            Name = "adventure"
                        },
                        new
                        {
                            Id = new Guid("7d02d890-1c42-4b13-a3af-878763b2d6b6"),
                            Name = "fantasy"
                        },
                        new
                        {
                            Id = new Guid("29db72e4-bfc2-4c33-8208-1ea0266b5e76"),
                            Name = "animation"
                        },
                        new
                        {
                            Id = new Guid("1a756f05-9352-4577-9f35-47426c7e6b1c"),
                            Name = "drama"
                        },
                        new
                        {
                            Id = new Guid("18540b0e-5dd0-41ac-aa8b-12a725dfccd7"),
                            Name = "horror"
                        },
                        new
                        {
                            Id = new Guid("2058753e-9650-408e-b1da-8ee327655908"),
                            Name = "action"
                        },
                        new
                        {
                            Id = new Guid("03221487-5f54-46c2-bdc2-558faa3a52c4"),
                            Name = "comedy"
                        },
                        new
                        {
                            Id = new Guid("e765e863-96ab-4aee-89e7-fa94da25be9c"),
                            Name = "history"
                        },
                        new
                        {
                            Id = new Guid("7a0980ce-2357-449b-9b3f-e7c8f47f3458"),
                            Name = "western"
                        },
                        new
                        {
                            Id = new Guid("8c4c6245-7b0c-43bd-9138-3414fc1302be"),
                            Name = "thriller"
                        },
                        new
                        {
                            Id = new Guid("7648a40b-f5d6-4388-ae58-7882d820e866"),
                            Name = "crime"
                        },
                        new
                        {
                            Id = new Guid("20132f2f-30b0-49ba-bdd6-2d7d8b0d43a6"),
                            Name = "documentary"
                        },
                        new
                        {
                            Id = new Guid("75a33af4-056a-468d-bed3-ecec3b21ab71"),
                            Name = "science fiction"
                        },
                        new
                        {
                            Id = new Guid("3e607a73-14ea-404b-bf02-2435807963cd"),
                            Name = "mystery"
                        },
                        new
                        {
                            Id = new Guid("3b21d899-6572-4b13-beff-edc701d40a6d"),
                            Name = "music"
                        },
                        new
                        {
                            Id = new Guid("51d16fb6-4867-4c9c-b83b-d93abc390160"),
                            Name = "romance"
                        },
                        new
                        {
                            Id = new Guid("96031e4e-cb17-4ad4-827b-811802e52521"),
                            Name = "family"
                        },
                        new
                        {
                            Id = new Guid("30dbeac2-074a-495e-8d6b-f9333f6e265b"),
                            Name = "war"
                        },
                        new
                        {
                            Id = new Guid("8b3d6342-df3e-4e9f-83a5-d03ee42a5ca2"),
                            Name = "news"
                        },
                        new
                        {
                            Id = new Guid("2adf17c9-1fcd-4e1d-b861-7b600b397755"),
                            Name = "reality"
                        },
                        new
                        {
                            Id = new Guid("42089d28-4fac-41d8-a531-aef638d5c094"),
                            Name = "talk show"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("ImdbId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsPlatformLoaded")
                        .HasColumnType("boolean");

                    b.Property<string>("Overview")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Medias");
                });

            modelBuilder.Entity("Domain.Entities.MediaGenre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ImdbId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MediaId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("MediaId");

                    b.ToTable("MediaGenres");
                });

            modelBuilder.Entity("Domain.Entities.MediaPlatform", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("MediaId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PlatformId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CountryCode");

                    b.HasIndex("MediaId");

                    b.HasIndex("PlatformId");

                    b.ToTable("MediaPlatforms");
                });

            modelBuilder.Entity("Domain.Entities.Platform", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b8d3decc-872c-484b-89b1-bdee9b0199fe"),
                            Name = "disney"
                        },
                        new
                        {
                            Id = new Guid("c84e4068-8a61-4e79-9ef8-3c799f351262"),
                            Name = "hbo"
                        },
                        new
                        {
                            Id = new Guid("2ba735f2-92e0-4838-8141-3c2364ff8899"),
                            Name = "hotstar"
                        },
                        new
                        {
                            Id = new Guid("ff118264-fc46-4ca8-afbe-428c02f9d34a"),
                            Name = "hulu"
                        },
                        new
                        {
                            Id = new Guid("d62e4556-5c70-4b3d-a80b-2b622bfab1cc"),
                            Name = "iplayer"
                        },
                        new
                        {
                            Id = new Guid("9a648d82-6671-4083-a45d-f183b60eaf13"),
                            Name = "mubi"
                        },
                        new
                        {
                            Id = new Guid("e62deea1-28ef-44b3-b76c-064155b35a32"),
                            Name = "netflix"
                        },
                        new
                        {
                            Id = new Guid("f2b813c3-50de-4fee-9d17-55a2adf7a0e0"),
                            Name = "now"
                        },
                        new
                        {
                            Id = new Guid("0016fc0c-9440-4167-8519-d26e44f724e9"),
                            Name = "paramount"
                        },
                        new
                        {
                            Id = new Guid("109db5a8-a147-4f78-b4ec-0a312be1a6d4"),
                            Name = "peacock"
                        },
                        new
                        {
                            Id = new Guid("5e5f997d-05e9-4949-8c35-68afd9923d14"),
                            Name = "prime"
                        },
                        new
                        {
                            Id = new Guid("205860b6-5d0c-4145-b9d1-cb54e55696ef"),
                            Name = "stan"
                        },
                        new
                        {
                            Id = new Guid("368b4669-7f9a-4dfd-9e64-68415700fe36"),
                            Name = "starz"
                        },
                        new
                        {
                            Id = new Guid("04f099df-13a8-4157-8deb-6fca0a4092be"),
                            Name = "wow"
                        },
                        new
                        {
                            Id = new Guid("25b338c1-da28-4321-a04c-c3bed509a3c8"),
                            Name = "zee5"
                        });
                });

            modelBuilder.Entity("Domain.Entities.MediaGenre", b =>
                {
                    b.HasOne("Domain.Entities.Genre", "Genre")
                        .WithMany("MediaGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Media", "Media")
                        .WithMany("MediaGenres")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Media");
                });

            modelBuilder.Entity("Domain.Entities.MediaPlatform", b =>
                {
                    b.HasOne("Domain.Entities.Country", "Country")
                        .WithMany("MediaPlatforms")
                        .HasForeignKey("CountryCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Media", "Media")
                        .WithMany("MediaPlatforms")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Platform", "Platform")
                        .WithMany("MediaPlatforms")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Media");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Navigation("MediaPlatforms");
                });

            modelBuilder.Entity("Domain.Entities.Genre", b =>
                {
                    b.Navigation("MediaGenres");
                });

            modelBuilder.Entity("Domain.Entities.Media", b =>
                {
                    b.Navigation("MediaGenres");

                    b.Navigation("MediaPlatforms");
                });

            modelBuilder.Entity("Domain.Entities.Platform", b =>
                {
                    b.Navigation("MediaPlatforms");
                });
#pragma warning restore 612, 618
        }
    }
}