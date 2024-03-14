 namespace Domain.Entities
{
    
    public class MediaGenre {

        public Guid Id { get; set; }
        public Guid GenreId { get; set;}
        public Guid MediaId {get; set;}
        public Guid ImdbId {get; set;}

        public required Genre Genre {get; set;}
        public required Media Media {get; set;}
    }
}