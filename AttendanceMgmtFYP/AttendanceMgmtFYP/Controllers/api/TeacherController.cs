using AttendanceMgmtFYP.Data;
using AttendanceMgmtFYP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;

namespace AttendanceMgmtFYP.Controllers.api
{
    [Route("api/[controller]")]
    public class TeacherController : Controller
    {
        private readonly Context _context;
        public TeacherController(Context context)
        {

            this._context = context;
        }
        [HttpGet]
        public Object Get()
        {
            var Teacher = _context.Teachers.ToList();
            return Ok(Teacher);
        }
        [HttpGet("{TeacherId:int}")]
        public Object Get(int TeacherId)
        {
            var Teacher = _context.Teachers.Where(e => e.TeacherId == TeacherId).FirstOrDefault();
            return Ok(Teacher);
        }
        [HttpPost]
        public Object post([FromForm] Teacher teacher, [FromForm] IFormFile Image)
        {



            using (var ms = new MemoryStream())
            {
                Image.CopyTo(ms);
                var fileBytes = ms.ToArray();
                teacher.Image = Convert.ToBase64String(fileBytes);
                // act on the Base64 data
            }


            if (ModelState.IsValid)
            {
                _context.Teachers.Add(teacher);
                _context.SaveChanges();
                return Ok(new { id = teacher.TeacherId });
            }
            return BadRequest();
        }

    }
}
