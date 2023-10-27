namespace AppCenter.Models
{
    public class Requester
    {
        public string? Email { get; set; } = string.Empty;
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
        public string BlockNumber { get; set; } = string.Empty;

        public DateTime? RequestDate { get; set; }


        public Requester()
        {
            RequestDate = DateTime.Now;
        }
    }
}
