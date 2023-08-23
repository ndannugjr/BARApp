using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAR.Data
{
    public class ActivityDescription
    {
        public int Id { get; set; }
        public int ActivityHeaderId { get; set; }
        public string QuestionType { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
