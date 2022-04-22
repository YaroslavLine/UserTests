namespace UserTests.Models
{
    public class Test
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<TestQuestion> Questions { get; set; }
        public IEnumerable<AppUserTestJunction> UserTests { get; set; }
    }
}