using AttendanceMgmtFYP.Data;
using AttendanceMgmtFYP.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceMgmtFYP.Controllers.api
{
    [Route("api/[controller]")]
    public class TeacherController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;
        public TeacherController(IWebHostEnvironment webHostEnvironment, Context context)
        {
            hostingEnvironment = webHostEnvironment;
            _context = context;
        }
        private readonly Context _context;
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
        public async Task<IActionResult> Post([FromForm] Teacher teacher, [FromForm] IFormFile Image)
        {
            if (Image != null)
            {
                var uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                var filename = Guid.NewGuid().ToString() + "_" + Image.FileName;
                string filePath = Path.Combine(uploadFolder, filename);
                using (var stream = System.IO.File.Create(filePath))
                {
                    await Image.CopyToAsync(stream);
                }
                teacher.FileName = filename;
                teacher.OrignalFileName = Image.FileName;
            }
            if (ModelState.IsValid)
            {
                _context.Teachers.Add(teacher);
                await _context.SaveChangesAsync();
                return Ok(new { teacherid = teacher.TeacherId });
            }
            return BadRequest();
        }

        [HttpGet("Image/{TeacherId:int}")]
        public IActionResult FilePath(int TeacherId)
        {
            var uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
            var filename = (from fn in _context.Teachers
                            where fn.TeacherId == TeacherId
                            select fn.FileName).FirstOrDefault();
            string filePath = Path.Combine(uploadFolder, filename);
            return PhysicalFile(filePath, "image/jpg");

        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromForm] Teacher teacher, [FromForm] IFormFile Image)
        {
            if (teacher.TeacherId <= 0)
            {
                return BadRequest();
            }
            var _teacher = await _context.Teachers.FindAsync(teacher.TeacherId);
            _context.Entry(_teacher).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            if (Image != null)
            {
                var uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                var filename = Guid.NewGuid().ToString() + "_" + Image.FileName;
                string filePath = Path.Combine(uploadFolder, filename);
                using (var stream = System.IO.File.Create(filePath))
                {
                    await Image.CopyToAsync(stream);
                }
                teacher.FileName = filename;
                teacher.OrignalFileName = Image.FileName;
            }
            _teacher.FirstName = teacher.FirstName;
            _teacher.LastName = teacher.LastName;
            _teacher.FileName = teacher.FileName;
            _teacher.DateofBirth = teacher.DateofBirth;
            _teacher.Gender = teacher.Gender;
            _teacher.OrignalFileName = teacher.OrignalFileName;
            _teacher.Cnic = teacher.Cnic;
            _context.Update(_teacher);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet("Delete/{TeacherId:int}")]
        public async Task<IActionResult> Delete(int TeacherId)
        {
            if (TeacherId <= 0) return BadRequest();
            _context.Teachers.Remove(_context.Teachers.Find(TeacherId));
            await _context.SaveChangesAsync();
            return Ok(new { TeacherId = TeacherId });
        }

    }

}
