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
        public TeacherController(IWebHostEnvironment webHostEnvironment,Context context)
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
        public async Task<IActionResult> Post([FromForm]Teacher teacher,[FromForm]IFormFile Image)
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
    }
}
