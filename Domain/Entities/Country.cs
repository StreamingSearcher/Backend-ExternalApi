namespace Domain.Entities
{

    public class Country
    {
        public required string Code { get; set; }
        public required string Name { get; set; }

        public IList<MediaPlatform>? MediaPlatforms { get; set; }
    }
}