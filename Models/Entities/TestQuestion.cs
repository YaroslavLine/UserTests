namespace UserTests.Models
{
    public class TestQuestion{
        public long Id { get; set; }
        public string Question { get; set; }
        public long TestId { get; set; }
        public Test Test { get; set; }
        public IEnumerable<TestAnswer> Answers { get; set; }
    }
}