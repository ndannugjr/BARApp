using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAR.Data
{
    public class UserActivityLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime EventTimeStamp { get; set; }
        public string UserName { get; set; }
        public string Module { get; set; }
        public string UserAction { get; set; }
        public string Remarks { get; set; }
    }
}
