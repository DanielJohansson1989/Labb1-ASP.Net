namespace LibraryMVC.Models
{
    public class APIResponseDTO
    {
        public bool IsSuccess { get; set; }
        public object Result { get; set; }
        public List<string> ErrorList { get; set; }
    }
}
