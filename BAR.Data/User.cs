using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAR.Data
{
    public class User
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string  FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Grade { get; set; }
        public string Section { get; set; }
        public string ProfileImagePath { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastPasswordChange { get; set; }
        public string Position { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
    }
}
