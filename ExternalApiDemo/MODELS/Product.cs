namespace ExternalApiDemo.Models
{
    public class Product
    {
        public string? citizenId { get; set; }
        public string email { get; set; } = string.Empty;
        public string? phone { get; set; }

    }

    
    public class UserDetail
    {
        public int citizenId { get; set; }
        public string email { get; set; } = string.Empty;
        public string? phone { get; set; }

    }
}
