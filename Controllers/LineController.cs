using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HangMan.Data;
using HangMan.Models;

namespace HangMan.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class LineController : Controller
    {
        private readonly HangManContext _context;

        public LineController(HangManContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Line> Get()
        {
            return _context.Line.ToList();
        }
    }
}
