
namespace Domain.Entities
{
    public class Platform
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public IList<MediaPlatform>? MediaPlatforms { get; set; }
    }
}


