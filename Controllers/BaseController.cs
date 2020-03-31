using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using codefucius_api.Data;
using Microsoft.AspNetCore.Mvc;

namespace codefucius_api.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public abstract class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public BaseController(TRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(Guid id)
        {
            var item = await repository.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity item)
        {
            await repository.Add(item);
            return CreatedAtAction("Get", new { id = item.ID }, item);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, TEntity item)
        {
            if (id != item.ID)
            {
                return BadRequest();
            }

            await repository.Update(item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(Guid id)
        {
            var item = await repository.Delete(id);
            if (item == null)
            {
                return NotFound();
            }

            return item;
        }
    }
}
