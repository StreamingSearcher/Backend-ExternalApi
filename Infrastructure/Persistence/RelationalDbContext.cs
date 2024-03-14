
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class RelationalDbContext : DbContext
    {
        public DbSet<Media> Medias { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<MediaPlatform> MediaPlatforms { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MediaGenre> MediaGenres { get; set; }
        public DbSet<Country> Countries {  get; set; }
        public RelationalDbContext(DbContextOptions<RelationalDbContext> options) : base(options)
        {

        }

        public RelationalDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Media>(entity =>
            {
                entity.HasKey(m => m.Id);
                entity.Property(m => m.Id).ValueGeneratedOnAdd();
                entity.Property(m => m.Title).HasMaxLength(50);
                entity.Property(m => m.Overview).HasMaxLength(255);


            });

            modelBuilder.Entity<Platform>(entity =>
            {
                entity.HasKey(m => m.Id);
                entity.Property(m => m.Id).ValueGeneratedOnAdd();
                entity.Property(m => m.Name).HasMaxLength(50);
      

            });

            modelBuilder.Entity<MediaPlatform>(entity =>
            {
                entity.HasKey(mp => mp.Id);
                entity.Property(mp => mp.Id).ValueGeneratedOnAdd();

                entity.HasOne<Media>(m => m.Media)
                    .WithMany(m => m.MediaPlatforms)
                    .HasForeignKey(mp => mp.MediaId);

                entity.HasOne<Platform>(p => p.Platform)
                    .WithMany(p => p.MediaPlatforms)
                    .HasForeignKey(mp => mp.PlatformId);

                entity.HasOne<Country>(c => c.Country)
                   .WithMany(c => c.MediaPlatforms)
                   .HasForeignKey(mp => mp.CountryCode);
            });

            modelBuilder.Entity<MediaGenre>(entity =>
            {
                entity.HasKey(mg => mg.Id);
                entity.Property(mg => mg.Id).ValueGeneratedOnAdd();

                entity.HasOne<Media>(m => m.Media)
                    .WithMany(m => m.MediaGenres)
                    .HasForeignKey(mg => mg.MediaId);

                entity.HasOne<Genre>(p => p.Genre)
                    .WithMany(p => p.MediaGenres)
                    .HasForeignKey(mg => mg.GenreId);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(m => m.Code);
                entity.Property(c => c.Name).HasMaxLength(50);

            });

            //Seed Data
            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "adventure"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "fantasy"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "animation"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "drama"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "horror"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "action"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "comedy"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "history"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "western"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "thriller"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "crime"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "documentary"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "science fiction"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "mystery"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "music"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "romance"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "family"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "war"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "news"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "reality"
                });
                entity.HasData(new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "talk show"
                });


            });

            modelBuilder.Entity<Platform>(entity =>
            {

                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "disney"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "hbo"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "hotstar"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "hulu"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "iplayer"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "mubi"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "netflix"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "now"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "paramount"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "peacock"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "prime"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "stan"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "starz"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "wow"
                });


                entity.HasData(new Platform
                {
                    Id = Guid.NewGuid(),
                    Name = "zee5"
                });



            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasData(new Country
                {
                    Code = "be",
                    Name = "Belgium"
                });


                entity.HasData(new Country
                {
                    Code = "bg",
                    Name = "Bulgaria"
                });


                entity.HasData(new Country
                {
                    Code = "br",
                    Name = "Brazil"
                });


                entity.HasData(new Country
                {
                    Code = "ca",
                    Name = "Canada"
                });


                entity.HasData(new Country
                {
                    Code = "ch",
                    Name = "Switzerland"
                });


                entity.HasData(new Country
                {
                    Code = "cl",
                    Name = "Chile"
                });


                entity.HasData(new Country
                {
                    Code = "co",
                    Name = "Colombia"
                });


                entity.HasData(new Country
                {
                    Code = "cy",
                    Name = "Cyprus"
                });


                entity.HasData(new Country
                {
                    Code = "cz",
                    Name = "Czech Republic"
                });


                entity.HasData(new Country
                {
                    Code = "de",
                    Name = "Germany"
                });


                entity.HasData(new Country
                {
                    Code = "dk",
                    Name = "Denmark"
                });


                entity.HasData(new Country
                {
                    Code = "ec",
                    Name = "Ecuador"
                });


                entity.HasData(new Country
                {
                    Code = "ee",
                    Name = "Estonia"
                });


                entity.HasData(new Country
                {
                    Code = "es",
                    Name = "Spain"
                });


                entity.HasData(new Country
                {
                    Code = "fi",
                    Name = "Finland"
                });


                entity.HasData(new Country
                {
                    Code = "fr",
                    Name = "France"
                });


                entity.HasData(new Country
                {
                    Code = "gb",
                    Name = "United Kingdom"
                });


                entity.HasData(new Country
                {
                    Code = "gr",
                    Name = "Greece"
                });


                entity.HasData(new Country
                {
                    Code = "hk",
                    Name = "Hong Kong"
                });


                entity.HasData(new Country
                {
                    Code = "hr",
                    Name = "Croatia"
                });


                entity.HasData(new Country
                {
                    Code = "hu",
                    Name = "Hungary"
                });


                entity.HasData(new Country
                {
                    Code = "id",
                    Name = "Indonesia"
                });


                entity.HasData(new Country
                {
                    Code = "ie",
                    Name = "Ireland"
                });


                entity.HasData(new Country
                {
                    Code = "il",
                    Name = "Israel"
                });


                entity.HasData(new Country
                {
                    Code = "in",
                    Name = "India"
                });


                entity.HasData(new Country
                {
                    Code = "is",
                    Name = "Iceland"
                });


                entity.HasData(new Country
                {
                    Code = "it",
                    Name = "Italy"
                });


                entity.HasData(new Country
                {
                    Code = "jp",
                    Name = "Japan"
                });


                entity.HasData(new Country
                {
                    Code = "kr",
                    Name = "South Korea"
                });


                entity.HasData(new Country
                {
                    Code = "lt",
                    Name = "Lithuania"
                });


                entity.HasData(new Country
                {
                    Code = "md",
                    Name = "Moldova"
                });


                entity.HasData(new Country
                {
                    Code = "mk",
                    Name = "North Macedonia"
                });


                entity.HasData(new Country
                {
                    Code = "mx",
                    Name = "Mexico"
                });


                entity.HasData(new Country
                {
                    Code = "my",
                    Name = "Malaysia"
                });


                entity.HasData(new Country
                {
                    Code = "nl",
                    Name = "Netherlands"
                });


                entity.HasData(new Country
                {
                    Code = "no",
                    Name = "Norway"
                });


                entity.HasData(new Country
                {
                    Code = "nz",
                    Name = "New Zealand"
                });


                entity.HasData(new Country
                {
                    Code = "pa",
                    Name = "Panama"
                });


                entity.HasData(new Country
                {
                    Code = "pe",
                    Name = "Peru"
                });


                entity.HasData(new Country
                {
                    Code = "ph",
                    Name = "Philippines"
                });


                entity.HasData(new Country
                {
                    Code = "pl",
                    Name = "Poland"
                });


                entity.HasData(new Country
                {
                    Code = "pt",
                    Name = "Portugal"
                });


                entity.HasData(new Country
                {
                    Code = "ro",
                    Name = "Romania"
                });


                entity.HasData(new Country
                {
                    Code = "rs",
                    Name = "Serbia"
                });


                entity.HasData(new Country
                {
                    Code = "ru",
                    Name = "Russia"
                });


                entity.HasData(new Country
                {
                    Code = "se",
                    Name = "Sweden"
                });


                entity.HasData(new Country
                {
                    Code = "sg",
                    Name = "Singapore"
                });


                entity.HasData(new Country
                {
                    Code = "si",
                    Name = "Slovenia"
                });


                entity.HasData(new Country
                {
                    Code = "th",
                    Name = "Thailand"
                });


                entity.HasData(new Country
                {
                    Code = "tr",
                    Name = "Turkey"
                });


                entity.HasData(new Country
                {
                    Code = "ua",
                    Name = "Ukraine"
                });


                entity.HasData(new Country
                {
                    Code = "us",
                    Name = "United States"
                });


                entity.HasData(new Country
                {
                    Code = "vn",
                    Name = "Vietnam"
                });


                entity.HasData(new Country
                {
                    Code = "za",
                    Name = "South Africa"
                });

            });
        }
    }
}
