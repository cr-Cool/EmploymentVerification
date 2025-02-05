using EmploymentVerification.Data;
using EmploymentVerification.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmploymentVerification.Controllers
{
    [Route("api/verify-employment")]
    [ApiController]
    public class EmploymentVerificationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmploymentVerificationController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult VerifyEmployment([FromBody] Employee request)
        {
            try
            {
                if (_context == null || _context.Employees == null)
                {
                    return StatusCode(500, "Database is not available.");
                }
                //var empData = _context.Employees.ToList();
                var verified = _context.Employees.Any(e =>
                    e.Id == request.Id &&
                    e.CompanyName.Equals(request.CompanyName) &&
                    e.VerificationCode == request.VerificationCode);

                return Ok(new { verified });
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
