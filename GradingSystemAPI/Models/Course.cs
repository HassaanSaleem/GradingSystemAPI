using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradingSystemAPI.Models
{
    public class Course
    {
        public int id { get; set; }
        public String code { get; set; }
        public String name { get; set; }
        public int credit_hours { get; set; }
        public String type { get; set; }

    }
    public class CourseList
    {
        public int id { get; set; }
        public String code { get; set; }
        public String name { get; set; }

    }
}
