
namespace Domain.Entities
{
    public class MediaPlatform
    {
        public Guid Id { get; set; }
        public Guid MediaId { get; set; }
        public Guid PlatformId { get; set; }
        public required string CountryCode { get; set; }

        public required Media Media { get; set; }
        public required Platform Platform { get; set; }
        public required Country Country { get; set; }
    }
}
