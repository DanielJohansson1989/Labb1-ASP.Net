namespace LibraryMVC
{
    public class StaticDetails
    {
        public static string LibraryAPIBaseURL { get; set; }

        public enum RequestType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
