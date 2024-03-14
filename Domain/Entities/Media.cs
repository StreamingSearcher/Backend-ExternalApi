
namespace Domain.Entities
{
    public class Media
    {
        public Guid Id { get; set; }
        public required string ImdbId { get; set; }
        public required string Title { get; set; }
        public required int Year { get; set; }
        public required TitleType Type { get; set; }
        public required Boolean Status { get; set; }
        public required string Overview { get; set; }
        public string? ImageUrl { get; set; }
        public Boolean IsPlatformLoaded { get; set; }

        public IList<MediaPlatform>? MediaPlatforms { get; set; }
        public IList<MediaGenre>? MediaGenres { get; set; }
    }
}
