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
    public class WordsController : Controller
    {
        private readonly HangManContext _context;

        public WordsController(HangManContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Words> Get()
        {
            return _context.Words.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var word = await _context.Words.SingleOrDefaultAsync(m => m.WordsId == id);

            if (word == null)
            {
                return NotFound();
            }
            return Ok(word);
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
