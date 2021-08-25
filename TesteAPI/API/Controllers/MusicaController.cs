using API.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicaController : ControllerBase
    {
        MusicaRepository repository = new MusicaRepository();

        [HttpPost]
        public void Post([FromBody] Musica model)
        {
            repository.Create(model);
        }
        [HttpGet]
        public List<Musica> Get()
        {
            return repository.Read();
        }
        [HttpGet("{id}")]
        public Musica Get(int id)
        {
            return repository.Read(id);
        }
        [HttpPut("{id}")]
        public void Put([FromBody] Musica model)
        {
            repository.Update(model);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
