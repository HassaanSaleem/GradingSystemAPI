using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradingSystemAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GradingSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
        private readonly MyDBContext _context;

        public CourseController(ILogger<CourseController> logger)
        {
            _logger = logger;
            _context = new MyDBContext();
        }

        [HttpGet]
        public List<Course> GetCourse()
        {
            return _context.course.ToList();
        }
       
        [HttpGet]
        public List<CourseList> GetCourseCodeAndNames()
        {
            return _context.courseList.FromSqlRaw("select id,code,name from course").ToList();
        }

        [HttpGet("{id:int}")]
        public List<Course> GetCourseById(int id)
        {
            return _context.course.FromSqlRaw("select * from course where id={0}",id).ToList();
        }

        [HttpGet("{code}")]
        public List<Course> GetCourseByCode(String code)
        {
            return _context.course.FromSqlRaw("select * from course where code={0}", code).ToList();
        }


        [HttpPost]
        public IActionResult SetCourse([FromQuery] Course cor)
        {
            Course new_cor = new Course
            {
                code = cor.code,
                name = cor.name,
                credit_hours = cor.credit_hours,
                type = cor.type
            };

            _context.Add(new_cor);
            _context.SaveChanges();

            return Content("Changes Saved");

        }

    }
}
