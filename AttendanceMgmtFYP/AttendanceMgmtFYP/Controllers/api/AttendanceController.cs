using AttendanceMgmtFYP.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceMgmtFYP.Controllers.api
{
    [Route("api/[controller]")]
    public class AttendanceController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;
        public AttendanceController(IWebHostEnvironment webHostEnvironment, Context context)
        {
            hostingEnvironment = webHostEnvironment;
            _context = context;
        }
        private readonly Context _context;
        [HttpGet("{TeacherId:int}")]
        public Object Get(int TeacherId)
        {

            var TimeTable = _context.TimeTables.Where(e => e.TeacherId == TeacherId).FirstOrDefault();
            return Ok(TimeTable);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
