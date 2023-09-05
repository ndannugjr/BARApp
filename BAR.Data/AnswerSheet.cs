using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAR.Data
{
    public class AnswerSheet
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public int ActivityHeaderId { get; set; }
        public int ActivityDescriptionId { get; set; }
        public int? ActivityQuestionId { get; set; }
        public int? ActivityVoiceNonVoiceDetailId { get; set; }
        public DateTime AnsweredDate { get; set; }
        public string QuestionType { get; set; }
        public string Answer { get; set; }
        public string StudentAnswer { get; set; }
        public bool IsCorrect { get; set; }
        public bool? TeacherVerdict { get; set; }
        public DateTime? TeacherVerdictDate { get; set; }
        public int? TeacherId { get; set; }
    }
}
