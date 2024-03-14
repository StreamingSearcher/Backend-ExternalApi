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
    [Migration("20240308005626_ChangeUUIDtoString")]
    partial class ChangeUUIDtoString
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
                            Id = new Guid("8fb34070-0b5d-4430-80f1-c21befff3e8b"),
                            Name = "adventure"
                        },
                        new
                        {
                            Id = new Guid("f1c7537d-5565-4fa9-8627-5c54c8d25abf"),
                            Name = "fantasy"
                        },
                        new
                        {
                            Id = new Guid("c1fe2607-0779-47d5-a917-35c10721a032"),
                            Name = "animation"
                        },
                        new
                        {
                            Id = new Guid("4106adc9-1a7f-497e-897a-8a446aec7746"),
                            Name = "drama"
                        },
                        new
                        {
                            Id = new Guid("036abcae-fac8-46c4-b271-22e935e693f4"),
                            Name = "horror"
                        },
                        new
                        {
                            Id = new Guid("75e59d56-62d0-4ded-8c9b-5b8b1de6771d"),
                            Name = "action"
                        },
                        new
                        {
                            Id = new Guid("16e95309-2eb4-497e-b1e6-69f38656a8ea"),
                            Name = "comedy"
                        },
                        new
                        {
                            Id = new Guid("d8565381-4de0-42fe-9d9b-306ab1493273"),
                            Name = "history"
                        },
                        new
                        {
                            Id = new Guid("713cc2a4-d9bd-4665-9fe4-ec2f62bd464e"),
                            Name = "western"
                        },
                        new
                        {
                            Id = new Guid("5b3d03ac-4da7-4e69-b45e-7c774a2950dd"),
                            Name = "thriller"
                        },
                        new
                        {
                            Id = new Guid("fac2f3f5-3e24-47fb-b1f4-69a40a275471"),
                            Name = "crime"
                        },
                        new
                        {
                            Id = new Guid("acc90a6b-40c1-4e3e-b70f-804a4ea2a6f2"),
                            Name = "documentary"
                        },
                        new
                        {
                            Id = new Guid("92ae7773-9b74-4efe-9626-f2008eac10cf"),
                            Name = "science fiction"
                        },
                        new
                        {
                            Id = new Guid("7d2750af-db2f-4043-944d-8f2b23919ad2"),
                            Name = "mystery"
                        },
                        new
                        {
                            Id = new Guid("f0c39dcb-a5fa-4ae6-ad46-e6ce32115ba7"),
                            Name = "music"
                        },
                        new
                        {
                            Id = new Guid("e441d708-8ba1-46ca-83a4-b9baa31f5d05"),
                            Name = "romance"
                        },
                        new
                        {
                            Id = new Guid("75023c65-7346-4aaf-91e9-52f1827e48fa"),
                            Name = "family"
                        },
                        new
                        {
                            Id = new Guid("ad9816ae-28aa-4787-9e72-442023acb8af"),
                            Name = "war"
                        },
                        new
                        {
                            Id = new Guid("d5cb64b9-60bf-4c1d-a7aa-feeff5ca113e"),
                            Name = "news"
                        },
                        new
                        {
                            Id = new Guid("731fb28a-5778-4a1c-a0f7-27ed13d4082f"),
                            Name = "reality"
                        },
                        new
                        {
                            Id = new Guid("1e62bbe3-d573-4b38-8872-dde0f7b42cf9"),
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

                    b.Property<string>("ImdbId")
                        .IsRequired()
                        .HasColumnType("text");

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

                    b.Property<string>("PlatformId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CountryCode");

                    b.HasIndex("MediaId");

                    b.HasIndex("PlatformId");

                    b.ToTable("MediaPlatforms");
                });

            modelBuilder.Entity("Domain.Entities.Platform", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = "disney",
                            Name = "Disney"
                        },
                        new
                        {
                            Id = "hbo",
                            Name = "Hbo"
                        },
                        new
                        {
                            Id = "hotstar",
                            Name = "Hotstar"
                        },
                        new
                        {
                            Id = "hulu",
                            Name = "Hulu"
                        },
                        new
                        {
                            Id = "iplayer",
                            Name = "Iplayer"
                        },
                        new
                        {
                            Id = "mubi",
                            Name = "Mubi"
                        },
                        new
                        {
                            Id = "netflix",
                            Name = "Netflix"
                        },
                        new
                        {
                            Id = "now",
                            Name = "Now"
                        },
                        new
                        {
                            Id = "paramount",
                            Name = "Paramount"
                        },
                        new
                        {
                            Id = "peacock",
                            Name = "Peacock"
                        },
                        new
                        {
                            Id = "prime",
                            Name = "Prime"
                        },
                        new
                        {
                            Id = "stan",
                            Name = "Stan"
                        },
                        new
                        {
                            Id = "starz",
                            Name = "Starz"
                        },
                        new
                        {
                            Id = "wow",
                            Name = "Wow"
                        },
                        new
                        {
                            Id = "zee5",
                            Name = "Zee5"
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
