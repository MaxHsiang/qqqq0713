using Microsoft.AspNetCore.Mvc;
using prjMvcCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prjMvcCoreDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamePandaQueryServiceController : ControllerBase
    {
        // GET: api/<GamePandaQueryServiceController>
        [HttpGet]
        public IEnumerable<TProduct> Get()
        {
            var datas = from p in (new dbDemoContext()).TProducts
                        select p;
            foreach(TProduct p in datas)
            {
                p.FCost = 0;
                if (p.FQty > 250)
                    p.FQty = 250;
            }
            return datas;
        }

        // GET api/<GamePandaQueryServiceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GamePandaQueryServiceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GamePandaQueryServiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GamePandaQueryServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
