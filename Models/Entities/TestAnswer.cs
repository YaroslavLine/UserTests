namespace UserTests.Models
{
    public class TestAnswer{
        public long Id { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public long QuestionId { get; set; }
        public TestQuestion Question { get; set; }
    }
}