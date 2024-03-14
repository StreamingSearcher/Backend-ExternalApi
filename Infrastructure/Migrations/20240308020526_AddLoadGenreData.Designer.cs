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
    [Migration("20240308020526_AddLoadGenreData")]
    partial class AddLoadGenreData
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
                            Id = new Guid("3d246efc-86d5-4db7-b78d-75113d65e463"),
                            Name = "adventure"
                        },
                        new
                        {
                            Id = new Guid("a5446d78-9969-420a-8310-940b3cb2b4ca"),
                            Name = "fantasy"
                        },
                        new
                        {
                            Id = new Guid("c401d5a2-a8d0-48c0-8411-961c4c4f0761"),
                            Name = "animation"
                        },
                        new
                        {
                            Id = new Guid("4e914224-650c-4e4b-a8bb-668bcfae0000"),
                            Name = "drama"
                        },
                        new
                        {
                            Id = new Guid("8d16fc36-7140-4f93-80c3-9c49158215cf"),
                            Name = "horror"
                        },
                        new
                        {
                            Id = new Guid("e6ed0877-4131-4eae-8912-62a77e05e9ca"),
                            Name = "action"
                        },
                        new
                        {
                            Id = new Guid("024e57b5-fddc-4f77-9321-b67f937f19bc"),
                            Name = "comedy"
                        },
                        new
                        {
                            Id = new Guid("d8cce0a8-a20d-4b3e-922c-3238b0472122"),
                            Name = "history"
                        },
                        new
                        {
                            Id = new Guid("a0ddc010-69de-4b8d-a1bf-9a80a84f52eb"),
                            Name = "western"
                        },
                        new
                        {
                            Id = new Guid("abe981a4-3a10-46fb-9421-b678608c9d35"),
                            Name = "thriller"
                        },
                        new
                        {
                            Id = new Guid("08e6138a-52f1-43a3-856c-23f58ed6bfd3"),
                            Name = "crime"
                        },
                        new
                        {
                            Id = new Guid("af7e174c-b96e-4276-ab6f-f663806a91b6"),
                            Name = "documentary"
                        },
                        new
                        {
                            Id = new Guid("6e96bc54-965c-4e63-ba6a-7b5ed6c210e5"),
                            Name = "science fiction"
                        },
                        new
                        {
                            Id = new Guid("370029c8-01a9-42e0-a0ed-b283c429c7ec"),
                            Name = "mystery"
                        },
                        new
                        {
                            Id = new Guid("6116a999-808a-4ba7-867c-2b20018d4111"),
                            Name = "music"
                        },
                        new
                        {
                            Id = new Guid("ccb5f3fc-6523-417b-98ba-613be7184729"),
                            Name = "romance"
                        },
                        new
                        {
                            Id = new Guid("12afa0a9-cc90-413d-969e-dcf7ad5aff23"),
                            Name = "family"
                        },
                        new
                        {
                            Id = new Guid("af69bf4d-d807-4ef2-aea1-13b7e75ce0ae"),
                            Name = "war"
                        },
                        new
                        {
                            Id = new Guid("f177c75f-5107-48c8-83b2-089fa2daab09"),
                            Name = "news"
                        },
                        new
                        {
                            Id = new Guid("e95b7824-dd73-4611-b963-5f1f585a4b0f"),
                            Name = "reality"
                        },
                        new
                        {
                            Id = new Guid("1203b8ef-2903-47c1-81b4-69c75912ea3e"),
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
                            Id = new Guid("368fc032-f553-494d-a260-e4d50b5eb15f"),
                            Name = "disney"
                        },
                        new
                        {
                            Id = new Guid("d68930d2-b922-4aa9-8916-804a36b7352d"),
                            Name = "hbo"
                        },
                        new
                        {
                            Id = new Guid("79bd47da-39de-43bf-be7f-6b7f1cfa66dd"),
                            Name = "hotstar"
                        },
                        new
                        {
                            Id = new Guid("6db4cee2-fc9c-4e7c-8351-ce0d38a65972"),
                            Name = "hulu"
                        },
                        new
                        {
                            Id = new Guid("821b992e-0484-4394-8fee-5dc021073698"),
                            Name = "iplayer"
                        },
                        new
                        {
                            Id = new Guid("854edcdb-e33c-4838-af6c-6fc5bde2064c"),
                            Name = "mubi"
                        },
                        new
                        {
                            Id = new Guid("75f738af-99f3-4e6e-83f5-83218127b351"),
                            Name = "netflix"
                        },
                        new
                        {
                            Id = new Guid("d8402061-928e-4849-890a-674801c7080b"),
                            Name = "now"
                        },
                        new
                        {
                            Id = new Guid("637263a0-dbfc-4072-9857-5886bef7465d"),
                            Name = "paramount"
                        },
                        new
                        {
                            Id = new Guid("554f22f0-a4bf-474c-89ab-c8756ab3ec21"),
                            Name = "peacock"
                        },
                        new
                        {
                            Id = new Guid("f90e3a5e-8f10-42f7-a78e-9ba3dd5949fc"),
                            Name = "prime"
                        },
                        new
                        {
                            Id = new Guid("e2a78b5a-c1ce-4911-81ac-41922166656e"),
                            Name = "stan"
                        },
                        new
                        {
                            Id = new Guid("f2c87527-15e9-45b0-a736-ed8c2c41df34"),
                            Name = "starz"
                        },
                        new
                        {
                            Id = new Guid("690cadd8-d2f7-4cd0-88cb-c04473ce6c59"),
                            Name = "wow"
                        },
                        new
                        {
                            Id = new Guid("de498e77-4d56-45d7-8098-60bb563e28da"),
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