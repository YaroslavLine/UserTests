namespace UserTests.Models.SessionModels
{
    public class TestModel
    {
        public long TestId { get; set; }
        public int AcceptedAnswersСount { get; set; }
        public int TakedQuestionsCount { get; set; }
        public virtual void AddAcceptedAnswer() => AcceptedAnswersСount++;
        public virtual void AddTakedQuestion() => TakedQuestionsCount++;
        public virtual void Reset()
        {
            AcceptedAnswersСount = 0;
            TakedQuestionsCount = 0;
        }
        public virtual void SetTestId(long id) => TestId = id;
        public virtual void Clean(){}
    }
}