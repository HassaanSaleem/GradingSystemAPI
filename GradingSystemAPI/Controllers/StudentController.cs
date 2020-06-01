using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradingSystemAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GradingSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    
    public class StudentController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDBContext _context;

        public StudentController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = new MyDBContext();
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            return _context.Student.ToList();
        }

        [HttpPost]

        public IActionResult InsertStudent([FromQuery]Student std)
        {
            Student new_std = new Student
            {
                roll = std.roll,
                full_name = std.full_name,
                cnic = std.cnic,
                phone = std.phone,
                credits_attempted = std.credits_attempted,
                credits_earned = std.credits_earned,
                dob = std.dob,
                email = std.email,
                address = std.address,
                status = std.status
            };

            _context.Add(new_std);
            _context.SaveChanges();

            return Content("Changes Saved");

        }


    }
}