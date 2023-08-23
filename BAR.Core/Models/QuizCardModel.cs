using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BAR.Core.Models
{
    public class QuizCardModel
    {
        public string ActivityType { get; set; }
        public string SchoolYear { get; set; }
        public string SchoolYearDesc { get {
            return "S.Y. " + GetSchoolYearDescriptionByValue(SchoolYear);
            } }
        public int QuizId { get; set; }


        static string GetSchoolYearDescriptionByValue(string val)
        {
            if (Enum.TryParse(val, out SchoolYear enumValue))
            {
                FieldInfo field = enumValue.GetType().GetField(enumValue.ToString());

                if (field != null)
                {
                    DescriptionAttribute attribute =
                        field.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;

                    if (attribute != null)
                    {
                        return attribute.Description;
                    }
                }
            }

            return string.Empty;
        }
    }
}
