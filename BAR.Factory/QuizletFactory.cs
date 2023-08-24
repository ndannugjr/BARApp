using BAR.Core.Classes;
using BAR.Core.Models;
using BAR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml;

namespace BAR.Factory
{
    public class QuizletFactory
    {
        ApplicationDbContext _dbContext;
        public QuizletFactory()
        {
            _dbContext = new ApplicationDbContext();
        }

        public List<QuizCardModel> GetQuizList()
        {
            List<QuizCardModel> m = new List<QuizCardModel>();
            using (var _dbContext = new ApplicationDbContext())
            {
                var quizzes = _dbContext.ActivityHeader.Where(s => s.Grade == RuntimeInfo.Grade && s.IsPosted && !s.IsDeleted).OrderBy(o => o.Id).ToList();

                foreach (var sy in quizzes.Select(s => s.SchoolYear).Distinct())
                {
                    foreach (var at in quizzes.Where(x => x.SchoolYear == sy).Select(s => s.ActivityType).Distinct())
                    {
                        int count = 1;
                        foreach (var act in quizzes.Where(s => s.ActivityType == at))
                        {
                            QuizCardModel qm = new QuizCardModel()
                            {
                                ActivityType = act.ActivityType + " #" + count++,
                                SchoolYear = act.SchoolYear,
                                QuizId = act.Id
                            };
                            m.Add(qm);
                        }
                    }
                }

                return m;
            }
        }

        public QuizletModel GetQuiz(int id)
        {
            using (var _dbContext = new ApplicationDbContext())
            {
                QuizletModel m = new QuizletModel();

                var header = _dbContext.ActivityHeader.Where(s => s.Id == id).FirstOrDefault();

                m.ActivityType = header.ActivityType;
                m.Grade = header.Grade;
                m.SchoolYear = header.SchoolYear;

                m.Voice = (from ah in _dbContext.ActivityHeader
                           join
                             ad in _dbContext.ActivityDescription on ah.Id equals ad.ActivityHeaderId
                           join
                             acnd in _dbContext.ActivityVoiceNonVoiceDetails on ad.Id equals acnd.ActivityDescriptionId
                           where ah.Id == id && ad.QuestionType == "Voice"
                           select new QuestionAnswer { Id = acnd.Id, Value = acnd.Text, Answer = ""  }
                             ).ToList();
                m.NonVoice = (from ah in _dbContext.ActivityHeader
                              join
                             ad in _dbContext.ActivityDescription on ah.Id equals ad.ActivityHeaderId
                              join
                             acnd in _dbContext.ActivityVoiceNonVoiceDetails on ad.Id equals acnd.ActivityDescriptionId
                              where ah.Id == id && ad.QuestionType == "NonVoice"
                              select new QuestionAnswer { Id = acnd.Id, Value = acnd.Text, Answer = "" }
                             ).ToList();

                var readingCompre = (from ah in _dbContext.ActivityHeader
                                     join
                                      ad in _dbContext.ActivityDescription on ah.Id equals ad.ActivityHeaderId
                                     join
                                     aq in _dbContext.ActivityQuestions on ad.Id equals aq.ActivityDescriptionId
                                     where ah.Id == id
                                     select new
                                     {
                                         ad.Title,
                                         ad.Description,
                                         aq
                                     }).ToList();

                List<QuestionaireModel> qModelList = new();
                int i = 1;
                foreach (var item in readingCompre.Select(s => s.aq).OrderBy(o => o.Id))
                {
                    qModelList.Add(new QuestionaireModel
                    {
                        ItemId =item.Id,
                        ItemNo = i++,
                        ChoiceA = item.ChoiceA,
                        ChoiceB = item.ChoiceB,
                        ChoiceC = item.ChoiceC,
                        ChoiceD = item.ChoiceD,
                        Answer = item.Answer
                    });
                }

                ReadingComprehension r = new ReadingComprehension() { 
                Title = readingCompre.FirstOrDefault().Title,
                Description = readingCompre.FirstOrDefault().Description,
                Questions = qModelList
                };

                m.ReadingComprehension = r;


                return m;
            }
        }

        public bool SaveQuizlet(QuizletModel model)
        {
            try
            {
                using (var _dbContext = new ApplicationDbContext())
                {
                    ActivityHeader header = new ActivityHeader()
                    {
                        ActivityType = model.ActivityType,
                        Grade = model.Grade,
                        SchoolYear = model.SchoolYear
                    };

                    _dbContext.Add(header);
                    _dbContext.SaveChanges();

                    ActivityDescription vdesc = new ActivityDescription()
                    {
                        ActivityHeaderId = header.Id,
                        QuestionType = "Voice"
                    };
                    _dbContext.Add(vdesc);
                    _dbContext.SaveChanges();

                    foreach (var v in model.Voice.Select(s => s.Value))
                    {
                        ActivityVoiceNonVoiceDetails details = new ActivityVoiceNonVoiceDetails()
                        {
                            ActivityDescriptionId = vdesc.Id,
                            Text = v
                        };

                        _dbContext.Add(details);
                    }

                    ActivityDescription nvdesc = new ActivityDescription()
                    {
                        ActivityHeaderId = header.Id,
                        QuestionType = "NonVoice"
                    };
                    _dbContext.Add(nvdesc);
                    _dbContext.SaveChanges();

                    foreach (var nv in model.NonVoice.Select(s => s.Value))
                    {
                        ActivityVoiceNonVoiceDetails details = new ActivityVoiceNonVoiceDetails()
                        {
                            ActivityDescriptionId = nvdesc.Id,
                            Text = nv
                        };

                        _dbContext.Add(details);
                    }

                    ActivityDescription rcdesc = new ActivityDescription()
                    {
                        ActivityHeaderId = header.Id,
                        QuestionType = "ReadingComprehension",
                        Description = model.ReadingComprehension.Description,
                        Title = model.ReadingComprehension.Title
                    };
                    _dbContext.Add(rcdesc);
                    _dbContext.SaveChanges();

                    foreach (var q in model.ReadingComprehension.Questions)
                    {
                        ActivityQuestions aq = new ActivityQuestions()
                        {
                            ActivityDescriptionId = rcdesc.Id,
                            Question = q.Question,
                            Answer = q.Answer,
                            ChoiceA = q.ChoiceA,
                            ChoiceB = q.ChoiceB,
                            ChoiceC = q.ChoiceC,
                            ChoiceD = q.ChoiceD
                        };
                        _dbContext.Add(aq);
                    }
                    _dbContext.SaveChanges();
                }
             
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
