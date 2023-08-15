using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAR.Data
{
    public class MenuNavigation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ParentId { get; set; }
        public int MenuOrder { get; set; }
        public bool isDeleted { get; set; }
        public bool IsForAdmin { get; set; }
        public bool IsForClient { get; set; }
    }
}
