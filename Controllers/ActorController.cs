using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movies.Mappers;
using movies.Models;
using movies.Services;
using Newtonsoft.Json;

namespace movies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _as;

        public ActorController(IActorService actorService)
        {
            _as = actorService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(NewActor actor)
        {
            var result = await _as.CreateAsync(actor.ToEntity());

            if(result.IsSuccess)
            {
                return Ok();
            }

            return BadRequest(result.Exception.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var json = JsonConvert.SerializeObject(
                await _as.GetAllAsync(), Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                }
            );
            return Ok(json);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            if(await _as.ExistsAsync(id))
            {
                var json = JsonConvert.SerializeObject(
                    await _as.GetAsync(id), Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    }
                );
                return Ok(json);
            }

            return NotFound();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id)
            => Ok(await _as.DeleteAsync(id));
    }
}
