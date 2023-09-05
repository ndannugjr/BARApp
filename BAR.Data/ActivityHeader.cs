using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedBy { get; set; }
        public bool IsPosted { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
