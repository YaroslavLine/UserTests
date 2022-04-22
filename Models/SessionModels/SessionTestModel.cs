using Newtonsoft.Json;
using UserTests.Infrastructure;

namespace UserTests.Models.SessionModels
{
    public class SessionTestModel : TestModel
    {
        public static TestModel GetTestModel(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionTestModel model = session?.GetJson<SessionTestModel>("TestingSession") ?? new SessionTestModel();
            model.Session = session;
            return model;
        }
        [JsonIgnore]
        public ISession Session { get; set; }
        public override void AddAcceptedAnswer()
        {
            base.AddAcceptedAnswer();
            Session.SetJson("TestingSession", this);
        }
        public override void SetTestId(long id)
        {
            base.SetTestId(id);
            Session.SetJson("TestingSession", this);
        }
        public override void AddTakedQuestion()
        {
            base.AddTakedQuestion();
            Session.SetJson("TestingSession", this);
        }
        public override void Reset()
        {
            base.Reset();
            Session.SetJson("TestingSession", this);
        }
        public override void Clean() => Session.Remove("TestingSession");
    }
}