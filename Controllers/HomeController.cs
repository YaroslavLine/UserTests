using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserTests.Models;
using UserTests.Models.SessionModels;

namespace UserTests.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IDataRepository _repository;
        private TestModel _testModelService;
        private UserManager<AppUser> _userManager;
        public HomeController(IDataRepository repository, TestModel testModelService, UserManager<AppUser> userManager)
        {
            _repository = repository;
            _testModelService = testModelService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.GetUserAsync(User);
            return View(await _repository.GetTestsAsync(user.Id));
        }

        public IActionResult SelectTest(long testId)
        {
            _testModelService.SetTestId(testId);
            return View("Accept", _repository.Tests.First(f => f.Id == testId));
        }
        [HttpPost]
        public IActionResult Accept(bool acceptedByUser)
        {
            if (!acceptedByUser)
            {
                ModelState.AddModelError("", "Confirm the condition");
            }
            if (ModelState.IsValid)
            {
                _testModelService.Reset();
                return RedirectToAction(nameof(Testing));
            }
            else return View(_repository.Tests.First(f => f.Id == _testModelService.TestId));
        }
        public async Task<IActionResult> Testing()
        {
            var test = await _repository.GetTestAsync(_testModelService.TestId);
            if (test == null)
            {
                return RedirectToAction(nameof(Index));
            }
            if (_testModelService.TakedQuestionsCount == test.Questions.Count())
            {
                return RedirectToAction(nameof(Result));
            }
            ViewBag.TestTitle = test.Description;
            var question = test.Questions.Skip(_testModelService.TakedQuestionsCount).Take(1).First();

            return View(question);
        }
        [HttpPost]
        public async Task<RedirectResult> SaveAndNext(long answerId, string returnUrl)
        {
            _testModelService.AddTakedQuestion();
            if (answerId != 0 && await _repository.CheckAnswerAsync(answerId))
            {
                _testModelService.AddAcceptedAnswer();
            }
            return Redirect(returnUrl ?? "/");
        }
        public IActionResult Result()
        {
            var testResult = new { Accepted = _testModelService.AcceptedAnswersСount, QuestionsCount = _testModelService.TakedQuestionsCount };
            _testModelService.Clean();
            return View(testResult);
        }
    }
}