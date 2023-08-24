using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAR.Core.Models
{
    public class QuizletModel
    {
        public string ActivityType { get; set; }
        public string Grade { get; set; }
        public string SchoolYear { get; set; }
        public List<QuestionAnswer> NonVoice { get; set; }
        public List<QuestionAnswer> Voice { get; set; }
        public ReadingComprehension ReadingComprehension { get; set; }

    }

    public class QuestionAnswer
    {
        public int Id { get; set; }
        public int ItemNo { get; set; }
        public string Value { get; set; }
        public string Answer { get; set; }

    }
    public class ReadingComprehension
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<QuestionaireModel> Questions { get; set; }
    }
    public enum ActivityType
    {
        [Description("a Quiz")]
        Quiz,
        [Description("an Activity")]
        Activity,
        [Description("Pre-Test")]
        PreTest,
        [Description("Post-Test")]
        PostTest,
    }
    public enum Grade
    {
        I,
        II,
        III,
        IV,
        V,
        VI,
        VII,
        VIII,
        IX,
        X,
        XI,
        XII
    }

    public enum SchoolYear
    {
        [Description("2022-2023")]
        SY2223,
        [Description("2023-2024")]
        SY2324,
        [Description("2024-2025")]
        SY2425,
        [Description("2025-2026")]
        SY2526,
        [Description("2026-2027")]
        SY2627,
        [Description("2027-2028")]
        SY2728,
        [Description("2028-2029")]
        SY2829,
        [Description("2029-2030")]
        SY2930,
    }



}
