using System.Collections.Generic;
using System.Linq;
using Eventos.API.Data;
using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hinos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HinosController : ControllerBase
    {
        public IEnumerable<Hino> _Hino = new Hino[] {
            new Hino() {
                Id = 1
            }
        };
        private readonly DataContext _context;

        public HinosController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Hino> Get()
        {
            return _context.Hinos;
        }

        [HttpGet("{id}")]
        public Hino GetById(int id)
        {
            return _context.Hinos.FirstOrDefault(Hino => Hino.Id == id);
        }

        [HttpPost]
        public string Post()
        {
            return "test";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "test";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "test";
        }
    }
}
