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

    public class FacultyController : ControllerBase
    {
        private readonly ILogger<FacultyController> _logger;
        private readonly MyDBContext _context;

        public FacultyController(ILogger<FacultyController> logger)
        {
            _logger = logger;
            _context = new MyDBContext();
        }

        [HttpGet]
        public List<Faculty> GetFaculty()
        {
            return _context.faculty.ToList();
        }

        [HttpPost]

        public IActionResult InsertFaculty([FromQuery]Faculty fac)
        {
            Faculty new_fac = new Faculty
            {
                name = fac.name,
                phone = fac.phone,
                email = fac.email,
                address = fac.address,
                qualification=fac.qualification
            };

            _context.Add(new_fac);
            _context.SaveChanges();

            return Content("Changes Saved");

        }

    }
}