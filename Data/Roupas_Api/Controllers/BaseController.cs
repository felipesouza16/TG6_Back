using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Roupas_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<M, R> : ControllerBase where M : BaseModels where R : BaseRepository<M>
    {
        R repository = Activator.CreateInstance<R>();
        [HttpGet]
        public IEnumerable<M> Get()
        {
            return repository.Read();
        }

        [HttpGet("{id}")]
        public M Get(int id)
        {
            return repository.Read(id);
        }

        [HttpPost]
        public void Post([FromBody] M model)
        {
            repository.Create(model);
        }

        [HttpPut("{id}")]
        public void Put([FromBody] M model)
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
