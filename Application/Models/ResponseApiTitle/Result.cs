

using Newtonsoft.Json;

namespace Application.Models.ResponseApiTitle
{
    public class Result
    {
        private string _id;

        public string Id
        {
            get => _id;
            set
            {
                if (value != null)
                {
                    string[] parts = value.Split('/');
                    _id = parts
                    .Select(part => part.Trim('"'))
                    .FirstOrDefault(part => part.StartsWith("tt") || part.StartsWith("nm"));
                }
            }
        }


        public Image Image { get; set; }
        public string Title { get; set; }
        public string TitleType { get; set; }
        public int Year { get; set; }
    }
}
