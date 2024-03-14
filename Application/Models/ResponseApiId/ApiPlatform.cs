

namespace Application.Models.ResponseApiId
{
    public class ApiPlatform
    {
        public string Service { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ApiPlatform otherPlatform = (ApiPlatform)obj;
            return Service == otherPlatform.Service;
        }

        public override int GetHashCode()
        {
            return Service.GetHashCode();
        }
    }
}
