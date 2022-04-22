namespace UserTests.Models
{
    public class AppUserTestJunction
    {
        public long Id { get; set; }
        public Test Test { get; set; }
        public long TestId { get; set; }
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }
    }
}