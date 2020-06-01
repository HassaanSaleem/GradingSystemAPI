using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingSystemAPI.Models
{
    public class Student
    {
        public int id { get; set; }
        public string roll { get; set; }
        public string full_name { get; set; }
        public string cnic { get; set; }
        public string phone { get; set; }
        public int credits_attempted { get; set; }
        public int credits_earned { get; set; }
        [Column(TypeName = "date")]
        public DateTime dob { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string status { get; set; }
    }
}
