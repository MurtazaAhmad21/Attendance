using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using AttendanceMgmtFYP.Data;
using System.Linq;

namespace AttendanceMgmtFYP.Controllers.API
{
   
   [Route("api/[controller]")]
  [Authorize(AuthenticationSchemes = 
   JwtBearerDefaults.AuthenticationScheme)]
    public class LoginController : Controller
    {
        //public NebulaUser_Rep nebulaUser;
        private readonly IJWTAuth Auth;
        private readonly Context _context;
        public LoginController(Context context, IJWTAuth Auth)
        {
            //nebulaUser  = new NebulaUser_Rep(context);
            this.Auth = Auth;
            this._context = context;

        }


        [HttpGet("{id:int}")]
        public object Get(long id)
        {
            return null;
        }

        [HttpGet("{username}/{password}")]
        [AllowAnonymous]
        public Object Get(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return BadRequest();
            var user = _context.Users.Where(e => e.Username == username && e.Password == password).ToList();
            if (user.Count > 0)
            {
                return Ok(new { token = Auth.GetToken(username, password), user = user.First() });
            }
            else
            {
                return NoContent();
            }
        }
    }
}