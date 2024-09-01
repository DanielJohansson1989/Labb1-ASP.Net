using System.Net;

namespace LibraryAPI.Models
{
    public class APIResponse
    {
        public bool IsSuccess { get; set; }
        public Object Result { get; set; }
        public HttpStatusCode StattusCode { get; set; }
        public List<string> ErrorMessages { get; set; }

        public APIResponse()
        {
            ErrorMessages = new List<string>();
        }
    }
}
