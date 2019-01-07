using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _Context;

        public ValuesController(DataContext dbContext)
        {
            _Context = dbContext;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues ()
        {
            var valuesInDb = await _Context.Value.ToListAsync();
            return Ok(valuesInDb);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task< IActionResult> GetValue(int id)
        {
            var valueInDb = await _Context.Value.SingleOrDefaultAsync(v => v.Id == id);
            if (valueInDb == null)
                return NotFound();

            return Ok(valueInDb);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
