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
    public class LettersController : Controller
    {
        private readonly HangManContext _context;

        public LettersController(HangManContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Letters> Get()
        {
            return _context.Letters.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var letter = await _context.Letters.SingleOrDefaultAsync(m => m.LettersId == id);

            if (letter == null)
            {
                return NotFound();
            }
            return Ok(letter);
        }

        // // POST api/values
        // [HttpPost]
        // public void Post([FromBody]string value)
        // {
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
