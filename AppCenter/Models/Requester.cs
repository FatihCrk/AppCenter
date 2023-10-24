namespace AppCenter.Models
{
    public class Requester
    {
        public string? Email { get; set; } = string.Empty;
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public int? Age { get; set; } 
        public string? SelectedCourse { get; set; } = string.Empty;
        public DateTime? ApplyAt { get; set; }


        public Requester()
        {
            ApplyAt = DateTime.Now;
        }
    }
}
