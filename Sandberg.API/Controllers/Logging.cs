using Microsoft.AspNetCore.Mvc;
using Sandberg.Business.Repository;
using Sandberg.Share.Models;
using System.Collections.Generic;

namespace Sandberg.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Logging : ControllerBase
    {
        private readonly ILoggingRepository sandbergRepository;

        public Logging(ILoggingRepository sandbergContext)
        {
            this.sandbergRepository = sandbergContext;
        }

        // GET: api/<Logging>
        [HttpGet]
        public IEnumerable<LoggingModel> Get()
        {
            return sandbergRepository.Get();
        }

        // GET api/<Logging>/5
        [HttpGet("{id}")]
        public LoggingModel Get(int id)
        {
            return sandbergRepository.Get(id);
        }

        // POST api/<Logging>
        [HttpPost]
        public void Post([FromBody] LoggingModel value)
        {
            sandbergRepository.Add(value);
        }
    }
}