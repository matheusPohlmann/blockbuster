using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blockbuster.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Blockbuster.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentController : ControllerBase
    {
        public RentController()
        {

        }

        public IEnumerable<Rent> _rent = new Rent[] {
            new Rent()
            {
                Id = 1,
                DateRent = DateTime.Now.ToString(),
                DateDevolution = DateTime.Now.AddDays(2).ToString()
            },
            new Rent()
            {
                Id = 2,
                DateRent = DateTime.Now.ToString(),
                DateDevolution = DateTime.Now.AddDays(4).ToString()
            }
        };

        [HttpGet]
        public IEnumerable<Rent> Get()
        {
            return _rent;
        }

        [HttpGet("{id}")]
        public Rent Get(int id)
        {
            return _rent.Where(x => x.Id == id).FirstOrDefault();
        }

        [HttpPost]
        public string Post()
        {
            return "exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"exemplo de Delete com id = {id}";
        }
    }
}
