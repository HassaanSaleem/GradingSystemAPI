using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradingSystemAPI.Models
{
    public class Grading_schema
    {
        public int ID { get; set; }
        public String CourseID { get; set; }
        public String ExamType { get; set; }
        public int MaxWeightage { get; set; }
        public int MinWeightage { get; set; }

    }
}
