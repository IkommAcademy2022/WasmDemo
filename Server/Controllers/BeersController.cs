using Microsoft.AspNetCore.Mvc;
using WasmDemo.Server.Repository;
using WasmDemo.Shared;

namespace WasmDemo.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BeersController : ControllerBase
    {
        
        private readonly ILogger<BeersController> _logger;
        private IRepository<Beer> _beerRepository;
        public BeersController(ILogger<BeersController> logger, IRepository<Beer> repo)
        {
            _logger = logger;
            _beerRepository = repo;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Beer>>> Get()
        {
            return Ok(await _beerRepository.GetAllAsync());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Beer>> Get(long id)
        {
            var beer = await _beerRepository.GetAsync(id);
            if(beer == null)
            {
                return NotFound();
            }

            return beer;
        }

        [HttpPost]
        public async Task<ActionResult<Beer>> Post(Beer beer)
        {
            var createdBeer = await _beerRepository.CreateAsync(beer);
            return CreatedAtAction(nameof(Get), new { id = createdBeer.Id }, createdBeer);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Beer>> Put(long id, Beer beer)
        {
            if (id != beer.Id)
            {
                return BadRequest();
            }

            var updatedBeer = await _beerRepository.UpdateAsync(beer);
            if (updatedBeer == null)
            {
                return NotFound();
            }   
            return Ok(updatedBeer);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(long id)
        {
            var result = await _beerRepository.DeleteAsync(id);
            if (result)
            {
                return Ok();
            }

            return NotFound();
        }

    }
}