using static LibraryMVC.StaticDetails;

namespace LibraryMVC.Models
{
    public class APIRequest
    {
        public RequestType RequestType { get; set; }
        public string URL { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
