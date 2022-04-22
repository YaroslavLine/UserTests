using Microsoft.EntityFrameworkCore;

namespace UserTests.Models
{
    public class DataRepository : IDataRepository
    {
        private DataContext _context;
        public DataRepository(DataContext context)
        {
            _context = context;
        }
        public IQueryable<Test> Tests => _context.Tests;
        public async Task<IEnumerable<Test>> GetTestsAsync(string userId)
        {
            return await _context.Tests
            .Where(t => t.UserTests.Select(t => t.AppUserId).Contains(userId))
            .Include(t => t.Questions)
            .ThenInclude(t => t.Answers)
            .ToArrayAsync();
        }

        public async Task<Test> GetTestAsync(long testId)
        {
            return await _context.Tests.Include(t => t.Questions).ThenInclude(t => t.Answers).FirstOrDefaultAsync(t => t.Id == testId);
        }
        public async Task<bool> CheckAnswerAsync(long answerId)
        {
            TestAnswer answer = await _context.Answers.FindAsync(answerId);
            return answer.IsCorrect;
        }
    }
}