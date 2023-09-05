using BAR.Core.Classes;
using BAR.Core.Models;
using BAR.Data;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml;

namespace BAR.Factory
{
    public class QuizletFactory
    {
        public QuizletFactory()
        {
        }

        public List<QuizCardModel> GetQuizCardList()
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
                        foreach (var act in quizzes.Where(s => s.ActivityType == at && s.SchoolYear == sy))
                        {
                            QuizCardModel qm = new QuizCardModel()
                            {
                                ActivityType = act.ActivityType + " #" + count++,
                                SchoolYear = act.SchoolYear,
                                ActivityHeaderId = act.Id
                            };
                            m.Add(qm);
                        }
                    }
                }

                return m;
            }
        }

        public List<QuizletModel> GetQuizList()
        {
            using (var _dbContext = new ApplicationDbContext())
            {
                return _dbContext.ActivityHeader.Where(s => !s.IsDeleted && s.CreatedBy == RuntimeInfo.UserId).OrderBy(o => o.Id).Select(o => new QuizletModel()
                {
                    ActivityHeaderId = o.Id,
                    ActivityType = o.ActivityType,
                    CreatedBy = o.CreatedBy,
                    CreatedDate = o.CreatedDate,
                    Grade = o.Grade,
                    IsPosted = o.IsPosted,
                    LastUpdatedBy = o.LastUpdatedBy,
                    LastUpdatedDate = o.LastUpdatedDate,
                    PostedDate = o.PostedDate,
                    SchoolYear = o.SchoolYear
                }).ToList();
            }
        }

        public bool IsDone(int activityHeaderId, int studentId)
        {
            using (var _dbContext = new ApplicationDbContext())
            {
                return _dbContext.AnswerSheet.Any(s => s.ActivityHeaderId == activityHeaderId && s.UserId == studentId);
            }
        }

        public QuizletModel GetQuizById(int id)
        {
            using (var _dbContext = new ApplicationDbContext())
            {
                QuizletModel m = new QuizletModel();

                var header = _dbContext.ActivityHeader.Where(s => s.Id == id).FirstOrDefault();

                m.ActivityHeaderId = header.Id;
                m.ActivityType = header.ActivityType;
                m.Grade = header.Grade;
                m.SchoolYear = header.SchoolYear;
                m.IsPosted = header.IsPosted;

                m.Voice = (from ah in _dbContext.ActivityHeader
                           join
                             ad in _dbContext.ActivityDescription on ah.Id equals ad.ActivityHeaderId
                           join
                             acnd in _dbContext.ActivityVoiceNonVoiceDetails on ad.Id equals acnd.ActivityDescriptionId
                           where ah.Id == id && ad.QuestionType == "Voice"
                           select new QuestionAnswer { ActivityVoiceNonVoiceDetailId = acnd.Id, Value = acnd.Text, StudentAnswer = "" }
                             ).ToList();
                m.NonVoice = (from ah in _dbContext.ActivityHeader
                              join
                             ad in _dbContext.ActivityDescription on ah.Id equals ad.ActivityHeaderId
                              join
                             acnd in _dbContext.ActivityVoiceNonVoiceDetails on ad.Id equals acnd.ActivityDescriptionId
                              where ah.Id == id && ad.QuestionType == "NonVoice"
                              select new QuestionAnswer { ActivityVoiceNonVoiceDetailId = acnd.Id, Value = acnd.Text, StudentAnswer = "" }
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
                        ActivityQuestionId = item.Id,
                        ItemNo = i++,
                        ChoiceA = item.ChoiceA,
                        ChoiceB = item.ChoiceB,
                        ChoiceC = item.ChoiceC,
                        ChoiceD = item.ChoiceD,
                        Question = item.Question,
                        Answer = item.Answer,
                        Type = item.ChoiceA != string.Empty ? "MC" : "ID"
                    });
                }

                ReadingComprehension r = new ReadingComprehension()
                {
                    Title = readingCompre.FirstOrDefault().Title,
                    Description = readingCompre.FirstOrDefault().Description,
                    Questions = qModelList
                };

                m.ReadingComprehension = r;


                return m;
            }
        }
        public QuizletModel GetQuizResultsById(int id, int studentId)
        {
            using (var _dbContext = new ApplicationDbContext())
            {
                QuizletModel m = new QuizletModel();

                var header = _dbContext.ActivityHeader.Where(s => s.Id == id).FirstOrDefault();

                m.ActivityHeaderId = header.Id;
                m.ActivityType = header.ActivityType;
                m.Grade = header.Grade;
                m.SchoolYear = header.SchoolYear;
                m.IsPosted = header.IsPosted;

                m.Voice = (from ah in _dbContext.ActivityHeader
                           join
                             ad in _dbContext.ActivityDescription on ah.Id equals ad.ActivityHeaderId
                           join
                             acnd in _dbContext.ActivityVoiceNonVoiceDetails on ad.Id equals acnd.ActivityDescriptionId
                           join
                              asheet in _dbContext.AnswerSheet on acnd.Id equals asheet.ActivityVoiceNonVoiceDetailId
                              into x
                           from
                             aSheetItem in x.DefaultIfEmpty()
                           where ah.Id == id && ad.QuestionType == "Voice" && aSheetItem.UserId == studentId
                           select new QuestionAnswer { ActivityVoiceNonVoiceDetailId = acnd.Id, Value = acnd.Text, StudentAnswer = aSheetItem.StudentAnswer }
                             ).ToList();
                m.NonVoice = (from ah in _dbContext.ActivityHeader
                              join
                             ad in _dbContext.ActivityDescription on ah.Id equals ad.ActivityHeaderId
                              join
                             acnd in _dbContext.ActivityVoiceNonVoiceDetails on ad.Id equals acnd.ActivityDescriptionId
                              join
                               asheet in _dbContext.AnswerSheet on acnd.Id equals asheet.ActivityVoiceNonVoiceDetailId
                               into x
                              from
                                aSheetItem in x.DefaultIfEmpty()
                              where ah.Id == id && ad.QuestionType == "NonVoice" && aSheetItem.UserId == studentId
                              select new QuestionAnswer { ActivityVoiceNonVoiceDetailId = acnd.Id, Value = acnd.Text, StudentAnswer = aSheetItem.StudentAnswer }
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
                    var studentAns = _dbContext.AnswerSheet.FirstOrDefault(s => s.ActivityQuestionId == item.Id && s.UserId == studentId);

                    qModelList.Add(new QuestionaireModel
                    {
                        ActivityQuestionId = item.Id,
                        ItemNo = i++,
                        ChoiceA = item.ChoiceA,
                        ChoiceB = item.ChoiceB,
                        ChoiceC = item.ChoiceC,
                        ChoiceD = item.ChoiceD,
                        Question = item.Question,
                        Answer = item.Answer,
                        Type = item.ChoiceA != string.Empty ? "MC" : "ID",
                        StudentAnswer = studentAns != null ? studentAns.StudentAnswer : ""
                    }) ;
                }

                ReadingComprehension r = new ReadingComprehension()
                {
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
                        SchoolYear = model.SchoolYear,
                        CreatedDate = model.CreatedDate,
                        CreatedBy = model.CreatedBy,
                        LastUpdatedDate = model.LastUpdatedDate,
                        LastUpdatedBy = model.LastUpdatedBy,
                        IsPosted = model.IsPosted,
                        PostedDate = model.IsPosted ? DateTime.Now : null
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
        public bool UpdateQuizlet(QuizletModel model)
        {
            try
            {
                using (var _dbContext = new ApplicationDbContext())
                {
                    var headerUpdate = _dbContext.ActivityHeader.FirstOrDefault(s => s.Id == model.ActivityHeaderId);

                    DateTime? postedDate = DateTime.Now;
                    if (model.IsPosted)
                        if (headerUpdate.PostedDate != null)
                            postedDate = headerUpdate.PostedDate;
                        else
                            postedDate = DateTime.Now;
                    else
                        postedDate = null;

                    headerUpdate.ActivityType = model.ActivityType;
                    headerUpdate.Grade = model.Grade;
                    headerUpdate.SchoolYear = model.SchoolYear;
                    headerUpdate.LastUpdatedDate = model.LastUpdatedDate;
                    headerUpdate.LastUpdatedBy = model.LastUpdatedBy;
                    headerUpdate.IsPosted = model.IsPosted;
                    headerUpdate.PostedDate = postedDate;

                    var activityDesc = _dbContext.ActivityDescription.Where(s => s.ActivityHeaderId == model.ActivityHeaderId).ToList();
                    _dbContext.RemoveRange(activityDesc);

                    List<int> activityDescIds = activityDesc.Select(s => s.Id).ToList();
                    var activityQuestions = _dbContext.ActivityQuestions.Where(s => activityDescIds.Contains(s.ActivityDescriptionId));
                    _dbContext.RemoveRange(activityQuestions);

                    var activityNonVoiceDetails = _dbContext.ActivityVoiceNonVoiceDetails.Where(s => activityDescIds.Contains(s.ActivityDescriptionId));
                    _dbContext.RemoveRange(activityNonVoiceDetails);

                    _dbContext.SaveChanges();

                    ActivityDescription vdesc = new ActivityDescription()
                    {
                        ActivityHeaderId = model.ActivityHeaderId,
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
                        ActivityHeaderId = model.ActivityHeaderId,
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
                        ActivityHeaderId = model.ActivityHeaderId,
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

        public bool SaveAnswerSheet(QuizletModel model)
        {
            try
            {
                using (var _dbContext = new ApplicationDbContext())
                {
                    foreach (var nv in model.NonVoice)
                    {
                        var answerSheet = GetAnswerSheet(nv, model.ActivityHeaderId, "NonVoice");
                        _dbContext.Add(answerSheet);
                    }

                    foreach (var nv in model.Voice)
                    {
                        var answerSheet = GetAnswerSheet(nv, model.ActivityHeaderId, "Voice");
                        _dbContext.Add(answerSheet);
                    }

                    foreach (var rc in model.ReadingComprehension.Questions)
                    {
                        var answerSheet = new AnswerSheet()
                        {
                            ActivityHeaderId = model.ActivityHeaderId,
                            ActivityQuestionId = rc.ActivityQuestionId,
                            Answer = rc.Answer,
                            AnsweredDate = DateTime.Now,
                            StudentAnswer = rc.StudentAnswer ?? "",
                            IsCorrect = rc.IsCorrect,
                            UserId = RuntimeInfo.UserId,
                            QuestionType = rc.Type
                        };
                        _dbContext.Add(answerSheet);
                    }

                    _dbContext.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        private AnswerSheet GetAnswerSheet(QuestionAnswer qa, int headerId, string questionType)
        {
            return new AnswerSheet()
            {
                ActivityHeaderId = headerId,
                ActivityVoiceNonVoiceDetailId = qa.ActivityVoiceNonVoiceDetailId,
                Answer = qa.Value,
                AnsweredDate = DateTime.Now,
                StudentAnswer = qa.StudentAnswer ?? "",
                IsCorrect = qa.IsCorrect,
                UserId = RuntimeInfo.UserId,
                QuestionType = questionType
            };
        }

        public DateTime PostQuiz(int id)
        {
            DateTime dtNow = DateTime.Now;
            using (var db = new ApplicationDbContext())
            {
                try
                {
                    var forUpdate = db.ActivityHeader.Where(o => o.Id == id).FirstOrDefault();
                    if (forUpdate != null)
                    {
                        forUpdate.IsPosted = !forUpdate.IsPosted;
                        forUpdate.PostedDate = forUpdate.IsPosted == false ? null : dtNow;

                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    return dtNow;
                }
                return dtNow;
            }
        }

        public bool IsAlreadyPosted(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                try
                {
                    return db.ActivityHeader.Where(o => o.Id == id).FirstOrDefault().IsPosted;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public bool DeleteQuiz(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                try
                {
                    var forUpdate = db.ActivityHeader.Where(o => o.Id == id).FirstOrDefault();
                    if (forUpdate != null)
                    {
                        forUpdate.IsDeleted = true;

                        db.SaveChanges();
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
}
