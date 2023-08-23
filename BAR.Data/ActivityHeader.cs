using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAR.Data
{
    public class ActivityHeader
    {
        public int Id { get; set; }
        public string ActivityType { get; set; }
        public string Grade { get; set; }
        public string SchoolYear { get; set; }
        public bool IsPosted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
