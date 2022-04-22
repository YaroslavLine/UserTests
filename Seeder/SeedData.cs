using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserTests.Models;

namespace UserTests.Seeders
{
    public class SeedData
    {
        public async static Task Seed(IApplicationBuilder app)
        {
            using (IServiceScope scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<DataContext>();

                context.Database.Migrate();
                if (context.Tests.Count() == 0)
                {
                    var test1 = new Test
                    {
                        Title = "Elementary Vocabulary Test 1",
                        Description = "Most Common Adjectives In English MCQ Test 1 – Very Very Easy",
                    };
                    var test2 = new Test
                    {
                        Title = "Elementary Vocabulary Test 2",
                        Description = "Elementary Vocabulary MCQ Test – Very Very Middle",
                    };
                    var test3 = new Test
                    {
                        Title = "Intermediate Vocabulary Test 1",
                        Description = "Most Common Adjectives In English MCQ Test 2 With Answers - Easyish",
                    };
                    //
                    var test4 = new Test
                    {
                        Title = "Pre-Intermediate Vocabulary Test 2",
                        Description = "Pre-Intermediate Vocabulary ESL Vocabulary Exercises – Very Very Middle",
                    };
                    var test5 = new Test
                    {
                        Title = "Pre-Intermediate Vocabulary Test 3",
                        Description = "Pre-Intermediate Vocabulary ESL Vocabulary Exercises - Very Very Easy",
                    };
                    //
                    var test6 = new Test
                    {
                        Title = "Intermediate Vocabulary Test 1",
                        Description = "Most Common Adjectives In English MCQ Test 2 With Answers - Easyish",
                    };
                    var test7 = new Test
                    {
                        Title = "Intermediate Vocabulary Test 3",
                        Description = "General ESL Vocabulary MCQ Test With Answers - Intermediate Level Exercise 03",
                    };
                    var test8 = new Test
                    {
                        Title = "Intermediate Vocabulary Test 2",
                        Description = "General ESL Vocabulary MCQ Test With Answers - Intermediate Level Exercise 04",
                    };

                    context.Questions.AddRange(
                        new TestQuestion
                        {
                            Test = test1,
                            Question = "How do you do? I'm ............... to meet you.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "calm", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "lovely", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "pleased", IsCorrect = true }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test1,
                            Question = "Thank you. You've been very ______.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "cruel", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "helpful", IsCorrect = true },
                             new TestAnswer { AnswerText = "glad", IsCorrect = false }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test1,
                            Question = "Oh, I'm so happy for Meltem now. She is going out with a nice ______ man she met last week at my birthday party.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "smelly", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "young", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "dull", IsCorrect = false }
                                 }.ToArray()
                        },

                        new TestQuestion
                        {
                            Test = test2,
                            Question = "Most banks will ______ people money to buy a house.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "lend", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "borrow", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "give", IsCorrect = false }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test2,
                            Question = "My friend has a ______ job at a chemist’s.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "spare-time", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "empty-time", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "part-time", IsCorrect = true }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test2,
                            Question = "______ have you been learning English?",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "How many time", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "How long time", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "How long", IsCorrect = true }
                                 }.ToArray()
                        },

                        new TestQuestion
                        {
                            Test = test3,
                            Question = "I’ve put on ______. I eat too many cakes.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "weight", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "mixture", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "gloves", IsCorrect = false }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test3,
                            Question = "Put your suitcase up on the luggage ______.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "lounge", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "park", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "rack", IsCorrect = true }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test3,
                            Question = "You could hear the crowd shouting in the local football ______.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "ground", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "park", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "pool", IsCorrect = false }
                                 }.ToArray()
                        },

                        new TestQuestion
                        {
                            Test = test4,
                            Question = "The baby is ............... . Her diaper needs changing.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "sleepy", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "wet", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "dry", IsCorrect = false }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test4,
                            Question = "The lawyer's ............... was unusually high.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "fee", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "fare", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "account", IsCorrect = false }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test4,
                            Question = "The famous pianist Abdurrahmanovich is ............... with the İstanbul Metropolitan Orchestra tonight.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "playing", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "dealing", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "becoming", IsCorrect = false }
                                 }.ToArray()
                        },

                        new TestQuestion
                        {
                            Test = test5,
                            Question = "Excuse me. I'm a(n) ............... in this neighbourhood. Can you tell me what number bus will take me to the town center, please? I want to do some shopping.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "customer", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "tourist", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "stranger", IsCorrect = true }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test5,
                            Question = "How much must I ............... a good second-hand car?",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "own for", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "pay for", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "lend to", IsCorrect = false }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test5,
                            Question = "It's getting quite ______. I think it's going to rain soon.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "cold", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "cloudy", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "windy", IsCorrect = false }
                                 }.ToArray()
                        },
                        // Most Common Adjectives In English MCQ Test 2 With Answers - Easyish
                        new TestQuestion
                        {
                            Test = test6,
                            Question = "Oktay is a(n) ............... student. He always gets good grades.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "standard", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "lazy", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "hard-working", IsCorrect = true }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test6,
                            Question = "He crashed his car into a tree. It was badly ______.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "damaged", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "hurt", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "hopeless", IsCorrect = false }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test6,
                            Question = "It was a(n) ............... question. I couldn't understand a word of it.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "essential", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "easy", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "difficult", IsCorrect = true }
                                 }.ToArray()
                        },
                        // General ESL Vocabulary MCQ Test With Answers - Intermediate Level Exercise 03
                        new TestQuestion
                        {
                            Test = test7,
                            Question = "Long gone are the days when foreigners were looked upon as creatures from outer space. Turkland has emerged as a leading ............... tourism and business destination in the last decade. The country is very much in vogue nowadays.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "international", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "provincial", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "local", IsCorrect = false }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test7,
                            Question = "Do you really ............... to go there tonight?",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "intend", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "ignore", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "involve", IsCorrect = false }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test7,
                            Question = "You'll have to learn to control your ............... if you still want to work here with us.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "reason", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "habit", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "temper", IsCorrect = true }
                                 }.ToArray()
                        },
                        // General ESL Vocabulary MCQ Test With Answers - Intermediate Level Exercise 04
                        new TestQuestion
                        {
                            Test = test8,
                            Question = "I'm now going to give you 10 ______ tips for running a really successful website.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "valueless", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "invaluable", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "unprofitable", IsCorrect = false }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test8,
                            Question = "Well, they were both in perfect running order only this morning, but this one is now definitely out of ______. You'll have to use the other one.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "order", IsCorrect = true } ,
                             new TestAnswer { AnswerText = "work", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "employment", IsCorrect = false }
                                 }.ToArray()
                        },
                        new TestQuestion
                        {
                            Test = test8,
                            Question = "The doctors tried everything they could to ............ the patient's blood pressure.",
                            Answers = new[] {
                             new TestAnswer { AnswerText = "clarify", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "produce", IsCorrect = false } ,
                             new TestAnswer { AnswerText = "reduce", IsCorrect = true }
                                 }.ToArray()
                        }
                    );
                    context.SaveChanges();
                }

                UserManager<AppUser> userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                if (userManager.Users.Count() == 0)
                {
                    await userManager.CreateAsync(
                        new AppUser
                        {
                            UserName = "FirstUser",
                            Email = "User1@example.com"
                        }, "User1password"
                    );
                    await userManager.CreateAsync(
                        new AppUser
                        {
                            UserName = "SecondUser",
                            Email = "User2@example.com"
                        }, "User2password"
                    );
                    await userManager.CreateAsync(
                        new AppUser
                        {
                            UserName = "ThirdUser",
                            Email = "User3@example.com"
                        }, "User3password"
                    );
                }

                if (context.UserTests.Count() == 0)
                {
                    List<string> userIds = new List<string>();
                    List<long> testIds = new List<long>();
                    foreach (AppUser user in userManager.Users)
                    {
                        userIds.Add(user.Id);
                    }
                    foreach (Test test in context.Tests)
                    {
                        testIds.Add(test.Id);
                    }
                    context.UserTests.AddRange(
                        new AppUserTestJunction { AppUserId = userIds[0], TestId = testIds[0] },
                        new AppUserTestJunction { AppUserId = userIds[0], TestId = testIds[1] },
                        new AppUserTestJunction { AppUserId = userIds[0], TestId = testIds[2] },

                        new AppUserTestJunction { AppUserId = userIds[1], TestId = testIds[3] },
                        new AppUserTestJunction { AppUserId = userIds[1], TestId = testIds[4] },
                        new AppUserTestJunction { AppUserId = userIds[1], TestId = testIds[5] },

                        new AppUserTestJunction { AppUserId = userIds[2], TestId = testIds[3] },
                        new AppUserTestJunction { AppUserId = userIds[2], TestId = testIds[6] },
                        new AppUserTestJunction { AppUserId = userIds[2], TestId = testIds[7] }
                    );
                    context.SaveChanges();
                }
            }

        }
    }
}