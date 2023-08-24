﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAR.Core.Models
{
    public class QuestionaireModel
    {
        public int ItemId { get; set; }
        public int ItemNo { get; set; }
        public string Type { get; set; }
        public string Question { get; set; }
        public string ChoiceA { get; set; }
        public string ChoiceB { get; set; }
        public string ChoiceC { get; set;}
        public string ChoiceD { get; set;}
        public string Answer { get; set; }
        public string StudentAnswer { get; set; }
    }
}
