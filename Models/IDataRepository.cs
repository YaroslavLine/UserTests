namespace UserTests.Models
{
    public interface IDataRepository
    {
        public Task<Test> GetTestAsync(long testId);
        public Task<IEnumerable<Test>> GetTestsAsync(string userId);
        public Task<bool> CheckAnswerAsync(long answerId);
        public IQueryable<Test> Tests { get; }
    }
}