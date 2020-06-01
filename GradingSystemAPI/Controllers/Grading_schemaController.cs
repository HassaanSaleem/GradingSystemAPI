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
    public class Grading_schemaController : ControllerBase
    {
        private readonly ILogger<Grading_schemaController> _logger;
        private readonly MyDBContext _context;

        public Grading_schemaController(ILogger<Grading_schemaController> logger)
        {
            _logger = logger;
            _context = new MyDBContext();
        }

        [HttpGet]
        public List<Grading_schema> GetGrading_schema()
        {
            return _context.grading_Schema.ToList();
        }

        [HttpPost]

        public IActionResult SetGrading_schema([FromQuery]Grading_schema sch)
        {
            Grading_schema new_sch = new Grading_schema
            {
                CourseID = sch.CourseID,
                ExamType = sch.ExamType,
                MaxWeightage = sch.MaxWeightage,
                MinWeightage = sch.MinWeightage
            };

            _context.Add(new_sch);
            _context.SaveChanges();

            return Content("Changes Saved");

        }

    }
}